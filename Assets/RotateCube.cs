using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private Renderer cubeRenderer;
    public GameObject cube;
    private Transform cubeTransform;
    private Vector3 translationDirection = Vector3.back;
    private bool buttonAPressed = false;
    private bool buttonBPressed = false;
    private float rotationSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        cubeTransform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        /*if (OVRInput.Get(OVRInput.Button.One))
        {
            Debug.Log("A PRESSED");
            buttonAPressed = true;
            //TranslateCube();
        }
        else if (!(OVRInput.Get(OVRInput.Button.One)))
        {
            buttonAPressed = false;
        }
        if (buttonAPressed)
        {
           Rotatecube();
        }*/

    }



    public void Rotatecube()
    {
        Debug.Log("ROTATIN");
        cubeTransform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        if (OVRInput.Get(OVRInput.Button.One))
        {
            Debug.Log("A PRESSED");
            buttonAPressed = true;
            //TranslateCube();
            cubeTransform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        
    }

}
