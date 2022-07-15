using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneFly : MonoBehaviour
{
    bool begin = false;
    float MoveSpeed = 10f;
    float RotateSpeed = 50f;
    float VerticalSpeed = 10f;

    public void SlowSpeed()
    {
        MoveSpeed = 5f;
        RotateSpeed = 30f;
        VerticalSpeed = 5f;
    }
    
    public void MediumSpeed()
    {
        MoveSpeed = 10f;
        RotateSpeed = 50f;
        VerticalSpeed = 10f;
    }

    public void FastSpeed()
    {
        MoveSpeed = 20f;
        RotateSpeed = 100f;
        VerticalSpeed = 20f;
    }

    
    public void FlyDrone()
    {
        begin = true;
    }

    public void DroneOff()
    {
        begin = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (begin == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
                transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.DownArrow))
                transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(Vector3.up * -RotateSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.DownArrow) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
            {
                transform.Translate(-Vector3.up * VerticalSpeed * Time.deltaTime);
                transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.UpArrow) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
            {
                transform.Translate(Vector3.up * VerticalSpeed * Time.deltaTime);
                transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.C))
            {
                transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.C))
            {
                transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);
            }
        }
    }
}
