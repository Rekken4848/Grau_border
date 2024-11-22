using UnityEngine;
using Vuforia;

public class VirtualButtonLogger : MonoBehaviour
{
    void Start()
    {
        // Aqu� puedes inicializar lo que necesites
    }

    // M�todo que se ejecuta cuando se presiona un bot�n
    public void OnButtonPressed(GameObject vb)
    {
        // Ejemplo de c�mo usar las funciones para mostrar/ocultar un objeto
        ToggleGameObjectVisibility(vb); // Alterna entre mostrar/ocultar
    }

    // Funci�n para mostrar un GameObject
    public void ShowGameObject(GameObject obj)
    {
            obj.SetActive(true);
            Debug.Log($"El objeto {obj.name} ahora est� visible.");
        
        
    }

    // Funci�n para ocultar un GameObject
    public void HideGameObject(GameObject obj)
    {
       
            obj.SetActive(false);
            Debug.Log($"El objeto {obj.name} ahora est� oculto.");
        
       
    }

    // Funci�n para alternar la visibilidad de un GameObject
    public void ToggleGameObjectVisibility(GameObject obj)
    {
       
            bool isActive = obj.activeSelf; // Verifica si est� activo
            obj.SetActive(!isActive); // Alterna el estado
            Debug.Log($"El objeto {obj.name} ahora est� {(isActive ? "oculto" : "visible")}.");
        
        
    }
}
