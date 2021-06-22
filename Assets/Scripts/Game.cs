using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    // This is the score!!!
    public int score = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI messageText;

    public string[] messages = { "You Win!", " Me Gusta" };

    private void Start()
    {
        scoreText.text = "0";
        messageText.text = "";
    }

    // This is the method that executes when I press the button
    public void btn_Click()
    {
        messageText.text = "";
        score = score + 1;

        scoreText.text = "" + score;

        if(score >= 5)
        {
            // Show the winning message!!!
            Debug.Log("WIN");

            messageText.text = messages[ Random.Range(0, messages.Length)  ];


            score = 0;
        }

    }
}
