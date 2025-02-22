using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    // Datos pasaporte
    public GameObject pasaporte;
    public TextMeshPro nombre;
    public TextMeshPro pais;
    public TextMeshPro apellido;
    public TextMeshPro fechaNacimiento;
    public TextMeshPro sexo;
    public TextMeshPro fechaCaducidad;
    public TextMeshPro numeroPasaporte;

    // Datos permiso
    public GameObject permiso;
    public TextMeshProUGUI nombrePermiso;
    public TextMeshProUGUI paisPermiso;
    public TextMeshProUGUI apellidoPermiso;
    public TextMeshProUGUI fechaNacimientoPermiso;
    public TextMeshProUGUI sexoPermiso;
    public TextMeshProUGUI fechaCaducidadPermiso;
    public TextMeshProUGUI numeroPasaportePermiso;
    public SpriteRenderer fotoPasaporte;

    // Foto pasaporte
    public List<List<List<List<Sprite>>>> fotosPasaporte;

    // Foto Ojos 1 Boca 1
    // Foto Ojos 1 Boca 1 Piel Caucasica
    public List<Sprite> ojos1Boca1PielCaucasica;

    // Foto Ojos 1 Boca 1 Piel Marron
    public List<Sprite> ojos1Boca1PielMarron;

    // Foto Ojos 1 Boca 1 Piel Negra
    public List<Sprite> ojos1Boca1PielNegra;

    // Foto Ojos 1 Boca 1 Piel Oriental
    public List<Sprite> ojos1Boca1PielOriental;

    // Foto Ojos 1 Boca2
    // Foto Ojos 1 Boca 2 Piel Caucasica
    public List<Sprite> ojos1Boca2PielCaucasica;

    // Foto Ojos 1 Boca 2 Piel Marron
    public List<Sprite> ojos1Boca2PielMarron;

    // Foto Ojos 1 Boca 2 Piel Negra
    public List<Sprite> ojos1Boca2PielNegra;

    // Foto Ojos 1 Boca 2 Piel Oriental
    public List<Sprite> ojos1Boca2PielOriental;

    // Foto Ojos 1 Boca3
    // Foto Ojos 1 Boca 3 Piel Caucasica
    public List<Sprite> ojos1Boca3PielCaucasica;

    // Foto Ojos 1 Boca 3 Piel Marron
    public List<Sprite> ojos1Boca3PielMarron;

    // Foto Ojos 1 Boca 3 Piel Negra
    public List<Sprite> ojos1Boca3PielNegra;

    // Foto Ojos 1 Boca 3 Piel Oriental
    public List<Sprite> ojos1Boca3PielOriental;

    // Foto Ojos 2 Boca 1
    // Foto Ojos 2 Boca 1 Piel Caucasica
    public List<Sprite> ojos2Boca1PielCaucasica;

    // Foto Ojos 2 Boca 1 Piel Marron
    public List<Sprite> ojos2Boca1PielMarron;

    // Foto Ojos 2 Boca 1 Piel Negra
    public List<Sprite> ojos2Boca1PielNegra;

    // Foto Ojos 2 Boca 1 Piel Oriental
    public List<Sprite> ojos2Boca1PielOriental;

    // Foto Ojos 2 Boca 2
    // Foto Ojos 2 Boca 2 Piel Caucasica
    public List<Sprite> ojos2Boca2PielCaucasica;

    // Foto Ojos 2 Boca 2 Piel Marron
    public List<Sprite> ojos2Boca2PielMarron;

    // Foto Ojos 2 Boca 2 Piel Negra
    public List<Sprite> ojos2Boca2PielNegra;

    // Foto Ojos 2 Boca 2 Piel Oriental
    public List<Sprite> ojos2Boca2PielOriental;

    // Foto Ojos 2 Boca 3
    // Foto Ojos 2 Boca 3 Piel Caucasica
    public List<Sprite> ojos2Boca3PielCaucasica;

    // Foto Ojos 2 Boca 3 Piel Marron
    public List<Sprite> ojos2Boca3PielMarron;

    // Foto Ojos 2 Boca 3 Piel Negra
    public List<Sprite> ojos2Boca3PielNegra;

    // Foto Ojos 2 Boca 3 Piel Oriental
    public List<Sprite> ojos2Boca3PielOriental;

    // Foto Ojos 3 Boca 1
    // Foto Ojos 3 Boca 1 Piel Caucasica
    public List<Sprite> ojos3Boca1PielCaucasica;

    // Foto Ojos 3 Boca 1 Piel Marron
    public List<Sprite> ojos3Boca1PielMarron;

    // Foto Ojos 3 Boca 1 Piel Negra
    public List<Sprite> ojos3Boca1PielNegra;

    // Foto Ojos 3 Boca 1 Piel Oriental
    public List<Sprite> ojos3Boca1PielOriental;

    // Foto Ojos 3 Boca 2
    // Foto Ojos 3 Boca 2 Piel Caucasica
    public List<Sprite> ojos3Boca2PielCaucasica;

    // Foto Ojos 3 Boca 2 Piel Marron
    public List<Sprite> ojos3Boca2PielMarron;

    // Foto Ojos 3 Boca 2 Piel Negra
    public List<Sprite> ojos3Boca2PielNegra;

    // Foto Ojos 3 Boca 2 Piel Oriental
    public List<Sprite> ojos3Boca2PielOriental;

    // Foto Ojos 3 Boca 3
    // Foto Ojos 3 Boca 3 Piel Caucasica
    public List<Sprite> ojos3Boca3PielCaucasica;

    // Foto Ojos 3 Boca 3 Piel Marron
    public List<Sprite> ojos3Boca3PielMarron;

    // Foto Ojos 3 Boca 3 Piel Negra
    public List<Sprite> ojos3Boca3PielNegra;

    // Foto Ojos 3 Boca 3 Piel Oriental
    public List<Sprite> ojos3Boca3PielOriental;

    //Listas de prueba
    public string[] nombresH = { "Alejandro", "Alberto", "Diego", "Carlos", "Hugo" };
    public string[] apellidosH = { "Martinez", "Hernandez", "Rodriguez", "Sanchez" };
    public string[] nombresM = { "Sara", "Sofia", "Samanta", "Raquel" };
    // public string[] apellidosM = { "Boca1", "Boca2", "Boca3", "Boca4" };
    public string[] paises = { "Espana", "Italia", "Argentina", "Marruecos", "Alemania" };
    public string[] sexos = { "M", "F" };
    // Start is called before the first frame update
    void Start()
    {
        pjCaracteristicas = personaje.GetComponent<Personaje>();

        fotosPasaporte = new List<List<List<List<Sprite>>>>
        {

        };

        listaFotos();

        generarPersonaje();

        generarDatosAleatorios();

        actualizarPj();

        actualizarPasaporte();

        generarFoto();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void listaFotos()
    {
        // Inicializa todas las capas
        // Ojos 1
        fotosPasaporte.Add(new List<List<List<Sprite>>>());
        fotosPasaporte[0].Add(new List<List<Sprite>>());
        fotosPasaporte[0][0].Add(ojos1Boca1PielCaucasica);
        fotosPasaporte[0][0].Add(ojos1Boca1PielMarron);
        fotosPasaporte[0][0].Add(ojos1Boca1PielNegra);
        fotosPasaporte[0][0].Add(ojos1Boca1PielOriental);

        fotosPasaporte[0].Add(new List<List<Sprite>>());
        fotosPasaporte[0][1].Add(ojos1Boca2PielCaucasica);
        fotosPasaporte[0][1].Add(ojos1Boca2PielMarron);
        fotosPasaporte[0][1].Add(ojos1Boca2PielNegra);
        fotosPasaporte[0][1].Add(ojos1Boca2PielOriental);

        fotosPasaporte[0].Add(new List<List<Sprite>>());
        fotosPasaporte[0][2].Add(ojos1Boca3PielCaucasica);
        fotosPasaporte[0][2].Add(ojos1Boca3PielMarron);
        fotosPasaporte[0][2].Add(ojos1Boca3PielNegra);
        fotosPasaporte[0][2].Add(ojos1Boca3PielOriental);

        // Ojos 2
        fotosPasaporte.Add(new List<List<List<Sprite>>>());
        fotosPasaporte[1].Add(new List<List<Sprite>>());
        fotosPasaporte[1][0].Add(ojos2Boca1PielCaucasica);
        fotosPasaporte[1][0].Add(ojos2Boca1PielMarron);
        fotosPasaporte[1][0].Add(ojos2Boca1PielNegra);
        fotosPasaporte[1][0].Add(ojos2Boca1PielOriental);

        fotosPasaporte[1].Add(new List<List<Sprite>>());
        fotosPasaporte[1][1].Add(ojos2Boca2PielCaucasica);
        fotosPasaporte[1][1].Add(ojos2Boca2PielMarron);
        fotosPasaporte[1][1].Add(ojos2Boca2PielNegra);
        fotosPasaporte[1][1].Add(ojos2Boca2PielOriental);

        fotosPasaporte[1].Add(new List<List<Sprite>>());
        fotosPasaporte[1][2].Add(ojos2Boca3PielCaucasica);
        fotosPasaporte[1][2].Add(ojos2Boca3PielMarron);
        fotosPasaporte[1][2].Add(ojos2Boca3PielNegra);
        fotosPasaporte[1][2].Add(ojos2Boca3PielOriental);

        // Ojos 3
        fotosPasaporte.Add(new List<List<List<Sprite>>>());
        fotosPasaporte[2].Add(new List<List<Sprite>>());
        fotosPasaporte[2][0].Add(ojos3Boca1PielCaucasica);
        fotosPasaporte[2][0].Add(ojos3Boca1PielMarron);
        fotosPasaporte[2][0].Add(ojos3Boca1PielNegra);
        fotosPasaporte[2][0].Add(ojos3Boca1PielOriental);

        fotosPasaporte[2].Add(new List<List<Sprite>>());
        fotosPasaporte[2][1].Add(ojos3Boca2PielCaucasica);
        fotosPasaporte[2][1].Add(ojos3Boca2PielMarron);
        fotosPasaporte[2][1].Add(ojos3Boca2PielNegra);
        fotosPasaporte[2][1].Add(ojos3Boca2PielOriental);

        fotosPasaporte[2].Add(new List<List<Sprite>>());
        fotosPasaporte[2][2].Add(ojos3Boca3PielCaucasica);
        fotosPasaporte[2][2].Add(ojos3Boca3PielMarron);
        fotosPasaporte[2][2].Add(ojos3Boca3PielNegra);
        fotosPasaporte[2][2].Add(ojos3Boca3PielOriental);
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

    public void actualizarPasaporte()
    {
        nombre.text = pjCaracteristicas.PasaporteDelPersonaje.Nombre;
        pais.text = pjCaracteristicas.PasaporteDelPersonaje.LugarDeNacimiento;
        apellido.text = pjCaracteristicas.PasaporteDelPersonaje.Apellidos;
        fechaNacimiento.text = pjCaracteristicas.PasaporteDelPersonaje.FechaDeNacimiento.ToString();
        fechaCaducidad.text = pjCaracteristicas.PasaporteDelPersonaje.FechaDeCaducidad.ToString();
        sexo.text = pjCaracteristicas.PasaporteDelPersonaje.Sexo;
        numeroPasaporte.text = pjCaracteristicas.PasaporteDelPersonaje.NumeroDePasaporte;

        nombrePermiso.text = pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.NombrePermiso;
        //apellidoPermiso.text = pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.ApellidosPermiso;
        //paisPermiso.text = pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.LugarDeNacimientoPermiso;
        //fechaNacimientoPermiso.text = pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.FechaDeNacimientoPermiso.ToString();
        //fechaCaducidadPermiso.text = pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.FechaDeCaducidadPermiso.ToString();
        //sexoPermiso.text = pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.SexoPermiso;
        numeroPasaportePermiso.text = pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.NumeroDePasaportePermiso;
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

        //Aqu� se pone en el gameobject
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

            // Un debug para ver si la foto es igual mientras no esten las fotos hechas
            Debug.Log("Foto igual");
        }
        else if (mismoFoto == 0)
        {
            // El personaje es distinto a la foto
            // Un debug para ver si la foto es igual mientras no esten las fotos hechas
            Debug.Log("Foto distinta");

            // Primero generamos unos ojos distintos
            pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.OjosFoto = pjCaracteristicas.Ojos;
            int ojosDistintosElegidos;
            while (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.OjosFoto == pjCaracteristicas.Ojos)
            {
                ojosDistintosElegidos = UnityRandom.Range(0, ojos.Count);

                //Aqu� se pone en el gameobject
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

        // Permiso de viaje (cambiar a solo si no es del pais de origen)
        int mismosDatos = UnityRandom.Range(0, 2);
        if(mismosDatos == 1)
        {
            pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.SexoPermiso = pjCaracteristicas.PasaporteDelPersonaje.Sexo;
            pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.NombrePermiso = pjCaracteristicas.PasaporteDelPersonaje.Nombre;
            pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.ApellidosPermiso = pjCaracteristicas.PasaporteDelPersonaje.Apellidos;
            pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.FechaDeNacimientoPermiso = pjCaracteristicas.PasaporteDelPersonaje.FechaDeNacimiento;
            pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.FechaDeCaducidadPermiso = pjCaracteristicas.PasaporteDelPersonaje.FechaDeCaducidad;
            pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.NumeroDePasaportePermiso = pjCaracteristicas.PasaporteDelPersonaje.NumeroDePasaporte;
            pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.LugarDeNacimientoPermiso = pjCaracteristicas.PasaporteDelPersonaje.LugarDeNacimiento;
        }
        else if (mismoFoto == 0)
        {
            // Sexo
            int sexoElegidoPermiso = UnityRandom.Range(0, sexos.Length);
            pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.SexoPermiso = sexos[sexoElegidoPermiso];

            // Nombre
            if (pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.SexoPermiso == "M")
            {
                int nombreElegidoPermiso = UnityRandom.Range(0, nombresH.Length);
                pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.NombrePermiso = nombresH[nombreElegidoPermiso];
            }
            else if (pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.SexoPermiso == "F")
            {
                int nombreElegidoPermiso = UnityRandom.Range(0, nombresM.Length);
                pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.NombrePermiso = nombresM[nombreElegidoPermiso];
            }

            // Apellidos
            int apellidoElegidoPermiso = UnityRandom.Range(0, apellidosH.Length);
            pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.ApellidosPermiso = apellidosH[apellidoElegidoPermiso];

            // Fecha de Nacimiento
            DateTime fechaAleatoriaDeNacimientoPermiso = GenerarFechaAleatoria(fechaInicio, fechaFin);
            pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.FechaDeNacimientoPermiso = fechaAleatoriaDeNacimientoPermiso;

            // Lugar de Nacimiento
            int lugarElegidoPermiso = UnityRandom.Range(0, paises.Length);
            pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.LugarDeNacimientoPermiso = paises[lugarElegidoPermiso];

            // Numero de pasaporte
            int numeroAleatorioPermiso = UnityRandom.Range(100000000, 999999999);
            pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.NumeroDePasaportePermiso = lugarElegidoPermiso.ToString();

            // Fecha de Caducidad
            DateTime fechaAleatoriaDeCaducidadPermiso = GenerarFechaAleatoria(fechaInicio2, fechaFin2);
            pjCaracteristicas.PasaporteDelPersonaje.PermisoDelViaje.FechaDeCaducidadPermiso = fechaAleatoriaDeCaducidadPermiso;
        }
    }

    public void generarFoto()
    {
        // Ojos 1
        if (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.OjosFoto == ojos[0])
        {
            // Boca 1
            if (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.BocaFoto == bocas[0])
            {
                // Piel Caucasica
                if (pjCaracteristicas.ColorPiel == coloresDePiel[0])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][0][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][0][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][0][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][0][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Marron
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[1])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][1][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][1][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][1][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][1][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Negra
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[2])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][2][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][2][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][2][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][2][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Oriental
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[3])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][3][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][3][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][3][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][0][3][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
            }
            // Boca 2
            else if (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.BocaFoto == bocas[1])
            {
                // Piel Caucasica
                if (pjCaracteristicas.ColorPiel == coloresDePiel[0])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][0][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][0][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][0][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][0][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Marron
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[1])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][1][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][1][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][1][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][1][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Negra
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[2])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][2][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][2][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][2][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][2][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Oriental
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[3])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][3][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][3][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][3][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][1][3][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
            }
            // Boca 3
            else if (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.BocaFoto == bocas[2])
            {
                // Piel Caucasica
                if (pjCaracteristicas.ColorPiel == coloresDePiel[0])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][0][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][0][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][0][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][0][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Marron
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[1])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][1][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][1][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][1][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][1][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Negra
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[2])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][2][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][2][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][2][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][2][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Oriental
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[3])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][3][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][3][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][3][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[0][2][3][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
            }
        }
        // Ojos 2
        else if (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.OjosFoto == ojos[1])
        {
            // Boca 1
            if (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.BocaFoto == bocas[0])
            {
                // Piel Caucasica
                if (pjCaracteristicas.ColorPiel == coloresDePiel[0])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][0][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][0][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][0][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][0][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Marron
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[1])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][1][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][1][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][1][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][1][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Negra
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[2])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][2][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][2][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][2][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][2][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Oriental
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[3])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][3][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][3][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][3][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][0][3][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
            }
            // Boca 2
            else if (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.BocaFoto == bocas[1])
            {
                // Piel Caucasica
                if (pjCaracteristicas.ColorPiel == coloresDePiel[0])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][0][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][0][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][0][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][0][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Marron
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[1])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][1][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][1][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][1][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][1][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Negra
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[2])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][2][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][2][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][2][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][2][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Oriental
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[3])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][3][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][3][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][3][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][1][3][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
            }
            // Boca 3
            else if (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.BocaFoto == bocas[2])
            {
                // Piel Caucasica
                if (pjCaracteristicas.ColorPiel == coloresDePiel[0])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][0][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][0][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][0][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][0][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Marron
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[1])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][1][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][1][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][1][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][1][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Negra
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[2])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][2][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][2][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][2][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][2][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Oriental
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[3])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][3][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][3][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][3][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[1][2][3][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
            }
        }
        // Ojos 3
        else if (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.OjosFoto == ojos[2])
        {
            // Boca 1
            if (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.BocaFoto == bocas[0])
            {
                // Piel Caucasica
                if (pjCaracteristicas.ColorPiel == coloresDePiel[0])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][0][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][0][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][0][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][0][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Marron
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[1])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][1][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][1][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][1][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][1][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Negra
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[2])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][2][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][2][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][2][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][2][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Oriental
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[3])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][3][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][3][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][3][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][0][3][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
            }
            // Boca 2
            else if (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.BocaFoto == bocas[1])
            {
                // Piel Caucasica
                if (pjCaracteristicas.ColorPiel == coloresDePiel[0])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][0][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][0][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][0][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][0][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Marron
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[1])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][1][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][1][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][1][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][1][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Negra
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[2])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][2][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][2][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][2][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][2][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Oriental
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[3])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][3][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][3][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][3][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][1][3][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
            }
            // Boca 3
            else if (pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.BocaFoto == bocas[2])
            {
                // Piel Caucasica
                if (pjCaracteristicas.ColorPiel == coloresDePiel[0])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][0][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][0][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][0][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][0][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Marron
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[1])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][1][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][1][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][1][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][1][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Negra
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[2])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][2][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][2][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][2][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][2][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
                // Piel Oriental
                else if (pjCaracteristicas.ColorPiel == coloresDePiel[3])
                {
                    // Ropa Roja
                    if (pjCaracteristicas.Ropa == ropas[0])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][3][0];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Amarilla
                    else if (pjCaracteristicas.Ropa == ropas[1])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][3][1];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Azul
                    else if (pjCaracteristicas.Ropa == ropas[2])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][3][2];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                    // Ropa Verde
                    else if (pjCaracteristicas.Ropa == ropas[3])
                    {
                        pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto = fotosPasaporte[2][2][3][3];
                        fotoPasaporte.sprite = pjCaracteristicas.PasaporteDelPersonaje.FotoDelPasaporte.Foto;
                    }
                }
            }
        }
    }

    public DateTime GenerarFechaAleatoria(DateTime inicio, DateTime fin)
    {
        // Calculamos el rango de d�as entre las fechas
        int rangoDias = (fin - inicio).Days;

        // Generamos un n�mero aleatorio dentro del rango de d�as
        int diasAleatorios = UnityEngine.Random.Range(0, rangoDias + 1);

        // Sumamos los d�as aleatorios a la fecha de inicio
        return inicio.AddDays(diasAleatorios);
    }
}
