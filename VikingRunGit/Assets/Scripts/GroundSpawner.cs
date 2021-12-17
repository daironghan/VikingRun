using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    public GameObject groundTileRight;
    public GameObject groundTileLeft;
    Vector3 nextSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 8; i++)
            SpawnTile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        //nextSpawnPoint = temp.transform.GetChild(1).transform.position;
        
        int hasHole = Random.Range(0, 8);
        if (hasHole == 7)
        {
            Debug.Log("Hole");
            nextSpawnPoint = temp.transform.GetChild(3).transform.position;
            GameObject temp2 = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
            nextSpawnPoint = temp2.transform.GetChild(1).transform.position;
        }
        else
            nextSpawnPoint = temp.transform.GetChild(1).transform.position;

    }
    public void SpawnTileRight()
    {
        GameObject temp = Instantiate(groundTileRight, nextSpawnPoint, Quaternion.identity);
        int hasHole = Random.Range(0, 8);
        if (hasHole == 7)
        {
            Debug.Log("Hole");
            nextSpawnPoint = temp.transform.GetChild(3).transform.position;
            GameObject temp2 = Instantiate(groundTileRight, nextSpawnPoint, Quaternion.identity);
            nextSpawnPoint = temp2.transform.GetChild(1).transform.position;
        }
        else
            nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
}
