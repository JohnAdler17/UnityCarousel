using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerJump : MonoBehaviour
{
    bool begin = false;
    float speed = 0f;

    public void StartTigerDefault()
    {
        begin = true;
        speed = 5f;
    }

    public void StopTiger()
    {
        begin = false;
    }

    public void SlowSpeed()
    {
        speed = 3f;
    }

    public void FastSpeed()
    {
        speed = 10f;
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
            float newY = Mathf.Sin(Time.time * speed) + 1;
            transform.position = new Vector3(position.x, newY, position.z);
        }
    }
}
