using UnityEngine;
using System.Collections;

public class ColisionConSello : MonoBehaviour
{
    public GameObject selloPrefab;  // El objeto de sello que aparecer�
    private GameObject selloInstanciado;  // Para mantener el control del sello creado
    public Vector3 offsetSello;  // Offset relativo a la posici�n del objeto para el sello
    public bool acierto;  // Variable de acierto que se activar� cuando se ponga el sello
    public SistemaJuego sistemaJuego;

    void OnCollisionEnter(Collision col)
    {
        // Comprobamos si el objeto con el que colisionamos tiene el tag "Papel"
        if (col.gameObject.CompareTag("Papel"))
        {
            // Si no existe un sello, lo creamos
            if (selloInstanciado == null)
            {
                // Calculamos la posici�n del sello relativa al objeto
                // Esto utiliza la posici�n del objeto "Papel" m�s el offset definido
                Vector3 posicionSello = col.transform.position + offsetSello;

                // Instanciamos el sello en la posici�n calculada
                selloInstanciado = Instantiate(selloPrefab, posicionSello, Quaternion.identity);

                // Establecemos la rotaci�n para que quede paralelo al "Papel"
                Vector3 normal = col.contacts[0].normal;  // Normal de la superficie de colisi�n
                Quaternion rotacion = Quaternion.LookRotation(normal);  // Alineamos el sello con la superficie del "Papel"

                // Aseguramos que el sello quede horizontal respecto al "Papel"
                rotacion = Quaternion.Euler(90, rotacion.eulerAngles.y, 0); // Este ajuste mantiene el sello paralelo al plano

                // Aplicamos la rotaci�n ajustada al sello
                selloInstanciado.transform.rotation = rotacion;

                // Hacemos que el sello se mantenga fijo en la posici�n del "Papel"
                selloInstanciado.transform.SetParent(col.transform);

                // Si es necesario, aplicamos un peque�o ajuste adicional para que el sello est� correctamente posicionado
                selloInstanciado.transform.localPosition += offsetSello;  // Aplicamos el offset si es necesario

                // Activamos la variable de acierto
                // acierto = true;
                // sistemaJuego.aciertos++;
                acierto = sistemaJuego.comprobarAcierto();

                // Comenzamos la rutina para destruir el sello despu�s de 10 segundos
                StartCoroutine(DestruirSelloDespuesDeTiempo(10f));
            }
        }
    }

    // Corrutina para destruir el sello despu�s de un tiempo
    private IEnumerator DestruirSelloDespuesDeTiempo(float tiempo)
    {
        // Esperamos el tiempo indicado
        yield return new WaitForSeconds(tiempo);

        // Destruimos el sello si existe
        if (selloInstanciado != null)
        {
            Destroy(selloInstanciado);
        }

        // Reseteamos la variable de acierto si es necesario
        acierto = false;

        // Finalizamos el turno
        sistemaJuego.FinRonda();
    }
}