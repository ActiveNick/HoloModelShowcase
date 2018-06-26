using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.Receivers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolbarReceiver : InteractionReceiver {

    public ShowcaseController controller;
    public ModelPlacement placer;
    public AudioSource sound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    protected override void InputDown(GameObject obj, InputEventData eventData)
    {
        Debug.Log(obj.name + " : InputDown");

        switch (obj.name)
        {
            case "ButtonDescribe":
                controller.DescribeModel();
                break;

            case "ButtonPlayAudio":
                sound.Play();
                break;

            case "ButtonMove":
                placer.EnablePlacingMode();
                break;

            default:
                break;
        }
    }
}
