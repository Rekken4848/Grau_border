using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomicerPersonaje : MonoBehaviour
{
    [SerializeField] public List<Sprite> ojos;
    [SerializeField] public List<Sprite> bocas;
    [SerializeField] public List<Material> ropas;
    [SerializeField] public List<Material> coloresDePiel;

    [SerializeField] public GameObject personaje;
    private Personaje pjCaracteristicas;

    //Listas de prueba
    public string[] ojosPrueba = { "Ojos1", "Ojos2", "Ojos3", "Ojos4" };
    public string[] bocasPrueba = { "Boca1", "Boca2", "Boca3", "Boca4" };
    public string[] ropasPrueba = { "Roja", "Azul", "Verde", "Amarillo" };
    public string[] coloresDePielPrueba = { "Caucasico", "Negro", "Arabe", "Oriental" };
    // Start is called before the first frame update
    void Start()
    {
        pjCaracteristicas = personaje.GetComponent<Personaje>();

        generarPersonaje();

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
        int ojosElegidos = Random.Range(0, ojos.Count);

        //Aquí se pone en el gameobject
        pjCaracteristicas.Ojos = ojos[ojosElegidos];
    }

    public void generarBoca()
    {
        int bocaElegida = Random.Range(0, bocas.Count);

        pjCaracteristicas.Boca = bocas[bocaElegida];
    }

    public void generarRopa()
    {
        int ropaElegida = Random.Range(0, ropas.Count);

        pjCaracteristicas.Ropa = ropas[ropaElegida];
    }

    public void generarPiel()
    {
        int pielElegida = Random.Range(0, coloresDePiel.Count);

        pjCaracteristicas.ColorPiel = coloresDePiel[pielElegida];
    }
}
