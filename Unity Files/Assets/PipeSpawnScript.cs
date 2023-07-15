using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public LogicScript logic;
   
    public float spawnrate = 2;
    private float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawn();
            timer = 0;  
        }   
    }
    void spawn()
    {
        if (logic.playerScore >= 0 && logic.playerScore < 5)
        {
            instantiator(0);
        }
        else if (logic.playerScore >= 5 &&  logic.playerScore < 10)
        {         
            instantiator(10);
        }
        else if (logic.playerScore > 10 && logic.playerScore < 15)
        {
            instantiator(20);
        }
        else if (logic.playerScore > 15 && logic.playerScore < 20)
        {
            instantiator(30);
        }
        else
        {
            instantiator(35);
        }
    }

    void instantiator(int rotationRange)
    {
    
        System.Random random = new System.Random();
 
        Quaternion randomRotation = Quaternion.Euler(0, 0, Random.Range(-rotationRange,rotationRange));
        Instantiate(pipe, new Vector3(transform.position.x, transform.position.y + Random.Range(-9,9), transform.position.z), randomRotation);
    }
}
