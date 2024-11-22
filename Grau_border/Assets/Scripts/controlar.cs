using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class controlar : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 10f; // Velocidad de rotación para suavizar el giro
    public Animator animator;

    void Update()
    {
        var gamepad = Gamepad.current;
        if (gamepad == null)
            return; // No hay gamepad conectado.

        // Leer el valor del joystick izquierdo
        Vector2 moveInput = gamepad.leftStick.ReadValue();
        
        // Convertir la entrada del joystick en un vector de movimiento en 3D
        Vector3 moveDirection = new Vector3(moveInput.x, 0, moveInput.y);

        // Calcular la magnitud del movimiento para determinar si está caminando o en idle
        float speed = moveDirection.magnitude;

        // Actualizar el parámetro "Speed" en el Animator
        animator.SetFloat("Speed", speed);

        // Si hay movimiento, rotar el personaje para que mire en esa dirección
        if (moveDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Mover al personaje hacia adelante, en la dirección que está mirando
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);
        }
    }
}
