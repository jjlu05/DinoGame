using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTestNum : MonoBehaviour
{  private Player bool_script;
     public GameObject ant;
    // Start is called before the first frame update
    void Start()
    {
        bool_script = ant.GetComponent<Player>();
        bool_script.testNum =2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider other)
    {
        
    }
}
