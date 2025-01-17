using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField, Range(0, 24)] public float timeOfDay;
    [SerializeField] public bool isDay;
    [SerializeField] public bool pausa; // Variable para controlar la pausa

    [SerializeField] private float duracionEnMinutos;
    [SerializeField] List<Luz> luces;

    [SerializeField] Gradient lightColor;
    [SerializeField] Gradient lightAlpha;

    [SerializeField] Light fuenteDeLuz;
    [SerializeField] float inclinacion; // 28 , 45
    [Curve(0, 0, 1f, 1f, true)]
    public AnimationCurve intensityMultiplier;
    [Curve(0, 0, 1f, 1f, true)]
    public AnimationCurve intensityLight;

    [SerializeField] Gradient materialTop;
    [SerializeField] Gradient materialBottom;

    [SerializeField] Material material;

    private void Update()
    {
        if (!pausa) // Solo avanzar el tiempo si no está en pausa
        {
            timeOfDay += ((Time.deltaTime / 60f) / duracionEnMinutos * 24) % 24;

            if (timeOfDay > 24)
            {
                timeOfDay = 0;
            }
        }

        UpdateLighting();
        //UpdateOtherLights();
    }

    private void OnValidate()
    {
        UpdateLighting();
        //UpdateOtherLights();
    }

    private void UpdateLighting()
    {
        float timeFraction = timeOfDay / 24;
        float angulo = (timeOfDay - 12f) * 15f;

        fuenteDeLuz.transform.rotation = Quaternion.Euler(inclinacion, angulo, 0);
        fuenteDeLuz.color = lightColor.Evaluate(timeFraction);

        material.SetColor("_SkyGradientTop", materialTop.Evaluate(timeFraction));
        material.SetColor("_SkyGradientBottom", materialBottom.Evaluate(timeFraction));


        isDay = timeOfDay > 6f && timeOfDay < 20f;

        if (luces != null && luces.Count > 0)
        {
            foreach (Luz light in luces)
            {
                light.luz.intensity = light.intensidad * intensityLight.Evaluate(timeFraction);
            }
        }

        RenderSettings.ambientIntensity = intensityMultiplier.Evaluate(timeFraction);
    }

    public bool IsDay()
    {
        return isDay;
    }

    public float GetTimeOfDay()
    {
        return timeOfDay;
    }
}

[System.Serializable]
public class Luz
{
    public Light luz;
    public float intensidad;

    public Luz(Light luz, float intensidad)
    {
        this.luz = luz;
        this.intensidad = intensidad;
    }
}

[System.Serializable]
public class CurveAttribute : PropertyAttribute
{
    public float PosX, PosY;
    public float RangeX, RangeY;
    public bool b;
    public int x;

    public CurveAttribute(float PosX, float PosY, float RangeX, float RangeY, bool b)
    {
        this.PosX = PosX;
        this.PosY = PosY;
        this.RangeX = RangeX;
        this.RangeY = RangeY;
        this.b = b;
    }
}
