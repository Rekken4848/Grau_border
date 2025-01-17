using UnityEngine;

public class RadioControlador : MonoBehaviour
{
    [SerializeField] private GameObject radio; // El GameObject que queremos escalar.
    [SerializeField] private float duracionAnimacion = 2f; // Duración de un ciclo completo (reducirse y crecer).
    [SerializeField] private Vector3 escalaAumentada; // Escala objetivo al aumentar.

    private Vector3 escalaOriginal; // Escala inicial del objeto.
    private bool aumentando = true; // Indica si está creciendo o reduciéndose.
    private float tiempoAnimacion = 0f; // Tiempo acumulado para la animación.

    void Start()
    {
        if (radio != null)
        {
            // Guardar la escala original del objeto.
            escalaOriginal = radio.transform.localScale;
        }
        else
        {
            Debug.LogWarning("Radio no está asignado en el inspector.");
        }
    }

    void Update()
    {
        if (radio != null)
        {
            // Incrementar el tiempo basado en la duración de la animación.
            tiempoAnimacion += Time.deltaTime / duracionAnimacion;

            // Interpolar entre la escala original y la escala aumentada.
            if (aumentando)
            {
                radio.transform.localScale = Vector3.Lerp(escalaOriginal, escalaAumentada, tiempoAnimacion);

                // Verificar si completó el aumento.
                if (tiempoAnimacion >= 1f)
                {
                    tiempoAnimacion = 0f;
                    aumentando = false; // Cambiar a modo de reducción.
                }
            }
            else
            {
                radio.transform.localScale = Vector3.Lerp(escalaAumentada, escalaOriginal, tiempoAnimacion);

                // Verificar si completó la reducción.
                if (tiempoAnimacion >= 1f)
                {
                    tiempoAnimacion = 0f;
                    aumentando = true; // Cambiar a modo de aumento.
                }
            }
        }
    }

    public void NoMovimiento()
    {
        duracionAnimacion = -1f;
    }

    public void SiMovimiento()
    {
        duracionAnimacion = 0.4f;
    }
}
