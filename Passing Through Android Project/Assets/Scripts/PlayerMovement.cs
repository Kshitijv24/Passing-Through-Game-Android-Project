using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    public Joystick joystick;

    private void Update(){

        float xInput = joystick.Horizontal;
        float yInput = joystick.Vertical;

        transform.Translate(xInput * speed * Time.deltaTime, yInput * speed * Time.deltaTime, 0);
    }
}
