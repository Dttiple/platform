using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_control : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;
    public float speed = 2f;
    public float rotSpeed = 10;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {  
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dirvector = new Vector3(h,0,v);
        if (dirvector.magnitude > Mathf.Abs(0.005f))
        transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.LookRotation(dirvector),Time.deltaTime * 10);
        anim.SetFloat("speed", Vector3.ClampMagnitude(dirvector, 1).magnitude);
        rb.velocity = Vector3.ClampMagnitude(dirvector,1) * speed;
    }
}
