using System;
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
    private PermisoViaje permisoDelViaje;

    public PasaportePersonaje()
    {
        fotoDelPasaporte = new FotoPasaporte();
        permisoDelViaje = new PermisoViaje();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        
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

    public PermisoViaje PermisoDelViaje
    {
        get { return permisoDelViaje; }
        set { permisoDelViaje = value; }
    }

    public class FotoPasaporte
    {
        private Sprite ojosFoto;
        private Sprite bocaFoto;
        private Material ropaFoto;
        private Material colorPielFoto;
        private Sprite foto;

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

        public Sprite Foto
        {
            get { return foto; }
            set { foto = value; }
        }
    }

    public class PermisoViaje
    {
        private string nombrePermiso;
        private string apellidosPermiso;
        private DateTime fechaDeNacimientoPermiso;
        private string lugarDeNacimientoPermiso;
        private string sexoPermiso;
        private string numeroDePasaportePermiso;
        private DateTime fechaDeCaducidadPermiso;

        public string NombrePermiso
        {
            get { return nombrePermiso; }
            set { nombrePermiso = value; }
        }

        public string ApellidosPermiso
        {
            get { return apellidosPermiso; }
            set { apellidosPermiso = value; }
        }

        public DateTime FechaDeNacimientoPermiso
        {
            get { return fechaDeNacimientoPermiso; }
            set { fechaDeNacimientoPermiso = value; }
        }

        public string LugarDeNacimientoPermiso
        {
            get { return lugarDeNacimientoPermiso; }
            set { lugarDeNacimientoPermiso = value; }
        }

        public string SexoPermiso
        {
            get { return sexoPermiso; }
            set { sexoPermiso = value; }
        }

        public string NumeroDePasaportePermiso
        {
            get { return numeroDePasaportePermiso; }
            set { numeroDePasaportePermiso = value; }
        }

        public DateTime FechaDeCaducidadPermiso
        {
            get { return fechaDeCaducidadPermiso; }
            set { fechaDeCaducidadPermiso = value; }
        }
    }
}
