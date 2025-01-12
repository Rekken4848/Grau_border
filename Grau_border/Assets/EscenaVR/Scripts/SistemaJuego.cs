using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    public float dinero;
    public bool nivelIniciado = false;
    public bool nivelFinalizado = false;

    // Datos personaje a spawnear
    public GameObject personaje;
    public Transform coordenadasPj;
    public GameObject personajeActual;
    public Personaje personaActualCaracteristicas;

    public CountryList paisesPermitidos;
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
        dinero = 0f;

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

        personajeActual.gameObject.SetActive(true);

        personaActualCaracteristicas = personajeActual.GetComponentInChildren<Personaje>();
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

            // Establecemos la fecha actual para hacer las comprobaciones
            DateTime fechaActual = new DateTime(2025, 1, 1);
            // Comprobamos que no este caducado
            if (personaActualCaracteristicas.PasaporteDelPersonaje.FechaDeCaducidad >= fechaActual)
            {
                // Comprobamos que la fecha de nacimiento sea correcta
                if (personaActualCaracteristicas.PasaporteDelPersonaje.FechaDeNacimiento < fechaActual)
                {
                    // Es de nuestro pais, todo correcto
                    if (personaActualCaracteristicas.PasaporteDelPersonaje.LugarDeNacimiento == "Espana")
                    {
                        aciertos++;
                        dinero += 100f;
                        return true;
                    }
                    else
                    {
                        // Es inmigrante, comprobar permiso y pais valido
                        if (paisesPermitidos.AllowedCountries.Contains(personaActualCaracteristicas.PasaporteDelPersonaje.LugarDeNacimiento))
                        {
                            // Nacio en un pais valido
                            if(personaActualCaracteristicas.PasaporteDelPersonaje.Nombre == personaActualCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.NombrePermiso &&
                                personaActualCaracteristicas.PasaporteDelPersonaje.Apellidos == personaActualCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.ApellidosPermiso &&
                                personaActualCaracteristicas.PasaporteDelPersonaje.FechaDeNacimiento == personaActualCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.FechaDeNacimientoPermiso &&
                                personaActualCaracteristicas.PasaporteDelPersonaje.Sexo == personaActualCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.SexoPermiso &&
                                personaActualCaracteristicas.PasaporteDelPersonaje.FechaDeCaducidad == personaActualCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.FechaDeCaducidadPermiso &&
                                personaActualCaracteristicas.PasaporteDelPersonaje.NumeroDePasaporte == personaActualCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.NumeroDePasaportePermiso &&
                                personaActualCaracteristicas.PasaporteDelPersonaje.LugarDeNacimiento == personaActualCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.LugarDeNacimientoPermiso)
                            {
                                // Sus datos del permiso coinciden con los del pasaporte
                                aciertos++;
                                dinero += 100f;
                                return true;
                            }
                            else
                            {
                                fallos++;
                                dinero -= 50f;
                                return false;
                            }
                        }
                        else
                        {
                            fallos++;
                            dinero -= 50f;
                            return false;
                        }
                    }
                }
                else
                {
                    fallos++;
                    dinero -= 50f;
                    return false;
                }
            }
            else
            {
                fallos++;
                dinero -= 50f;
                return false;
            }
        }
        else
        {
            fallos++;
            dinero -= 50f;
            return false;
        }
    }
}
