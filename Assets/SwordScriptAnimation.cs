using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScriptAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        
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
