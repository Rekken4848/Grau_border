using UnityEngine;

public class FixCoordinates : MonoBehaviour
{
    // Variables para almacenar la posición fija
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
        // Actualizar constantemente la posición manteniendo X y Z fijas
        transform.position = new Vector3(fixedX, fixedY, fixedZ);
    }
}
