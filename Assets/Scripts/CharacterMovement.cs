using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharacterMovement : Obstacle
{
    [SerializeField]
    float speed = 5;
    public GameObject end;
    public Image healthBar;

    public GameObject rightControl;
    public GameObject leftControl;


    public Animator Anim;


    float speed2;

    private void Start()
    {
        healthBar.fillAmount = 1f;
        
    }

    void Update()
    {
       Movement();  
    }
    void Movement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            Anim.SetTrigger("ForRun");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            Anim.SetTrigger("ForRun");
        }
    }
    private void OnCollisionEnter2D(Collision2D coll2)
    {
        
        if(coll2.gameObject.tag == "Weapon")
        {
            healthBar.fillAmount -= 0.2f;
           

            if (healthBar.fillAmount <= 0.2f)
            {
               
                   end.SetActive(true);
                   Time.timeScale = 0;
         
            }
        }
        if(coll2.gameObject.tag == "Shield")
        {

            healthBar.fillAmount += 0.2f;
            if (healthBar.fillAmount >= 1)
            {
                //efekt �al��t�r
                // +10 score
                score += 10;
            }
           
        }

        if(coll2.gameObject == leftControl)
        {
            transform.position = new Vector3(6.5f, -2.85f, 0f);
            
        } 
        
        if(coll2.gameObject == rightControl)
        {
            transform.position = new Vector3(-5.3f, -2.85f, 0f);
            
        }  
        
    }
}
