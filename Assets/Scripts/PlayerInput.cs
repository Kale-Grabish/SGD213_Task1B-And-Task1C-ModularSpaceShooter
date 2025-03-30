using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    private PlayerMovementScript playerMovementScript;
    // Start is called before the first frame update
    void Start()
    {
        playerMovementScript = GetComponent<PlayerMovementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

            if(HorizontalInput != 0.0f )
            {
                playerMovementScript.HorizontalMovement(HorizontalInput);  
            }
    }   
}
