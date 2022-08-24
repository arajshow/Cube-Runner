using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collection : MonoBehaviour
{
    public playerScript playerScript;
    public scoureCount score;
    public gameControllerScript gameController;
    public AudioSource audioSource;
    public AudioSource audioSourcecollide;


    //this is also doing the same thing as below one but one thinng is different
    //as these are no trigger so they do collision which affect the momentum of player

    //private void OnCollisionEnter(Collision obstical)
    //{
    //    if(obstical.gameObject.tag == "collect")
    //    {
    //        Destroy(obstical.gameObject);
    //    }
    //}

    //this will allow player to destriy the collecter if player touches by if statement
    private void OnTriggerEnter(Collider other)
    {
        //trigger is something which looks like matter but
        //doesn't occupy space and anything can pass through it

        if (other.gameObject.tag == "collect")
        {
            audioSource.Play();
            Destroy(other.gameObject);
            score.Addscore(1);

        }
    }

    //here we are disabling the playerScript if player hit's any gameobjject which has tag of ...
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "obstacle")
        {
            audioSourcecollide.Play();
            gameController.gameover();
            playerScript.enabled = false;
        }
    }

    

}


