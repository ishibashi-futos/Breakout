﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextDataFetcher : MonoBehaviour
{

    public Text resultMessageText;

    // Use this for initialization
    void Start ()
    {
        resultMessageText.text = DataSender.resultMessage;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }
    }
}