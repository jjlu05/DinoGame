using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class ToUnfinishedFeatures : MonoBehaviour {
	public Button yourStartButton;
    public TextMeshProUGUI startText;
    public int randomInt = 0;
    public Button yourStartButton2;
	public Canvas canvas;
	public void Start () {
		
		yourStartButton.onClick.AddListener(TaskOnClick);
       
	}

	public void TaskOnClick(){
    
		 SceneManager.LoadScene("UnfinishedFeatures");

	}
}