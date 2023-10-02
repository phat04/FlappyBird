using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float flapStrength;
    public bool isAlive = true;
    public LogicScript logicScript;
    float upperLimit = 12;
    float lowerLimit = -12;

    // Start is called before the first frame update
    void Start()
    {
        logicScript=GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            myRigidbody2D.velocity = Vector2.up * flapStrength;
        }

        if (transform.position.y >= upperLimit || transform.position.y <= lowerLimit) 
        {
            logicScript.gameOver();
            isAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.gameOver();
        isAlive = false;
    }
}
