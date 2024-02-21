using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInput : MonoBehaviour
{

    public GameObject radio;
    public RadioMenuController radioMenuController;
    // Start is called before the first frame update
    void Start()
    {
        //InputSystem.EnableDevice(Oculus.XR.Input.OculusDevices.Gamepad);
        radioMenuController = radio.GetComponent<RadioMenuController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Button.One))
        {
            Debug.Log("A PRESSED, IN FIRST OF STTAMEMT");
            radioMenuController.TogglePower();

        }

        if (OVRInput.Get(OVRInput.Button.Two))
        {
            Debug.Log("B PRESSED, IN FIRST OF STTAMEMT");
            radioMenuController.ChangeSong();

        }
        //if(Gamepad.current.aButton.wasPressedThisFrame)

        //    Debug.Log("A PRESSED");

    }
}
