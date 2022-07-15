using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacupSpin : MonoBehaviour
{
    bool begin = false;
    int speed = 0;

    public void StartTeacupDefault()
    {
        begin = true;
        speed = 50;
    }

    public void StopTeacup()
    {
        begin = false;
    }

    public void SlowSpeed()
    {
        speed = 30;
    }

    public void FastSpeed()
    {
        speed = 100;
    }

    public void ReverseSpin()
    {
        speed = speed * -1;
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
            transform.RotateAround(transform.position, transform.up, speed * Time.deltaTime);
        }
    }
}
