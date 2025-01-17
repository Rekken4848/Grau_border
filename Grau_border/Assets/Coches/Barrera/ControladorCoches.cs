using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCoches : MonoBehaviour
{
    [SerializeField] float tiempoEntreRandoms = 5f;
    [SerializeField] int posibilidad = 5;

    [SerializeField] GameObject spawnerDerecha;
    [SerializeField] GameObject spawnerIzquierda;

    [SerializeField] List<GameObject> coches;

    private float timer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;

        if (timer >= tiempoEntreRandoms)
        {
            int randomNumber = Random.Range(0, posibilidad);

            if (randomNumber == 1)
            {
                int randomNumberCoche = Random.Range(0, coches.Count);
                Quaternion rotacion = Quaternion.Euler(0, -90, 0);
                Instantiate(coches[randomNumberCoche], spawnerDerecha.transform.position, rotacion);
            }

            timer = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
