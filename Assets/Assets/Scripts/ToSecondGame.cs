using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class ToSecondGame : MonoBehaviour {
	public Button yourStartButton;
    public TextMeshProUGUI startText;
    public int randomInt = 0;
    public Canvas canvas;
     private Player bool_script;
     public GameObject ant;
     
	public void Start () {
		canvas.gameObject.SetActive(true);
		yourStartButton.onClick.AddListener(TaskOnClick);
       bool_script = ant.GetComponent<Player>();

       
	}

	public void TaskOnClick(){
        bool_script.testNum =2;
         
		 SceneManager.LoadScene("DinoGame 1");

	}
}