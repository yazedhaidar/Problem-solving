﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiS7 : MonoBehaviour
{
    [Header("UI")]
    public Text score;


    [Header("Score")]
    public Score7 scoreController;

    // Update is called once per frame
    void Update()
    {
        score.text = scoreController.GetCurrentScore().ToString();

    }
}
