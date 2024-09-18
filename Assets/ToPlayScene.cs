using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class ToPlayScene : MonoBehaviour {
	public Button yourStartButton;
    public TextMeshProUGUI startText;
 
    
     private Player bool_script;
     public GameObject ant;
     
	public void Start () {
		
		yourStartButton.onClick.AddListener(TaskOnClick);
       bool_script = ant.GetComponent<Player>();

       
	}

	public void TaskOnClick(){
        bool_script.testNum =0;
         
		 SceneManager.LoadScene("DinoGame");

	}
}