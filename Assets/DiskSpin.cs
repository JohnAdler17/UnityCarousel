using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiskSpin : MonoBehaviour
{
    bool begin = false;
    int speed = 20;

    public void OnClick()
    {
        begin = true;
    }

    public void Stop()
    {
        begin = false;
    }
    
    public void SlowSpeed()
    {
        speed = 10;
    }

    public void MediumSpeed()
    {
        speed = 20;
    }

    public void FastSpeed()
    {
        speed = 40;
    }

    public void FlipDirections()
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
            transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
        }
    }
}
