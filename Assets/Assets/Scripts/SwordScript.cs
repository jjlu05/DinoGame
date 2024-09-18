using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript: MonoBehaviour
{private Player bool_script;
     public GameObject ant;
    public Transform PlayerPosition;
    public Transform weaponPos;
    // Start is called before the first frame update
    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    
    { bool_script = ant.GetComponent<Player>();
         
         PlayerPosition = GetComponent<Transform>();
        weaponPos.position = PlayerPosition.position;
        
       
    }
    

    // Update is called once per frame
    void Update()
    {
         
        
    }
     void OnTriggerEnter(Collider collider2)
    {
        if(collider2.gameObject.CompareTag("Obstacle"))
        {
           
           
            Destroy(collider2.gameObject);
             
            }
       
    }
}
