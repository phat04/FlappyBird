using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipePrefab;
    private float spawnTimer = 0;
    public float spawnRate=2;  
    public float heighOffset=10;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer <= spawnRate)
        {
            spawnTimer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            spawnTimer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heighOffset;
        float highestPoint = transform.position.y + heighOffset;
        Instantiate(pipePrefab,new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0),transform.rotation);
    }
}
