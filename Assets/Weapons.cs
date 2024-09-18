using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Weapons : MonoBehaviour
{
    
      private Player bool_script;
     public GameObject ant;
     public int weaponsVariable = 0;
    // Start is called before the first frame update
    void Start()
    {
          bool_script = ant.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider collider)
     {
          
        weaponsVariable=10;
        SceneManager.LoadScene("DinoGame 1");
     }
}
