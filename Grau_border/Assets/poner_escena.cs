using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class ImageToAddiviteScene : MonoBehaviour
{
    [SerializeField] private string sceneName; // Nombre de la escena que se cargar�
    [SerializeField] private GameObject projectionPlane; // Plano donde se proyectar� la escena

    private bool isSceneLoaded = false; // Para evitar cargar la escena varias veces

    void Start()
    {
        // Obt�n el ObserverBehaviour del Image Target
        var imageTargetBehaviour = GetComponent<ObserverBehaviour>();

        if (imageTargetBehaviour != null)
        {
            // Registra el evento de detecci�n
            imageTargetBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        // Detectar cuando el estado es TRACKED o EXTENDED_TRACKED
        if ((targetStatus.Status == Status.TRACKED || targetStatus.Status == Status.EXTENDED_TRACKED) && !isSceneLoaded)
        {
            Debug.Log($"Imagen detectada. Cargando escena: {sceneName}");
            LoadSceneAdditive();
        }
    }

    private void LoadSceneAdditive()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            // Cargar la escena en modo aditivo
            SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive).completed += (operation) =>
            {
                Debug.Log($"Escena {sceneName} cargada.");
                ConfigureProjection();
                isSceneLoaded = true;
            };
        }
        else
        {
            Debug.LogError("El nombre de la escena no est� configurado.");
        }
    }

    private void ConfigureProjection()
    {
        // Busca la c�mara de la escena cargada
        Scene loadedScene = SceneManager.GetSceneByName(sceneName);
        if (loadedScene.IsValid())
        {
            foreach (GameObject obj in loadedScene.GetRootGameObjects())
            {
                Camera sceneCamera = obj.GetComponentInChildren<Camera>();
                if (sceneCamera != null)
                {
                    // Configura la c�mara para renderizar sobre el plano
                    RenderTexture renderTexture = new RenderTexture(1024, 1024, 16);
                    sceneCamera.targetTexture = renderTexture;

                    // Aplica la textura al material del plano
                    if (projectionPlane != null)
                    {
                        Renderer renderer = projectionPlane.GetComponent<Renderer>();
                        renderer.material.mainTexture = renderTexture;
                    }

                    Debug.Log("Proyecci�n configurada.");
                    break;
                }
            }
        }
    }
}
