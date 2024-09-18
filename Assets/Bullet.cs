using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed=10;
    private Rigidbody rb;
    public bool hitOrNot=false;
    // Start is called before the first frame update
    void Start()

    {
        Destroy(gameObject,4);
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.right*speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.CompareTag("Obstacle"))
        {
            hitOrNot=true;
           
            Destroy(collider.gameObject);
             Destroy(gameObject);
            }
       
    }
}
