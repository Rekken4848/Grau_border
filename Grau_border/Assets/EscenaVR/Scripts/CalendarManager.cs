using UnityEngine;
using UnityEngine.UI;

public class CalendarManager : MonoBehaviour
{
    // Color para días marcados
    public Color markedColor = Color.green;
    public Color defaultColor = Color.white;

    // Inicializa los botones del calendario
    void Start()
    {
        // Encuentra todos los botones en el panel
        Button[] dayButtons = GetComponentsInChildren<Button>();

        foreach (Button button in dayButtons)
        {
            // Agrega un listener para detectar clics
            button.onClick.AddListener(() => MarkDay(button));
        }
    }

    // Cambia el color del botón al marcarlo
    void MarkDay(Button dayButton)
    {
        Image buttonImage = dayButton.GetComponent<Image>();

        // Alternar entre marcado y no marcado
        if (buttonImage.color == markedColor)
        {
            buttonImage.color = defaultColor; // Quitar marca
        }
        else
        {
            buttonImage.color = markedColor; // Marcar
        }
    }
}
