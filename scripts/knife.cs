using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife : MonoBehaviour
{
    public float speed = 3f;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().transform.right * speed;
    }
    void Update()
    {
        
    }
}
