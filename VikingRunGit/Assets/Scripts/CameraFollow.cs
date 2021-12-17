using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{   

    public Transform target;
    Vector3 offset;

    public float cameraDistance;
    // Start is called before the first frame update
    void Start()
    {
        
        //offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = target.position + offset;
        //transform.rotation = Quaternion.Euler(30, 0, 0);
        transform.position = target.transform.position - target.transform.forward * cameraDistance;
        transform.LookAt(target.transform.position);
        transform.position = new Vector3(transform.position.x, transform.position.y + 5, transform.position.z);
    }
}
