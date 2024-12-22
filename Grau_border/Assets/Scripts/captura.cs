using UnityEngine;

public class ScreenshotTaker : MonoBehaviour
{
    public string screenshotName = "Screenshot.png"; // Nombre del archivo de la captura
    public int superSize = 1; // Factor de escala para la resolución (1 es la resolución normal)

    void Update()
    {
        // Toma una captura al presionar la tecla "P"
        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeScreenshot();
        }
    }

    void TakeScreenshot()
    {
        // Guardar la captura en la carpeta raíz del proyecto
        ScreenCapture.CaptureScreenshot(screenshotName, superSize);
        Debug.Log("Captura de pantalla guardada: " + screenshotName);
    }
}
