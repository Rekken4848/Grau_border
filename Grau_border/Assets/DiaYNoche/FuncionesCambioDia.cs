using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionesCambioDia : MonoBehaviour
{
    [SerializeField] DayNightCycle dayNightCycle;
    [SerializeField] ControladorDias controladorDias;
    [SerializeField] Tutorial tutorial;
    public bool tutorial_bool = true;

    public void PausaDia()
    {
        dayNightCycle.pausa = true;
    }
    public void ReanudarDia()
    {
        if (tutorial_bool==true)
        {
            tutorial_bool = false;
            tutorial.TutorialStart();
        }
        dayNightCycle.pausa = false;
    }
    public void HoraHorarioStart()
    {
        controladorDias.EmpiezaDia();
    }

}
