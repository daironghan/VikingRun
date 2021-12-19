using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    
    GroundSpawner groundSpawner;
    
    // Start is called before the first frame update
    void Start()
    {
        int hasObstacle = Random.Range(0, 8);
        if(hasObstacle == 7)
            SpawnObstacle();
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnCoin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("exited");
        int path = Random.Range(1, 3);
        //Debug.Log("path" + path);
        if(path == 1)
        {
            groundSpawner.SpawnTile();
        }
        else if(path==2)
        {
            groundSpawner.SpawnTileRight();
        }
        Destroy(gameObject, 2);
    }
    public GameObject obstaclePrefab;
    
    void SpawnObstacle()
    {
        Transform spawnPoint = transform.GetChild(2).transform;
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
    public GameObject coinPrefab;
    void SpawnCoin()
    {
        GameObject temp = Instantiate(coinPrefab, transform);
        temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
    }
    Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );
        if(point!=collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }
        //coin height
        point.y = 1;
        return point;
    }

}
