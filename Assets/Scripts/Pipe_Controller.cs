using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Controller : MonoBehaviour
{
    
    public float speed;
    public float lifeTime;
   
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
