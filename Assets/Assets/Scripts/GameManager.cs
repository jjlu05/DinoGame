using TMPro;
using UnityEngine;
using UnityEngine.UI;

[DefaultExecutionOrder(-1)]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float initialGameSpeed = 5f;
    public float gameSpeedIncrease = 0.1f;
    public float gameSpeed { get; private set; }
    public GameObject test;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hiscoreText;
    public TextMeshProUGUI gameOverText;
    public Button retryButton;
    public Button dinoButton;
    public GameObject ant;
    private Player player;
    private Spawner spawner;
     private Player bool_script;
    public float score;
     public AudioSource testAudio;
     public AudioSource scoreAudio;
     public GameObject deathDino;
    
    private void Awake()
    {
        if (Instance != null) {
            DestroyImmediate(gameObject);
        } else {
            Instance = this;
        }
    }

    private void OnDestroy()
    {
        if (Instance == this) {
            Instance = null;
        }
    }

    public void Start()
    {
        Debug.Log("this shit works");
        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<Spawner>();
         bool_script = ant.GetComponent<Player>();
        
        NewGame();
    }

    public void NewGame()
    {
        deathDino.SetActive(false);
        UpdateHiscore();
        Obstacle[] obstacles = FindObjectsOfType<Obstacle>();

        foreach (var obstacle in obstacles) {
            Destroy(obstacle.gameObject);
        }


        score = 0f;
        gameSpeed = initialGameSpeed;
        enabled = true;

        player.gameObject.SetActive(true);
        spawner.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(false);
        retryButton.gameObject.SetActive(false);
       dinoButton.gameObject.SetActive(false);
   
    
    
       
    
      
    }

    public void GameOver()
    {stupidassfunction();
    UpdateHiscore();
        deathDino.SetActive(true);
        Debug.Log("Game Over");
        if(bool_script.testNum ==1)
        {
        testAudio.Play();
        bool_script.playerLives +=3;
        }
        gameSpeed = 0f;
        enabled = false;

        player.gameObject.SetActive(false);
        spawner.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(true);
        retryButton.gameObject.SetActive(true);
        dinoButton.gameObject.SetActive(true);
        
        
    }

    private void Update()
    {
        gameSpeed += gameSpeedIncrease * Time.deltaTime;
        score += gameSpeed * Time.deltaTime;
        
        Debug.Log((int)score);
        if((int)score%100==0) 
        {
            Debug.Log("SCORE SHOULD BE CORRECT");
            scoreAudio.Play();
        }
        scoreText.text = Mathf.FloorToInt(score).ToString("D5");
    }
    private void stupidassfunction()
    {
        Debug.Log("studafdjiofas");
    }
    private void UpdateHiscore()
    {
        float hiscore = PlayerPrefs.GetFloat("hiscore", 0);
        Debug.Log("updatehiscore");

        if (score > hiscore)
        {
            Debug.Log("testingtesting");
            hiscore = score;
            PlayerPrefs.SetFloat("hiscore", hiscore);
        }

        hiscoreText.text = Mathf.FloorToInt(hiscore).ToString("D5");
    }

}
