using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDrive : MonoBehaviour
{
    bool begin = false;
    float speed = 5f;
    float rotatespeed = -50f;

    public void StartCarDefault()
    {
        begin = true;
        speed = 5f;
        rotatespeed = -50f;
    }

    public void StopCar()
    {
        begin = false;
    }

    public void SlowSpeed()
    {
        speed = 3f;
        rotatespeed = -30f;
    }

    public void FastSpeed()
    {
        speed = 10f;
        rotatespeed = -100f;
    }

    public void ReverseDirection()
    {
        rotatespeed = rotatespeed * -1;
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
            Vector3 position = transform.position;
            transform.RotateAround(transform.position, transform.up, rotatespeed * Time.deltaTime);
            float newY = Mathf.Cos(Time.time * speed) + 1;
            //float newZ = Mathf.Sin(Time.time * speed);
            //float newX = -Mathf.Sin(Time.time * speed);
            transform.position = new Vector3(position.x, newY, position.z);
        }
    }
}
