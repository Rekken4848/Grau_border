using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActualizarHora : MonoBehaviour
{
    [SerializeField] TextMeshPro horas; // Componente para mostrar las horas
    [SerializeField] TextMeshPro minutos; // Componente para mostrar los minutos
    [SerializeField] TextMeshPro puntitos; // Componente para mostrar los puntitos
    [SerializeField] TextMeshProUGUI fecha;

    [SerializeField] DayNightCycle dayNightCycle;

    private float puntitosTimer = 0f;
    private bool puntitosVisibles = true; // Control de visibilidad de los puntitos

    void Start()
    {
        dayNightCycle.GetComponent<DayNightCycle>();
    }

    void Update()
    {
        // Actualizar horas y minutos
        (int hour, int minute) = ConvertTimeOfDayToHoursAndMinutes();
        if (minute % 10 == 0)
        {
            horas.text = hour.ToString("D2");
            minutos.text = minute.ToString("D2");
        }

        // Alternar la visibilidad de los puntitos
        UpdatePuntitosAlpha();
    }

    private void UpdatePuntitosAlpha()
    {
        // Incrementar el temporizador
        puntitosTimer += Time.deltaTime;

        if (puntitosTimer >= 1f) // Cada 1 segundo
        {
            puntitosVisibles = !puntitosVisibles; // Alternar estado de visibilidad
            Color colorActual = puntitos.color; // Obtener el color actual
            colorActual.a = puntitosVisibles ? 1f : 0f; // Alpha: 1 (visible) o 0 (invisible)
            puntitos.color = colorActual; // Aplicar el nuevo color

            puntitosTimer = 0f; // Reiniciar el temporizador
        }
    }

    public (int hour, int minute) ConvertTimeOfDayToHoursAndMinutes()
    {
        float timeOfDay = dayNightCycle.timeOfDay;
        // Asegurarnos de que timeOfDay esté dentro del rango [0, 24]
        timeOfDay = Mathf.Clamp(timeOfDay, 0f, 24f);

        // Convertir timeOfDay a horas y minutos
        int hours = Mathf.FloorToInt(timeOfDay);
        int minutes = Mathf.FloorToInt((timeOfDay - hours) * 60);

        return (hours, minutes); // Devolver horas y minutos como tupla
    }
}
