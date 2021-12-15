using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collision))]
[RequireComponent(typeof(Animator))]
public class VikingController : MonoBehaviour
{
    public float movingSpeed;
    public float jumpingForce;
    private bool onGround;
    private bool run;
    Rigidbody rb;
    Animator an;
    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        an = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        run = false;
        if(Input.GetKey(KeyCode.W))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.forward;
            run = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.back;
            run = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.left;
            run = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.right;
            run = true;
        }
        if(onGround && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(jumpingForce * Vector3.up);
        }
        an.SetBool("Run", run);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "floor_01_variability_15")
        {
            onGround = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.transform.name == "floor_01_variability_15")
        {
            onGround = false;
        }
    }
}
