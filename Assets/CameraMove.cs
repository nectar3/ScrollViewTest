using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public float move_speed = 10f;

    public float minFov = 10f;

    public float maxFov = 90f;

    public float zoomSensitivity = 10f;

    public float rot_speed = 10f;

    public MoveCameraTo _moveToscript;

    void Start()
    {
        _moveToscript = this.GetComponent<MoveCameraTo>();
    }

    int c = 0;
    void Update()
    {
        if (Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.W) ||
            Input.GetKey(KeyCode.E) ||
            Input.GetKey(KeyCode.Q) ||
            Input.GetMouseButton(1)
            )
        {
            _moveToscript.StopMoving();
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(move_speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-move_speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -move_speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, move_speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(new Vector3(0, move_speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(new Vector3(0, -move_speed * Time.deltaTime, 0));
        }

        // Zoom ----
        var fov = Camera.main.fieldOfView;
        fov += -Input.GetAxis("Mouse ScrollWheel") * zoomSensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;
        // ----- 

        // rotation ----
        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(transform.position + transform.forward, Vector3.up, Input.GetAxis("Mouse X") * rot_speed);
        }
        // -----

    }
}
