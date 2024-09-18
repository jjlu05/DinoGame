using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class LivesScript : MonoBehaviour
{
    public GameObject please;
private TestScript testScript;
 public GameObject ant;
 private Player bool_script;
 void Awake()
 {
    
 }
    void Start(){
        
         bool_script = ant.GetComponent<Player>();
         testScript = please.GetComponent<TestScript>();

    }
    // Start is called before the first frame update
    void Update()
    {
       
        
        transform.position += Vector3.left * GameManager.Instance.gameSpeed * Time.deltaTime;
       
        
    }
     private void OnTriggerEnter(Collider other){
    if (other.CompareTag("Obstacle")) {
            Destroy(gameObject);
           
        }
    
    }
}
