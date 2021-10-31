using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
    int score;
    public Text score1;
    public Text score2;
    public Text score3;





    private void Update()
    {
        score1.text = score.ToString();
        score2.text = score.ToString(); //daha sonra bitti panel set active in yanýna alýnacak
        score3.text = score.ToString(); //daha sonra pause panele alýnacak
    }





    void OnCollisionEnter2D(Collision2D coll)
    {
        float xposition = Random.Range(-3.75f, 5f);
        float yposition = Random.Range(5.12f, 8f);

        if(coll.gameObject.tag == "GameController" || coll.gameObject.tag == "Player")
        {
            transform.position = new Vector2(xposition,yposition);
            score += 5;
        }
    }

}