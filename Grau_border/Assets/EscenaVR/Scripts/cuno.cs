using UnityEngine;
using System.Collections;

public class ColisionConSello : MonoBehaviour
{
    public bool acierto;
    public SistemaJuego sistemaJuego;

    void OnCollisionEnter(Collision col)
    {
        // Comprobamos si el objeto con el que colisionamos tiene el tag "Papel"
        if (col.gameObject.CompareTag("Papel"))
        {
            // Buscamos stamp y stamp2 dentro del objeto "Papel"
            Transform stamp = col.transform.Find("stamp");
            Transform stamp2 = col.transform.Find("stamp2");

            // Verificamos si ya hay un sello activo, si es así, no permitimos colocar otro
            if ((stamp != null && stamp.gameObject.activeSelf) || (stamp2 != null && stamp2.gameObject.activeSelf))
            {
                return; // Salimos de la función y no hacemos nada
            }

            // Verificamos qué objeto colisionó y activamos el sello correspondiente
            if (gameObject.CompareTag("cuno_verde") && stamp2 != null)
            {
                stamp2.gameObject.SetActive(true);
                acierto = sistemaJuego.comprobarAcierto(true);
                StartCoroutine(DestruirSelloDespuesDeTiempo(10f, stamp2));
            }
            else if (gameObject.CompareTag("cuno_rojo") && stamp != null)
            {
                stamp.gameObject.SetActive(true);
                acierto = sistemaJuego.comprobarAcierto(false);
                StartCoroutine(DestruirSelloDespuesDeTiempo(10f, stamp));
            }
        }
    }

    // Corrutina para destruir el sello después de un tiempo
    private IEnumerator DestruirSelloDespuesDeTiempo(float tiempo, Transform sello)
    {
        yield return new WaitForSeconds(tiempo);

        if (sello != null && sello.gameObject.activeSelf)
        {
            sello.gameObject.SetActive(false);
        }

        acierto = false;
        sistemaJuego.FinRonda();
    }
}