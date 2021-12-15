using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class VikingController : MonoBehaviour
{
    public int movingSpeed;
    private bool onGround;
    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += movingSpeed * Time.deltaTime * Vector3.right;
        }
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
