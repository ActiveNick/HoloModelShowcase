﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;
using HoloToolkit.Unity.InputModule;
using System;

public class ShowcaseController : MonoBehaviour, IInputClickHandler {

    private TextToSpeech MyTTS;

    // Use this for initialization
    void Start () {
        MyTTS = GetComponent<TextToSpeech>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void DescribeModel()
    {
        MyTTS.StartSpeaking("This is just a simple road bike. There's nothing special about it and it's all that we cound find for free in the Unity Asset Store.");
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        //throw new NotImplementedException();
    }
}
