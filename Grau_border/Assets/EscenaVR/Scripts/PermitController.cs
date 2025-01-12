using UnityEngine;

public class PermitController : MonoBehaviour
{
    public EntryPermitManager permitManager;

    void Start()
    {
        // Cambia los datos del permiso dinámicamente
        permitManager.UpdatePermit(
            "ANDREI IVANOV",      // Nombre
            "A1234-B567",         // Número de pasaporte
            "WORK",               // Propósito
            "6 MONTHS",           // Duración
            "1982.12.31"          // Fecha límite
        );
    }
}
