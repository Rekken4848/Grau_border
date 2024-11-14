using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class gamepad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public float moveSpeed = 5f;
    public float rotationSpeed = 200f;

    void Update()
    {
        var gamepad = Gamepad.current;
        if (gamepad == null)
            return; // No hay gamepad conectado.

        // Leer el valor del joystick izquierdo
        Vector2 moveInput = gamepad.leftStick.ReadValue();
        // Mover el objeto hacia adelante y hacia atrás
        Vector3 moveDirection = new Vector3(0, 0, moveInput.y);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // Leer el valor del joystick derecho
        Vector2 rotateInput = gamepad.rightStick.ReadValue();
        // Rotar el objeto hacia la izquierda y la derecha
        float rotationAmount = rotateInput.x * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotationAmount, 0);
    }
}

