using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour
{
    public float RotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float rotateX;
        float rotateAngle;

        rotateX = Input.GetAxis("ControllerLeftStickX");
        rotateAngle = rotateX * RotationSpeed * Time.deltaTime;

        transform.Rotate(0, rotateAngle, 0);
    }
}
