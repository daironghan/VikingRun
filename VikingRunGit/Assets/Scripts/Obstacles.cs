using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    VikingController vc;
    // Start is called before the first frame update
    void Start()
    {
        vc = GameObject.FindObjectOfType<VikingController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //kill player
        if (collision.gameObject.name == "Viking_Axes")
        {
           vc.Die();
        }
    }
}
