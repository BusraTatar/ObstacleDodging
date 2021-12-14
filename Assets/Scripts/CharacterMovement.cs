using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    float speed = 4;
    public GameObject end;
    public Slider healthBar;

    public GameObject rightControl;
    public GameObject leftControl;


    public Animator Anim;

    public GameObject winPanel;

    public int score=0;
    public Text score1;
    

    int lev = 1;
    public Text level;
    public Text level2;
    public Text level3;


    private void Start()
    {
        healthBar.value = 1f;
        
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
            healthBar.value -= 0.2f;
           

            if (healthBar.value <= 0.2f)
            {
               
                   end.SetActive(true);
                   Time.timeScale = 0;
         
            }
        }
        if(coll2.gameObject.tag == "Shield")
        {

            healthBar.value += 0.2f;
                
            score += 5;
            
            score1.text = score.ToString();
            if (score % 50 == 0)
            {
                lev++;
                winPanel.SetActive(true);
                Time.timeScale = 0;
                level.text = lev.ToString();
                level2.text = lev.ToString();
                level3.text = lev.ToString();

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
