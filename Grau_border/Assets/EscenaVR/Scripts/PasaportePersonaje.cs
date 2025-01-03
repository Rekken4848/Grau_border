using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PasaportePersonaje : MonoBehaviour
{
    private string nombre;
    private string apellidos;
    private DateTime fechaDeNacimiento;
    private string lugarDeNacimiento;
    private string sexo;
    private string numeroDePasaporte;
    private DateTime fechaDeCaducidad;
    private FotoPasaporte fotoDelPasaporte;

    public PasaportePersonaje()
    {
        fotoDelPasaporte = new FotoPasaporte();
    }
    // Start is called before the first frame update
    void Start()
    {
        /*nombre = "";
        apellidos = "";
        fechaDeNacimiento = "";
        lugarDeNacimiento = "";
        sexo = "";
        numeroDePasaporte = "";
        fechaDeCaducidad = "";*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        // fotoDelPasaporte = new FotoPasaporte();
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Apellidos
    {
        get { return apellidos; }
        set { apellidos = value; }
    }

    public DateTime FechaDeNacimiento
    {
        get { return fechaDeNacimiento; }
        set { fechaDeNacimiento = value; }
    }

    public string LugarDeNacimiento
    {
        get { return lugarDeNacimiento; }
        set { lugarDeNacimiento = value; }
    }

    public string Sexo
    {
        get { return sexo; }
        set { sexo = value; }
    }

    public string NumeroDePasaporte
    {
        get { return numeroDePasaporte; }
        set { numeroDePasaporte = value; }
    }

    public DateTime FechaDeCaducidad
    {
        get { return fechaDeCaducidad; }
        set { fechaDeCaducidad = value; }
    }

    public FotoPasaporte FotoDelPasaporte
    {
        get { return fotoDelPasaporte; }
        set { fotoDelPasaporte = value; }
    }

    public class FotoPasaporte
    {
        private Sprite ojosFoto;
        private Sprite bocaFoto;
        private Material ropaFoto;
        private Material colorPielFoto;

        public Sprite OjosFoto
        {
            get { return ojosFoto; }
            set { ojosFoto = value; }
        }

        public Sprite BocaFoto
        {
            get { return bocaFoto; }
            set { bocaFoto = value; }
        }

        public Material RopaFoto
        {
            get { return ropaFoto; }
            set { ropaFoto = value; }
        }

        public Material ColorPiel
        {
            get { return colorPielFoto; }
            set { colorPielFoto = value; }
        }
    }
}
