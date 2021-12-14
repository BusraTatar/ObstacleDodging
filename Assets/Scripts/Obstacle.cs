using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
   
    void OnCollisionEnter2D(Collision2D coll)
    {
        float xposition = Random.Range(-3.75f, 5f);
        float yposition = Random.Range(5.12f, 8f);

        if(coll.gameObject.tag == "GameController" || coll.gameObject.tag == "Player")
        {
            transform.position = new Vector2(xposition,yposition);
        }
    }

}