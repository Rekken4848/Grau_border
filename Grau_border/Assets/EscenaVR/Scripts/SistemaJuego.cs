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
    public int fallos;
    public bool nivelIniciado = false;
    public bool nivelFinalizado = false;

    // Datos personaje a spawnear
    public GameObject personaje;
    public Transform coordenadasPj;
    public GameObject personajeActual;
    public Personaje personaActualCaracteristicas;

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
        aciertos = 0;
        fallos = 0;

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

        personaActualCaracteristicas = personajeActual.GetComponentInChildren<Personaje>();

        // Los datos del pasaported
        //personaActualCaracteristicas.PasaporteDelPersonaje.Nombre = "David";
        //personaActualCaracteristicas.PasaporteDelPersonaje.LugarDeNacimiento = "Espana";

        // Aqui no se han creado aun los nombres, mover
        nombre.text = personaActualCaracteristicas.PasaporteDelPersonaje.Nombre;
        pais.text = personaActualCaracteristicas.PasaporteDelPersonaje.LugarDeNacimiento;
        //nombre.text = "David";
        //pais.text = "Espana";
    }

    public void FinRonda()
    {
        // Despawneo
        Destroy(personajeActual);

        // Resetear pasaporte

        // Si es la ronda final acabar juego
        if(ronda == numRondas)
        {
            nivelFinalizado = true;
        }
        else
        {
            // Cambiamos de ronda
            ronda++;
            iniciarRonda();
        }
    }

    public bool comprobarAcierto()
    {
        // Comprobar si el pasaporte es correcto
        if (personaActualCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.OjosFoto == personaActualCaracteristicas.Ojos && personaActualCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.BocaFoto == personaActualCaracteristicas.Boca && personaActualCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.RopaFoto == personaActualCaracteristicas.Ropa && personaActualCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.ColorPiel == personaActualCaracteristicas.ColorPiel)
        {
            // Proximamente poner tambien estas comprobaciones: fecha expedicion ( que no este caducado ), fecha normal (que no sea creado en el futuro o algo raro)
            // Y que coincidan los datos con el futuro papel, incluso algo de que sea de x pais
            aciertos++;
            return true;
        }
        else
        {
            fallos++;
            return false;
        }
    }
}
