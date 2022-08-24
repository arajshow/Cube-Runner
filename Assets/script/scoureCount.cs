using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class scoureCount : MonoBehaviour
{
    public Text myscore;
    public Text scoreInText;

    int mycount = 0;
    // Update is called once per frame
    void Update()
    {
        myscore.text = mycount.ToString();
        scoreInText.text = "score: " + mycount.ToString();
    }

    public void Addscore(int score)
    {
        mycount= mycount + score;
    }
}
