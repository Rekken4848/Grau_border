using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] ControladorDias controladorDias;
    [SerializeField] RadioControlador radioControlador;
    [SerializeField] AudioSource audio1;
    [SerializeField] GameObject audioParticula;

    // Start is called before the first frame update
    void Start()
    {
        audioParticula.SetActive(false);
        radioControlador.NoMovimiento();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audio1.isPlaying && audio1.time > 0)
        {
            audioParticula.SetActive(false);
            Debug.Log("El audio ha terminado.");
            //Empiezan a pasar personas
        }
    }

    public void TutorialStart()
    {
        audioParticula.SetActive(true);
        radioControlador.SiMovimiento();
        audio1.Play();
    }
}
