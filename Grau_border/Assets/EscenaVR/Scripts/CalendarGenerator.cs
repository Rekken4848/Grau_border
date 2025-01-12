using UnityEngine;
using UnityEngine.UI;

public class CalendarGenerator : MonoBehaviour
{
    public GameObject buttonPrefab; // Prefab del botón
    public int daysInMonth = 30;    // Número de días del mes
    public int markedDay = 5;       // Día que se quiere marcar en rojo (puedes cambiar este valor)
    public Text monthText;          // Texto para mostrar el mes y año

    public int selectedMonth = 1;   // Mes seleccionado (1 = Enero, 2 = Febrero, etc.)
    public int selectedYear = 2025; // Año seleccionado

    void Start()
    {
        if (buttonPrefab == null)
        {
            Debug.LogError("No se asignó el prefab del botón.");
            return;
        }

        // Actualizar el texto del mes y año
        UpdateMonthText(selectedMonth, selectedYear);

        // Generar los botones para el calendario
        GenerateCalendar();
    }

    // Método para actualizar el texto del mes y año
    void UpdateMonthText(int month, int year)
    {
        monthText.text = new System.DateTime(year, month, 1).ToString("MMMM yyyy");
    }

    // Método para generar los botones del calendario
    void GenerateCalendar()
    {
        // Comienza en el día 2
        for (int i = 2; i <= daysInMonth; i++)
        {
            // Crear un botón a partir del prefab
            GameObject newButton = Instantiate(buttonPrefab, transform);

            // Cambiar el texto del botón al número del día
            Text buttonText = newButton.GetComponentInChildren<Text>();
            if (buttonText != null)
            {
                buttonText.text = i.ToString(); // Asigna el número del día

                // Marcar el día específico (en este caso, el día 5)
                if (i == markedDay)
                {
                    buttonText.color = Color.red; // Cambiar el color del texto a rojo
                }
            }
            else
            {
                Debug.LogError("El prefab del botón no tiene un componente Text.");
            }
        }
    }
}
