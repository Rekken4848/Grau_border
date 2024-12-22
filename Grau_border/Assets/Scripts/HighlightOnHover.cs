using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;

public class ChangeSceneOnClick : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
                // Si estamos en el editor de Unity
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                UnityEngine.Application.Quit(); // Especificar el espacio de nombres completo
        #endif
    }

}