using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletAUdio : MonoBehaviour
{
    public AudioSource bulletAudio;
    public Bullet bullet;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(bullet.hitOrNot);
        if(bullet.hitOrNot==true)
        {
            bulletAudio.Play();
            bullet.hitOrNot=false;
        }
    }
}
