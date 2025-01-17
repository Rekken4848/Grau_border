using System.Collections;
using TMPro;
using UnityEngine;

public class ControladorDinero : MonoBehaviour
{
    [ContextMenuItem("Ejecutar Función", "AnadirDineroEditor")]
    [SerializeField] public int dinero = 500;
    [SerializeField] Material material;
    [SerializeField] Color verde; 
    [SerializeField] Color naranja;
    [SerializeField] Color rojo; 

    [SerializeField] int rojoApartirDe = 0;
    [SerializeField] int naranjaApartirDe = 250;

    [SerializeField] TextMeshPro txtDinero;

    void Start()
    {

    }

    void Update()
    {
        if (dinero <= rojoApartirDe)
        {
            ActualizarColor(rojo);
        }
        else if (dinero > rojoApartirDe && dinero < naranjaApartirDe)
        {
            ActualizarColor(naranja);
        }
        else
        {
            ActualizarColor(verde);
        }
        txtDinero.text = dinero.ToString() + "e";
    }

    private void OnValidate()
    {
        if (dinero <= rojoApartirDe)
        {
            ActualizarColor(rojo);
        }
        else if (dinero > rojoApartirDe && dinero < naranjaApartirDe)
        {
            ActualizarColor(naranja);
        }
        else
        {
            ActualizarColor(verde);
        }
        txtDinero.text = dinero.ToString() + "e";

    }
    public void AnadirDineroEditor()
    {
        StartCoroutine(IncrementarDineroProgresivamente(100));
    }
    public void AnadirDinero(int masDinero)
    {
        StartCoroutine(IncrementarDineroProgresivamente(masDinero));
    }

    private void ActualizarColor(Color color)
    {
        material.SetColor("_Color", color);
    }

    private IEnumerator IncrementarDineroProgresivamente(int masDinero)
    {
        int incremento = (int)Mathf.Sign(masDinero); // Determina si sumas (+1) o restas (-1)
        int pasos = Mathf.Abs(masDinero); // Total de incrementos necesarios
        float intervalo = pasos > 0 ? 1f / pasos : 0f; // Duración entre cada incremento para completar en 1s

        for (int i = 0; i < pasos; i++)
        {
            dinero += incremento;
            yield return new WaitForSeconds(intervalo);
        }
    }
}
