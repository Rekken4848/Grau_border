using UnityEngine;
using TMPro;  // Asegúrate de incluir TextMeshPro

public class ChangeTextSize : MonoBehaviour
{
    // Function to change the text size when called
    public void ChangeSelectedTextSize(TextMeshProUGUI textMeshPro)
    {
        // Ensure the object has a TextMeshProUGUI component
        if (textMeshPro != null)
        {
            // Change the font size of the text
            textMeshPro.fontSize = 100f;
        }
        else
        {
            Debug.LogError("The object does not have a TextMeshProUGUI component.");
        }
    }
}
