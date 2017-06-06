using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;
using HoloToolkit.Unity.InputModule;
using System;

public class ModelPlacement : MonoBehaviour, IInputClickHandler
{
    public GameObject ShowcaseModel;
    private AudioSource ModelSound;

    public HoloToolkit.Unity.InputModule.Cursor ActiveCursor;
    public Canvas UICanvas;

    private TextToSpeechManager MyTTS;

    private bool IsPlacing = true;
    private bool IsStartup = true; // See hack comment below
    
    // Use this for initialization
    void Start()
    {
        ShowcaseModel.SetActive(false);
        InputManager.Instance.PushFallbackInputHandler(gameObject);

        ModelSound = ShowcaseModel.GetComponent<AudioSource>();

        MyTTS = GetComponent<TextToSpeechManager>();
    }

    private void Update()
    {
        // Yeah, this is a hack, but the TTS Manager did not seem to initialize fast
        // enough to make this SpeakText() call in Start() above
        if (IsStartup)
        {
            IsStartup = false;
            MyTTS.SpeakText("Welcome to the holographic model showcase. Look at the floor and pick a spot to place the model. Air Tap when ready.");
        }
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (IsPlacing)
        {
            IsPlacing = false;
            ShowcaseModel.transform.position = ActiveCursor.transform.position;
            ShowcaseModel.SetActive(true);
            ModelSound.Play();
            UICanvas.gameObject.SetActive(false);
        }
    }

    public void EnablePlacingMode()
    {
        ShowcaseModel.SetActive(false);
        UICanvas.gameObject.SetActive(true);
        IsPlacing = true;

        MyTTS.SpeakText("Ok. Placing mode is now enabled. Look at the floor and pick a spot to place the model. Air Tap when ready.");

    }
}