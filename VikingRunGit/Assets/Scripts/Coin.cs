using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float spinSpeed = 90f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {   
        if(other.gameObject.GetComponent<Obstacles>()!=null)
        {
            Destroy(gameObject);
            return;
        }
        if (other.gameObject.name != "Viking_Axes")
            return;

        GameManager.inst.addCoin();
        Destroy(gameObject);

    }
}
