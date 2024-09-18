using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript: MonoBehaviour
{private Player bool_script;
     public GameObject ant;
    public Transform PlayerPosition;
    public Transform weaponPos;
     public GameObject bulletPrefab;
     public Transform bulletSpawnPoint;
     public float bulletSpeed = 2;
     public GameObject firePic;
    // Start is called before the first frame update
    void Start()
    
    { bool_script = ant.GetComponent<Player>();
         
        PlayerPosition = GetComponent<Transform>();
        weaponPos.position = PlayerPosition.position;
        
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("s"))
        {
            gameObject.SetActive(false);
            firePic.SetActive(false);
        }
       
        if(Input.GetKeyDown("c"))
            {Invoke("GunFunction",1);
               
            }
       
    }
     private void OnTriggerEnter(Collider other)
    {
       
    }
    void GunFunction()
    {firePic.SetActive(true);
        var bullet = Instantiate(bulletPrefab, weaponPos.position, Quaternion.identity);
              bulletPrefab.GetComponent<Rigidbody>().velocity= bulletSpawnPoint.forward*bulletSpeed;
              Invoke("FirePicTimer",1);
      
    }
    void FirePicTimer()
    {
        firePic.SetActive(false);
    }
}
