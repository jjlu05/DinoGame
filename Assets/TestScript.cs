using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{  private Player bool_script;
     public GameObject ant;
     public GameObject theWeapons;
     public GameObject deathtoDino;
     private Weapons TheWeapons;
     public int pleaseWork;
    // Start is called before the first frame update
    void Start()
    {
        TheWeapons = theWeapons.GetComponent<Weapons>();
        bool_script = ant.GetComponent<Player>();
        bool_script.testNum =1;
        bool_script.retardedassvariable = 10;
        pleaseWork=10;
        deathtoDino.SetActive(true);
       
    }

    // Update is called once per frame
    void Update()
    {
         
        Debug.Log("bool_script.testNum="+ bool_script.testNum);
       Debug.Log("retard = " + bool_script.retardedassvariable);


    }
}
