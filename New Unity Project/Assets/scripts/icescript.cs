using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icescript : MonoBehaviour
{
    public GameObject icebreak;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "ground")

        {
            textScript.score += 1;
            Instantiate(icebreak, transform.position, transform.rotation);
            Destroy (gameObject);
        }     

        if(collision.gameObject.name == "boy")
        {
            textScript.life -=1;
            Destroy(gameObject);
        } 

    

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
