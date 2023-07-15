using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    public float flapStrength=10;
    public float flapSpeed=5;
    public bool birdIsDead;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (birdIsDead == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                myRigidbody.velocity = Vector2.up * flapStrength;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                myRigidbody.velocity = Vector2.right * flapSpeed;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                myRigidbody.velocity = Vector2.left * flapSpeed;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        logic.gameOver();
        birdIsDead = true;
    }
}
