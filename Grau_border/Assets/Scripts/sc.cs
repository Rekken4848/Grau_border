using UnityEngine;

public class ScreenshotCapture : MonoBehaviour
{
    // Tecla para capturar la pantalla, por ejemplo, la tecla "C"
    public KeyCode captureKey = KeyCode.C;

    // Resolu��o de la captura (puedes ajustarla)
    public int captureWidth = 1920;
    public int captureHeight = 1080;

    // Nombre del archivo donde se guardar� la captura
    private string screenshotFilename = "captura_screenshot.png";

    void Update()
    {
        // Si la tecla asignada es presionada, toma la captura
        if (Input.GetKeyDown(captureKey))
        {
            CaptureScreenshot();
        }
    }

    void CaptureScreenshot()
    {
        // Ajustar la resoluci�n de la captura
        Screen.SetResolution(captureWidth, captureHeight, false);

        // Capturar la imagen y guardarla con el nombre que asignamos
        ScreenCapture.CaptureScreenshot(screenshotFilename);

        // Mostrar un mensaje en consola para confirmar la captura
        Debug.Log("Captura de pantalla realizada: " + screenshotFilename);
    }
}
