using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class AdvancedPlayer : MonoBehaviour
{
    private CharacterController character;
    private Vector3 direction;
    public int playerLives = 0;
    public float jumpForce = 8f;
    public float gravity = 9.81f * 2f;
    public float testNum = 0;
    private void Awake()
    {
        character = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        direction = Vector3.zero;
    }

    private void Update()
    {
        Debug.Log(playerLives);
        direction += Vector3.down * gravity * Time.deltaTime;

        if (character.isGrounded)
        {
            direction = Vector3.down;

            if (Input.GetButton("Jump")) {
                direction = Vector3.up * jumpForce;
            }
        }

        character.Move(direction * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(testNum);
        if (other.CompareTag("Obstacle")) {
            playerLives-=1;
           
        }
        if (other.CompareTag("lives")) {
            playerLives+=1;
           
        }
        if(testNum==0){
            if (other.CompareTag("Obstacle")) {
            FindObjectOfType<GameManager>().GameOver();
            }
        }
        if(testNum==1)
        {
       if(playerLives==0)
       {
            
            FindObjectOfType<GameManager>().GameOver();
            
       }
        }
        
        
    }

}
