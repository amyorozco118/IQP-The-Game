using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public static int score = 0;        // The player's score.
    public Text text;                     // Reference to the Text component. "Text" red

    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();
        // Reset the score.
        score = 0;
    }

    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Score: " + score;

    }

    static public void AddPoint()
    {
        score = score + 1;

        
    }

    static public void SubtractPoint()
    {
        score = score - 1;

        
    }


}
