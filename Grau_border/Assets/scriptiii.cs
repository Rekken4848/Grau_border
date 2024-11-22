using UnityEngine;
using Vuforia;

public class VirtualButtonLogger : MonoBehaviour
{
    void Start()
    {
        // Aquí puedes inicializar lo que necesites
    }

    // Método que se ejecuta cuando se presiona un botón
    public void OnButtonPressed(GameObject vb)
    {
        // Ejemplo de cómo usar las funciones para mostrar/ocultar un objeto
        ToggleGameObjectVisibility(vb); // Alterna entre mostrar/ocultar
    }

    // Función para mostrar un GameObject
    public void ShowGameObject(GameObject obj)
    {
            obj.SetActive(true);
            Debug.Log($"El objeto {obj.name} ahora está visible.");
        
        
    }

    // Función para ocultar un GameObject
    public void HideGameObject(GameObject obj)
    {
       
            obj.SetActive(false);
            Debug.Log($"El objeto {obj.name} ahora está oculto.");
        
       
    }

    // Función para alternar la visibilidad de un GameObject
    public void ToggleGameObjectVisibility(GameObject obj)
    {
       
            bool isActive = obj.activeSelf; // Verifica si está activo
            obj.SetActive(!isActive); // Alterna el estado
            Debug.Log($"El objeto {obj.name} ahora está {(isActive ? "oculto" : "visible")}.");
        
        
    }
}
