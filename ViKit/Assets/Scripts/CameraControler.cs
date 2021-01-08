using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraControler : MonoBehaviour
{

    private void OnScrollWheel(InputValue inputValue)
    {
        Vector2 scrollVector = inputValue.Get<Vector2>();

        transform.Translate(0, 0, scrollVector.y * 0.01f, Space.Self);
    }

    void Update()
    {
        if (Mouse.current.rightButton.isPressed)
        {
            Vector2 delta = Mouse.current.delta.ReadValue();
            transform.RotateAround(Vector3.zero,Vector3.left, delta.y);
            transform.RotateAround(Vector3.zero, Vector3.up, delta.x);
        }




    }
}
