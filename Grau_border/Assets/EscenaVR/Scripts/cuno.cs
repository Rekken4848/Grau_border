using UnityEngine;
using System.Collections;

public class ColisionConSello : MonoBehaviour
{
    public GameObject selloPrefab;  // El objeto de sello que aparecerá
    private GameObject selloInstanciado;  // Para mantener el control del sello creado
    public Vector3 offsetSello;  // Offset relativo a la posición del objeto para el sello
    public bool acierto;  // Variable de acierto que se activará cuando se ponga el sello
    public SistemaJuego sistemaJuego;

    void OnCollisionEnter(Collision col)
    {
        // Comprobamos si el objeto con el que colisionamos tiene el tag "Papel"
        if (col.gameObject.CompareTag("Papel"))
        {
            // Si no existe un sello, lo creamos
            if (selloInstanciado == null)
            {
                // Calculamos la posición del sello relativa al objeto
                // Esto utiliza la posición del objeto "Papel" más el offset definido
                Vector3 posicionSello = col.transform.position + offsetSello;

                // Instanciamos el sello en la posición calculada
                selloInstanciado = Instantiate(selloPrefab, posicionSello, Quaternion.identity);

                // Establecemos la rotación para que quede paralelo al "Papel"
                Vector3 normal = col.contacts[0].normal;  // Normal de la superficie de colisión
                Quaternion rotacion = Quaternion.LookRotation(normal);  // Alineamos el sello con la superficie del "Papel"

                // Aseguramos que el sello quede horizontal respecto al "Papel"
                rotacion = Quaternion.Euler(90, rotacion.eulerAngles.y, 0); // Este ajuste mantiene el sello paralelo al plano

                // Aplicamos la rotación ajustada al sello
                selloInstanciado.transform.rotation = rotacion;

                // Hacemos que el sello se mantenga fijo en la posición del "Papel"
                selloInstanciado.transform.SetParent(col.transform);

                // Si es necesario, aplicamos un pequeño ajuste adicional para que el sello esté correctamente posicionado
                selloInstanciado.transform.localPosition += offsetSello;  // Aplicamos el offset si es necesario

                // Activamos la variable de acierto
                // acierto = true;
                // sistemaJuego.aciertos++;
                acierto = sistemaJuego.comprobarAcierto();

                // Comenzamos la rutina para destruir el sello después de 10 segundos
                StartCoroutine(DestruirSelloDespuesDeTiempo(10f));
            }
        }
    }

    // Corrutina para destruir el sello después de un tiempo
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