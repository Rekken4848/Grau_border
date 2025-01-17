using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coches : MonoBehaviour
{
    [SerializeField] float velocidad = 5f;
    public bool detener = false;

    [SerializeField] AudioSource Normal;
    [SerializeField] AudioSource Pito;

    private float tiempoDesdeUltimoSonido = 0f; // Temporizador para controlar la frecuencia del sonido
    [SerializeField] float intervaloSonido = 5f; // Intervalo mínimo entre sonidos en segundos

    public float pitchValue1 = 1; // Primer valor del pitch
    public float pitchValue2 = 2;   // Segundo valor del pitch
    [SerializeField] AudioSource audioSource;

    public float randomPitch;

    private void Start()
    {
        randomPitch = Random.Range(pitchValue1, pitchValue2);
        audioSource.pitch = randomPitch;
    }

    void Update()
    {
        if (!detener)
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }

        tiempoDesdeUltimoSonido += Time.deltaTime;

        if (tiempoDesdeUltimoSonido >= intervaloSonido)
        {
            int random = Random.Range(1, 11);

            if (random == 1)
            {  
                Pito.Play();
            }

            // Reinicia el temporizador
            tiempoDesdeUltimoSonido = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Barrera"))
        {
            detener = true;
        }

        if (other.CompareTag("Coche"))
        {
            detener = true;
        }

        if (other.CompareTag("Destruccion"))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Barrera"))
        {
            detener = false;
        }

        if (other.CompareTag("Coche"))
        {
            detener = false;
        }
    }
}
