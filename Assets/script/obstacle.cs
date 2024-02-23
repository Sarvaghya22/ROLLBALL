using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    gyro gy;
    // Start is called before the first frame update
    void Start()
    {
        gy = GameObject.FindAnyObjectByType<gyro>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            gy.die();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
