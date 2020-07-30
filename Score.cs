using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public Text text;
    void Add(int anmout)
    {
        score += anmout;
        UpdateDisplay();
    }
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void UpdateDisplay()
    {
        text.text = "Score " + score; 
    }
}
