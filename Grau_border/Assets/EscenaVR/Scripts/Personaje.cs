using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private Sprite ojos;
    private Sprite boca;
    private Material ropa;
    private Material colorPiel;
    private PasaportePersonaje pasaporteDelPersonaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        pasaporteDelPersonaje = new PasaportePersonaje();
    }

    public Sprite Ojos
    {
        get { return ojos; }
        set { ojos = value; }
    }

    public Sprite Boca
    {
        get { return boca; }
        set { boca = value; }
    }

    public Material Ropa
    {
        get { return ropa; }
        set { ropa = value; }
    }

    public Material ColorPiel
    {
        get { return colorPiel; }
        set { colorPiel = value; }
    }

    public PasaportePersonaje PasaporteDelPersonaje
    {
        get { return pasaporteDelPersonaje; }
        set { pasaporteDelPersonaje = value; }
    }
}
