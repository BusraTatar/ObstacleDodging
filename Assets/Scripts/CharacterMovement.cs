using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharacterMovement : MonoBehaviour
{
    float speed = 5;
    public GameObject end;
    public Image healthBar;

    
    public float vector1;
    

    private void Start()
    {
        healthBar.fillAmount = 1f;

      
    }

    void Update()
    {   
        float speed2 = speed * Input.GetAxis("Horizontal");
        transform.Translate(speed2 * Time.deltaTime, 0, 0);
       
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
                //efekt çalýþtýr
                // +5 score
            }
            // win
        }

           
        
    }
}
