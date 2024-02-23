using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMenuOptions : MonoBehaviour
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
            TranslateCube();
        }



        if (Input.GetKeyDown(KeyCode.B))
        {
            //Debug.Log("B PRESSED");
            //ScaleCube();
            buttonBPressed = true;
        }
        else if (Input.GetKeyUp(KeyCode.B))
        {
            buttonBPressed = false;
        }
        if (buttonBPressed)
        {
            RotateCube();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            ClearAction();
        }*/

    }

    public void TranslateCube()
    {
        Debug.Log("TRANSLATIN");
        cubeTransform.Translate(translationDirection * 1f * Time.deltaTime);
        if (OVRInput.Get(OVRInput.Button.One))
        {
            Debug.Log("A PRESSED");
            cubeTransform.Translate(translationDirection * 1f * Time.deltaTime);
            
        }
        
    }
    /*
    public void RotateCube()
    {
        cubeTransform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    // change to only clear previously selected mode

    public void ClearAction()
    {
        transform.rotation = Quaternion.Euler(Vector3.zero);
        transform.position = new Vector3(-11.58f, 1.96f, 39.67f);
    }*/
}
