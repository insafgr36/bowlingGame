﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuVectoire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Rejouer()
    {
        Application.LoadLevel("Game");
    }
    public void Quitter()
    {
        Application.Quit();
    }
}
