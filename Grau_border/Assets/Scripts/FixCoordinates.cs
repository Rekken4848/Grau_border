using UnityEngine;

public class FixCoordinates : MonoBehaviour
{
    // Variables para almacenar la posici�n fija
    public float fixedX;
    public float fixedY;
    public float fixedZ;

    void Start()
    {
        // Capturar las coordenadas iniciales al iniciar
        fixedX = transform.position.x;
        fixedZ = transform.position.y;
        fixedZ = transform.position.z;
    }

    void Update()
    {
        // Actualizar constantemente la posici�n manteniendo X y Z fijas
        transform.position = new Vector3(fixedX, fixedY, fixedZ);
    }
}
