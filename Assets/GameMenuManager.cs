using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class GameMenuManager : MonoBehaviour
{
    public GameObject menu;
   // public Transform controllerTransform;
    //private bool isHovering = false;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
        // GetComponent<XRBaseInteractable>().hoverEntered.AddListener();
        //GetComponent<XRBaseInteractable>().hoverExited.AddListener(OnHoverExited);

    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Button.Two))
        {
            ShowMenu();
        }
        
       /* if (OVRInput.Get(OVRInput.Button.Two))
        {
            Debug.Log("BUTTON TWO IE B PRESSED");
            menu.SetActive(true);
        }*/
        /*if(OVRInput.Get(OVRInput.Button.Two))
        {
            Debug.Log("BUTTON TWO IE B PRESSED");
            RaycastHit hit;
            if(Physics.Raycast(controllerTransform.position, controllerTransform.forward, out hit))
            {
                if(hit.collider.CompareTag("Cube"))
                {
                    Debug.Log("HIT CUBE");
                    menu.SetActive(true);
                }
                
            }
            
        }*/
    }

    public void ShowMenu()
    {
            Debug.Log("BUTTON TWO IE B PRESSED");
            menu.SetActive(true);
        
    }
}
