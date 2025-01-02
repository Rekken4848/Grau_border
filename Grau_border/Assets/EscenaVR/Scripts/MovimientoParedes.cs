using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class MovimientoParedes : MonoBehaviour
{
    public InputActionProperty leftMoveAction;  // Acción de movimiento para el controlador izquierdo
    public InputActionProperty rightMoveAction; // Acción de movimiento para el controlador derecho
    public float moveSpeed = 1f; // Velocidad del movimiento

    private Rigidbody rb;
    private Vector2 inputAxis;

    void Start()
    {
        // Asegúrate de que el Rigidbody esté en el XR Rig
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Leer el input de los joysticks configurados en el Input Action
        if (leftMoveAction.action != null)
        {
            inputAxis = leftMoveAction.action.ReadValue<Vector2>(); // Leer el valor del joystick izquierdo
        }
        else if (rightMoveAction.action != null)
        {
            inputAxis = rightMoveAction.action.ReadValue<Vector2>(); // Leer el valor del joystick derecho
        }
        else
        {
            inputAxis = Vector2.zero; // Sin input, no hay movimiento
        }
    }

    void FixedUpdate()
    {
        // Calcula la dirección del movimiento en función del input
        Vector3 direction = new Vector3(inputAxis.x, 0, inputAxis.y);
        direction = transform.TransformDirection(direction); // Ajusta según la orientación del jugador

        // Mueve el Rigidbody respetando colisiones
        Vector3 targetPosition = rb.position + direction * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(targetPosition);
    }
}
