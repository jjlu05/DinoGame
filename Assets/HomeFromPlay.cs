using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class HomeFromPlay : MonoBehaviour {
	public Button yourStartButton;
    public Canvas canvas;
    public int randomInt = 0;
    
	public void Start () {
		
		yourStartButton.onClick.AddListener(TaskOnClick);
       
	}

	public void TaskOnClick(){
		Debug.Log("works");
        
        randomInt = 1;
		 SceneManager.LoadScene("StartScene");

	}
}