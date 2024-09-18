using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour
{
    public AudioSource audioPlayer;
      public AudioSource audioPlayerDeath;
        public AudioSource audioPlayerHeart;
    private CharacterController character;
    private Vector3 direction;
    public double  playerLives = 3;
    public float jumpForce = 8f;
    public float gravity = 9.81f * 2f;
    public  float testNum = 0;
    public float weaponsNum = 0;
    private float testWeaponsNumber=0;
    public float retardedassvariable=10;
    private Weapons weapons;
    public GameObject go;
    public GameObject sword;
    public GameObject fallingSword;
    public bool swordExistence=false;
    public bool gunExistence=true;
    public int pillValue=0;
    public GameManager gameManager;
    private void Awake()
    {
        
        character = GetComponent<CharacterController>();
       
    }
    private void Start()
    {
        
    }
    private void OnEnable()
    {
        direction = Vector3.zero;
    }

    private void Update()
        
    {   
        
        
        
        direction += Vector3.down * gravity * Time.deltaTime;
        
        if (character.isGrounded)
        {
            direction = Vector3.down;

            if (Input.GetButton("Jump")) {
                direction = Vector3.up * jumpForce;
            }
            
            
              if (Input.GetKey("d")) 
              {
                if(testNum==2)
                {
                direction = Vector3.right*3;
                }
            }
            if (Input.GetKey("a")) 
              {
                if(testNum==2)
                {
                direction = Vector3.left*3;
                }
            }
            if(Input.GetKeyDown("s"))
            {
            if(gunExistence==true)
            {
                go.SetActive(false);
            }
            swordExistence=true;
            sword.SetActive(true);
            fallingSword.SetActive(false);
            }
            if(Input.GetKeyDown("f"))
            {   
             if(swordExistence==true)
               {
                 fallingSword.SetActive(true);
                 sword.SetActive(false);
                 Invoke("MyFunction",1);
               }
               
            }
           
          

             if(Input.GetKeyDown("g"))
            {
            if(swordExistence==true)
            {
                
                sword.SetActive(false);
                fallingSword.SetActive(false);
            }
            go.SetActive(true);
            }
           
            weaponsNum=testWeaponsNumber;
        }
      

        character.Move(direction * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("JumpBoost"))
        {
            jumpForce+=1;
            Destroy(other.gameObject);
        }
        if(other.CompareTag("ScoreChange"))
        {
            int random = Random.Range(1,3);
            if(random==1){
            gameManager.score*=1.5f;
            }
            else
            {
                gameManager.score/=1.5f;
            }
            Destroy(other.gameObject);
        }
        if(other.CompareTag("JumpBoost"))
        {
            jumpForce+=1;
            Invoke("JumpForce",10);
            Destroy(other.gameObject);
        }
        if(other.CompareTag("pill"))
        {
            gameManager.gameSpeedIncrease+=2;
            Destroy(other.gameObject);
        }
        if(testNum!=1){
            if (other.CompareTag("Obstacle")) {
            FindObjectOfType<GameManager>().GameOver();
            }
        }
        if(testNum==1)
        {
       if(playerLives==0)
       {
            Debug.Log("WHY IS NOT PLAYGIN DEATHS OUND");
           
            FindObjectOfType<GameManager>().GameOver();

            
       }
        }
        if(other.CompareTag("Gun"))
        {
            
            weaponsNum=1;
       
            
        }
        if(other.CompareTag("Sword"))
        {
            weaponsNum=2;
           
        }
        if (other.CompareTag("Obstacle")) {
            playerLives-=1;
            audioPlayer.Play();
           
        }
        if (other.CompareTag("lives")) {
            Destroy(other.gameObject);
            playerLives+=1;
            Debug.Log("player lives" + playerLives);
            audioPlayerHeart.Play();
           
        }
        
        
        
        
    }
    void PillFunction()
    {
        pillValue=0;
    }
    void JumpBoost()
    {
        jumpForce-=1;
    }
    void MyFunction()
    {
        fallingSword.SetActive(false);
        sword.SetActive(true);
    }

}
