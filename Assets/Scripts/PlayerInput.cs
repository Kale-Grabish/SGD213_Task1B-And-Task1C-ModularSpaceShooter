using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    private PlayerMovementScript playerMovementScript;
    private ShootingScript shootingScript;

    // Start is called before the first frame update
    void Start()
    {
        //Contacts both scripts for player movement and shooting for later use
        playerMovementScript = GetComponent<PlayerMovementScript>();
        shootingScript = GetComponent<ShootingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //Contacts PlayerMovementScript and allows the player to move
        float HorizontalInput = Input.GetAxis("Horizontal");

        if(HorizontalInput != 0.0f )
        {
          playerMovementScript.HorizontalMovement(HorizontalInput);  
        }

        //Contacts ShootingScript and allows the player to fire
        if (Input.GetButton("Fire1"))
        {
            if (shootingScript != null)
            {
              shootingScript.Shoot();
            }
            else
            {
              Debug.Log("Attach The Shooting Script");
            }
        }
    }   
}
