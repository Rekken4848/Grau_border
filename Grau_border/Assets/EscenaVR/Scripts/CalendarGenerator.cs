using UnityEngine;
using UnityEngine.UI;

public class CalendarGenerator : MonoBehaviour
{
    public GameObject buttonPrefab; // Prefab del bot�n
    public int daysInMonth = 30;    // N�mero de d�as del mes
    public int markedDay = 5;       // D�a que se quiere marcar en rojo (puedes cambiar este valor)
    public Text monthText;          // Texto para mostrar el mes y a�o

    public int selectedMonth = 1;   // Mes seleccionado (1 = Enero, 2 = Febrero, etc.)
    public int selectedYear = 2025; // A�o seleccionado

    void Start()
    {
        if (buttonPrefab == null)
        {
            Debug.LogError("No se asign� el prefab del bot�n.");
            return;
        }

        // Actualizar el texto del mes y a�o
        UpdateMonthText(selectedMonth, selectedYear);

        // Generar los botones para el calendario
        GenerateCalendar();
    }

    // M�todo para actualizar el texto del mes y a�o
    void UpdateMonthText(int month, int year)
    {
        monthText.text = new System.DateTime(year, month, 1).ToString("MMMM yyyy");
    }

    // M�todo para generar los botones del calendario
    void GenerateCalendar()
    {
        // Comienza en el d�a 2
        for (int i = 2; i <= daysInMonth; i++)
        {
            // Crear un bot�n a partir del prefab
            GameObject newButton = Instantiate(buttonPrefab, transform);

            // Cambiar el texto del bot�n al n�mero del d�a
            Text buttonText = newButton.GetComponentInChildren<Text>();
            if (buttonText != null)
            {
                buttonText.text = i.ToString(); // Asigna el n�mero del d�a

                // Marcar el d�a espec�fico (en este caso, el d�a 5)
                if (i == markedDay)
                {
                    buttonText.color = Color.red; // Cambiar el color del texto a rojo
                }
            }
            else
            {
                Debug.LogError("El prefab del bot�n no tiene un componente Text.");
            }
        }
    }
}
