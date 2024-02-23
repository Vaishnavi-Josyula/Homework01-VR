using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCubeMenu : MonoBehaviour
{
    public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitMenu()
    {
        menu.SetActive(false);
        if (OVRInput.Get(OVRInput.Button.One))
        {
            Debug.Log("A PRESSED");

            //TranslateCube();
            menu.SetActive(false);
        }
    }
}
