using UnityEngine;

public class ScreenshotTaker : MonoBehaviour
{
    public string screenshotName = "Screenshot.png"; // Nombre del archivo de la captura
    public int superSize = 1; // Factor de escala para la resoluci�n (1 es la resoluci�n normal)

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
        // Guardar la captura en la carpeta ra�z del proyecto
        ScreenCapture.CaptureScreenshot(screenshotName, superSize);
        Debug.Log("Captura de pantalla guardada: " + screenshotName);
    }
}
