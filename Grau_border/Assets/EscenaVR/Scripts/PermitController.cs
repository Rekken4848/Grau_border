using UnityEngine;

public class PermitController : MonoBehaviour
{
    public EntryPermitManager permitManager;

    void Start()
    {
        // Cambia los datos del permiso din�micamente
        permitManager.UpdatePermit(
            "ANDREI IVANOV",      // Nombre
            "A1234-B567",         // N�mero de pasaporte
            "WORK",               // Prop�sito
            "6 MONTHS",           // Duraci�n
            "1982.12.31"          // Fecha l�mite
        );
    }
}
