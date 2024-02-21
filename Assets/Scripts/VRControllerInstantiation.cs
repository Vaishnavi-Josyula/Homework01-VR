using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRControllerInstantiation : MonoBehaviour
{

    /*
    public GameObject leftControllerPrefab; 
    public GameObject rightControllerPrefab;
    void Start()
    {
        InputDevice leftController = GetInputDevice(XRNode.LeftHand);
        InputDevice rightController = GetInputDevice(XRNode.RightHand);
        if (leftController.isValid && rightController.isValid)
        {
            Instantiate(leftControllerPrefab, leftController.GetFeatureValue(CommonUsages.devicePosition), Quaternion.identity);
            Instantiate(rightControllerPrefab, rightController.GetFeatureValue(CommonUsages.devicePosition), Quaternion.identity);
        }
    }
    InputDevice GetInputDevice(XRNode node)
    {
        InputDevice inputDevice;
        InputDevices.GetDeviceAtXRNode(node, out inputDevice);
        return inputDevice;
    }
    */
}
