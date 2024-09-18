using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class dinoButton : MonoBehaviour {
	public Button yourStartButton;
    
   
    public static int testInt = 0;
     private Player bool_script;
     public GameObject ant;
     
	public void Start () {
	
		yourStartButton.onClick.AddListener(TaskOnClick);
       bool_script = ant.GetComponent<Player>();

       
	}

	public void TaskOnClick(){
        testInt = 1;
        bool_script.testNum =1;
          
		

	}
}