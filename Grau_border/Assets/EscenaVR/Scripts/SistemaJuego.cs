using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SistemaJuego : MonoBehaviour
{
    public int nivel; // Tutorial es 0
    public int ronda; //Empieza en 0 y pasa a 1
    public int numRondas;
    public int aciertos;
    public bool nivelIniciado = false;
    public bool nivelFinalizado = false;

    // Datos personaje a spawnear
    public GameObject personaje;
    public Transform coordenadasPj;
    public GameObject personajeActual;

    // Datos pasaporte
    public GameObject pasaporte;
    public TextMeshPro nombre;
    public TextMeshPro pais;
    // Start is called before the first frame update
    void Start()
    {
        //Establecemos nivel
        string nombreEscena = SceneManager.GetActiveScene().name;
        if (nombreEscena != "Tutorial")
        {
            nivel = 1;
        }
        else
        {
            nivel = 0;
        }

        //Confirmamos el numero de rondas
        if(nivel != 0)
        {
            numRondas = 20;
        }
        else
        {
            numRondas = 10;
        }

        ronda = 0;

        //Iniciamos nivel
        nivelIniciado = true;
        iniciarRonda();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void iniciarRonda()
    {
        // Si el la primera ronda, iniciamos
        if(ronda == 0)
        {
            ronda = 1;
        }

        // Despawnear si hubiese pj

        // Spawneamos el nuevo pj
        personajeActual = Instantiate(personaje, coordenadasPj.position, coordenadasPj.rotation);

        // Los datos del pasaported
        nombre.text = "David";
        pais.text = "Espana";
    }

    public void FinRonda()
    {
        // Despawneo
        Destroy(personajeActual);

        // Resetear pasaporte

        // Si es la ronda final acabar juego
        if(ronda == 0)
        {
            nivelFinalizado = true;
        }

        // Cambiamos de ronda
        ronda++;
    }
}
