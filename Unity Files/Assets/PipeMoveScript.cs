using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 50;
    public float deadZone = -35;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3(-moveSpeed,0,0) * Time.deltaTime;
        
        if(transform.position.x < deadZone)
        {
            
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
