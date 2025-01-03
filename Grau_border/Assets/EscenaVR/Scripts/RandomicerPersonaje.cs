using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityRandom = UnityEngine.Random;

public class RandomicerPersonaje : MonoBehaviour
{
    [SerializeField] public List<Sprite> ojos;
    [SerializeField] public List<Sprite> bocas;
    [SerializeField] public List<Material> ropas;
    [SerializeField] public List<Material> coloresDePiel;

    [SerializeField] public GameObject personaje;
    private Personaje pjCaracteristicas;

    //Listas de prueba
    public string[] nombresH = { "Alejandro", "Alberto", "Diego", "Carlos", "Hugo" };
    public string[] apellidosH = { "Martinez", "Hernandez", "Rodriguez", "Sanchez" };
    public string[] nombresM = { "Sara", "Sofia", "Samanta", "Raquel" };
    // public string[] apellidosM = { "Boca1", "Boca2", "Boca3", "Boca4" };
    public string[] paises = { "Espana", "Italia", "Argentina", "Marruecos" };
    public string[] sexos = { "M", "F" };
    // Start is called before the first frame update
    void Start()
    {
        pjCaracteristicas = personaje.GetComponent<Personaje>();

        generarPersonaje();

        generarDatosAleatorios();

        actualizarPj();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void actualizarPj()
    {
        // Ojos
        Transform ojosTransform = personaje.transform.Find("Ojos");
        SpriteRenderer ojosSpriteRenderer = ojosTransform.GetComponent<SpriteRenderer>();
        ojosSpriteRenderer.sprite = pjCaracteristicas.Ojos;


        // Boca
        Transform bocaTransform = personaje.transform.Find("Boca");
        SpriteRenderer bocaSpriteRenderer = bocaTransform.GetComponent<SpriteRenderer>();
        bocaSpriteRenderer.sprite = pjCaracteristicas.Boca;

        //Ropa
        Transform ropaIzqTransform = personaje.transform.Find("manolo/ropaIzquierda");
        Transform ropaDerTransform = personaje.transform.Find("manolo/ropaDerecha");
        MeshRenderer ropaIzqMR = ropaIzqTransform.GetComponent<MeshRenderer>();
        MeshRenderer ropaDerMR = ropaDerTransform.GetComponent<MeshRenderer>();
        ropaIzqMR.material = pjCaracteristicas.Ropa;
        ropaDerMR.material = pjCaracteristicas.Ropa;

        //Piel
        Transform cuelloTransform = personaje.transform.Find("manolo/cuello");
        Transform cabezaTransform = personaje.transform.Find("manolo/cabeza");
        Transform manoIzqTransform = personaje.transform.Find("manolo/manoIzquierda/manoIzquierdaDentro");
        Transform manoDerTransform = personaje.transform.Find("manolo/manoDerecha");
        MeshRenderer cuelloMR = cuelloTransform.GetComponent<MeshRenderer>();
        MeshRenderer cabezaMR = cabezaTransform.GetComponent<MeshRenderer>();
        MeshRenderer manoIzqMR = manoIzqTransform.GetComponent<MeshRenderer>();
        MeshRenderer manoDerMR = manoDerTransform.GetComponent<MeshRenderer>();
        cuelloMR.material = pjCaracteristicas.ColorPiel;
        cabezaMR.material = pjCaracteristicas.ColorPiel;
        manoIzqMR.material = pjCaracteristicas.ColorPiel;
        manoDerMR.material = pjCaracteristicas.ColorPiel;
    }

    public void generarPersonaje()
    {
        generarOjos();
        generarBoca();
        generarRopa();
        generarPiel();
    }

    public void generarOjos()
    {
        int ojosElegidos = UnityRandom.Range(0, ojos.Count);

        //Aquí se pone en el gameobject
        pjCaracteristicas.Ojos = ojos[ojosElegidos];
    }

    public void generarBoca()
    {
        int bocaElegida = UnityRandom.Range(0, bocas.Count);

        pjCaracteristicas.Boca = bocas[bocaElegida];
    }

    public void generarRopa()
    {
        int ropaElegida = UnityRandom.Range(0, ropas.Count);

        pjCaracteristicas.Ropa = ropas[ropaElegida];
    }

    public void generarPiel()
    {
        int pielElegida = UnityRandom.Range(0, coloresDePiel.Count);

        pjCaracteristicas.ColorPiel = coloresDePiel[pielElegida];
    }

    public void generarDatosAleatorios()
    {
        // Sexo
        int sexoElegido = UnityRandom.Range(0, sexos.Length);
        pjCaracteristicas.PasaporteDelPersonaje.Sexo = sexos[sexoElegido];

        // Nombre
        if(pjCaracteristicas.PasaporteDelPersonaje.Sexo == "M")
        {
            int nombreElegido = UnityRandom.Range(0, nombresH.Length);
            pjCaracteristicas.PasaporteDelPersonaje.Nombre = nombresH[nombreElegido];
        }
        else if(pjCaracteristicas.PasaporteDelPersonaje.Sexo == "F")
        {
            int nombreElegido = UnityRandom.Range(0, nombresM.Length);
            pjCaracteristicas.PasaporteDelPersonaje.Nombre = nombresM[nombreElegido];
        }

        // Apellidos
        int apellidoElegido = UnityRandom.Range(0, apellidosH.Length);
        pjCaracteristicas.PasaporteDelPersonaje.Apellidos = apellidosH[apellidoElegido];

        // Fecha de Nacimiento
        DateTime fechaInicio = new DateTime(1900, 1, 1); // Fecha inicial
        DateTime fechaFin = new DateTime(2020, 12, 31); // Fecha final
        DateTime fechaAleatoriaDeNacimiento = GenerarFechaAleatoria(fechaInicio, fechaFin);
        pjCaracteristicas.PasaporteDelPersonaje.FechaDeNacimiento = fechaAleatoriaDeNacimiento;

        // Lugar de Nacimiento
        int lugarElegido = UnityRandom.Range(0, paises.Length);
        pjCaracteristicas.PasaporteDelPersonaje.LugarDeNacimiento = paises[lugarElegido];

        // Numero de pasaporte
        int numeroAleatorio = UnityRandom.Range(100000000, 999999999);
        pjCaracteristicas.PasaporteDelPersonaje.NumeroDePasaporte = numeroAleatorio.ToString();

        // Fecha de Caducidad
        DateTime fechaInicio2 = new DateTime(2010, 1, 1); // Fecha inicial
        DateTime fechaFin2 = new DateTime(2035, 12, 31); // Fecha final
        DateTime fechaAleatoriaDeCaducidad = GenerarFechaAleatoria(fechaInicio2, fechaFin2);
        pjCaracteristicas.PasaporteDelPersonaje.FechaDeCaducidad = fechaAleatoriaDeCaducidad;

        // Foto
        int mismoFoto = UnityRandom.Range(0, 2);
        if (mismoFoto == 1)
        {
            // El personaje es igual a la foto
            pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.OjosFoto = pjCaracteristicas.Ojos;
            pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.BocaFoto = pjCaracteristicas.Boca;
            pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.RopaFoto = pjCaracteristicas.Ropa;
            pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.ColorPiel = pjCaracteristicas.ColorPiel;
        }
        else if (mismoFoto == 0)
        {
            // El personaje es distinto a la foto

            // Primero generamos unos ojos distintos
            pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.OjosFoto = pjCaracteristicas.Ojos;
            int ojosDistintosElegidos;
            while (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.OjosFoto == pjCaracteristicas.Ojos)
            {
                ojosDistintosElegidos = UnityRandom.Range(0, ojos.Count);

                //Aquí se pone en el gameobject
                pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.OjosFoto = ojos[ojosDistintosElegidos];
            }

            // Ahora generamos unas bocas distintas
            pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.BocaFoto = pjCaracteristicas.Boca;
            int bocaDistintaElegida;
            while (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.BocaFoto == pjCaracteristicas.Boca)
            {
                bocaDistintaElegida = UnityRandom.Range(0, bocas.Count);

                pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.BocaFoto = bocas[bocaDistintaElegida];
            }

            // Ahora generamos la ropa distinta
            pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.RopaFoto = pjCaracteristicas.Ropa;
            int ropaDistintaElegida;
            while (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.RopaFoto == pjCaracteristicas.Ropa)
            {
                ropaDistintaElegida = UnityRandom.Range(0, ropas.Count);

                pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.RopaFoto = ropas[ropaDistintaElegida];
            }

            // Ahora generamos un color de piel distinto
            pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.ColorPiel = pjCaracteristicas.ColorPiel;
            int pielDistintaElegida;
            while (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.ColorPiel == pjCaracteristicas.ColorPiel)
            {
                pielDistintaElegida = UnityRandom.Range(0, coloresDePiel.Count);

                pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.ColorPiel = coloresDePiel[pielDistintaElegida];
            }
        }
    }

    public DateTime GenerarFechaAleatoria(DateTime inicio, DateTime fin)
    {
        // Calculamos el rango de días entre las fechas
        int rangoDias = (fin - inicio).Days;

        // Generamos un número aleatorio dentro del rango de días
        int diasAleatorios = UnityEngine.Random.Range(0, rangoDias + 1);

        // Sumamos los días aleatorios a la fecha de inicio
        return inicio.AddDays(diasAleatorios);
    }
}
