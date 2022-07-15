using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    bool begin = false;
    float VertRotateSpeed = 10f;
    
    public void CamControlsOn()
    {
        begin = true;
    }

    public void CamControlsOff()
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
            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.C))
            {
                transform.Rotate(Vector3.left, VertRotateSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.C))
            {
                transform.Rotate(Vector3.right, VertRotateSpeed * Time.deltaTime);
            }

        }
    }
}
