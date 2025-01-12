using UnityEngine;
using System.Collections;

public class ColisionConSello : MonoBehaviour
{
    public bool acierto;  // Variable de acierto que se activará cuando se ponga el sello
    public SistemaJuego sistemaJuego;


    void OnCollisionEnter(Collision col)
    {
        // Comprobamos si el objeto con el que colisionamos tiene el tag "Papel"
        if (col.gameObject.CompareTag("Papel"))
        {
            // Buscamos el sello dentro del objeto colisionado
            Transform sello = col.transform.Find("stamp");

            if (sello != null)
            {
                // Activamos el sello si está desactivado
                if (!sello.gameObject.activeSelf)
                {
                    sello.gameObject.SetActive(true);
                    // Activamos la variable de acierto
                    // acierto = true;
                    // sistemaJuego.aciertos++;
                    acierto = sistemaJuego.comprobarAcierto();

                    // Comenzamos la rutina para destruir el sello después de 10 segundos
                    StartCoroutine(DestruirSelloDespuesDeTiempo(10f, sello));
                }
            }
            else
            {
            }
        }
    }

    // Corrutina para destruir el sello después de un tiempo
    private IEnumerator DestruirSelloDespuesDeTiempo(float tiempo, Transform sello)
    {
        // Esperamos el tiempo indicado
        yield return new WaitForSeconds(tiempo);

        // Destruimos el sello si existe
        if (sello.gameObject.activeSelf)
        {
            sello.gameObject.SetActive(false);
        }

        // Reseteamos la variable de acierto si es necesario
        acierto = false;

        // Finalizamos el turno
        sistemaJuego.FinRonda();
    }
}