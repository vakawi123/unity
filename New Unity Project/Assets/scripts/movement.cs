using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
       public float speed;
    bool ontheground;
    SpriteRenderer spr;
    Animator anim;
    Rigidbody2D rb;

    public GameObject gameoverimage;

    public GameObject youwinimage;


    // Start is called before the first frame update
    void Start()
    {
        spr=GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        
        transform.Translate(move * speed * Time.deltaTime, 0 , 0);
        

        if(move > 0)

        {
            anim.SetBool("run", true);
            spr.flipX = false;
        }   else if (move < 0)


        {
            anim.SetBool("run",true);
            spr.flipX= true;
        }   else
        {
            anim.SetBool("run",true);
            anim.SetBool("run",false);
        }


            if(ontheground == true)
            {
            if(Input.GetKeyDown(KeyCode.Space))
            {

            rb.velocity = new Vector2(rb.velocity.x, 10f);
            ontheground = false;
            }
            }

            if(textScript.life ==0)
            {
                gameoverimage.SetActive(true);
            }
            
            if(textScript.score == 5)
            {
                youwinimage.SetActive(true);
            }


    }

            private void onCollisionEnter2D(Collision2D collision)
            {
                if(collision.gameObject.name == "ground")
            {
                ontheground = true;
            }
            }
}
