using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControladorDias : MonoBehaviour
{
    [SerializeField, Range(1, 30)] int dia = 1; // Día actual
    [SerializeField, Range(1, 12)] int mes = 1; // Mes actual

    [SerializeField] int hora; // Hora actual
    [SerializeField] int minuto; // Minuto actual

    [SerializeField] float empiezaHorario;
    [SerializeField] float terminaHorario;

    [SerializeField] DayNightCycle dayNightCycle; // Referencia al ciclo día/noche
    [SerializeField] ActualizarHora actualizarHora; // Referencia al actualizador de hora

    private int horaAnterior; // Para detectar el cambio de día
    private int diaAnterior = 0; // Día anterior

    [SerializeField] Animator animatorDias;
    [SerializeField] TextMeshProUGUI diaActual;
    [SerializeField] TextMeshProUGUI diaAtras;
    [SerializeField] GameObject canvas;

    private bool pansadoDia = false;

    void Start()
    {
        canvas.SetActive(true);
        horaAnterior = hora;
        EmpiezaDia();
    }

    void Update()
    {
        (hora, minuto) = actualizarHora.ConvertTimeOfDayToHoursAndMinutes();

        /*if (horaAnterior > hora)
        {
            AvanzarDia();
        }*/

        if (hora == terminaHorario && pansadoDia == false)
        {
            pansadoDia = true;
            AvanzarDia();
        }

        horaAnterior = hora;
    }

    private void AvanzarDia()
    {
        dia++;

        if (dia > DiasEnMes(mes))
        {
            dia = 1;
            mes++;

            if (mes > 12)
            {
                mes = 1;
            }
        }


        AnimacionDia();
    }

    public void AnimacionDia()
    {
        animatorDias.Play("FinDia");
        diaActual.text = dia.ToString();
        diaAnterior = dia - 1;
        diaAtras.text = diaAnterior.ToString();
    }

    public void EmpiezaDia()
    {
        dayNightCycle.timeOfDay = empiezaHorario;
        pansadoDia = false;
    }

    private int DiasEnMes(int mes)
    {
        switch (mes)
        {
            case 2: return 28; 
            case 4: case 6: case 9: case 11: return 30;
            default: return 31;
        }
    }
}
