using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool jumpKeyWasPressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update() {
         // check if space key is pressed down

        if(Input.GetKeyDown(KeyCode.Space)){
           jumpKeyWasPressed = true;
        }
    }


    // Fixedupdate is called once every physic update 
    private void Fixedupdate()
    {
         if(jumpKeyWasPressed){
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
    }

}