using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePipe();
        destroyPipe();
    }

    void movePipe()
    {
        transform.position += Vector3.left * moveSpeed*Time.deltaTime;
    }
    void destroyPipe()
    {
        if (transform.position.x < -30)
        {
            Destroy(gameObject);
            Debug.Log("Pipe deleted");
        }
    }
}
