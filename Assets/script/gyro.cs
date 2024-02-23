using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class gyro : MonoBehaviour
{
    public bool alive = true;
    public Rigidbody rb;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // Check if the gyroscope is available on the device
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true; // Enable the gyroscope
        }
        else
        {
            Debug.LogError("Gyroscope not supported on this device.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (alive != false)
        {
            float xMove = -Input.gyro.attitude.y;
            float zMove = Input.gyro.attitude.x;

            Vector3 movement = new Vector3(xMove, 0.0f, zMove);
            rb.AddForce(movement * speed * Time.fixedDeltaTime);

            if (transform.position.y < -5)
            {
                die();
            }
        }

    }

    
    public void die()
    {
        alive = false;
    }
}