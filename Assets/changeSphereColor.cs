using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSphereColor : MonoBehaviour
{
    private Renderer sphereRenderer;
    public GameObject sphere;
    private bool changeColorMode = false;
    private bool scalingMode = false;


    // Start is called before the first frame update
    void Start()
    {
        sphereRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // need to change
        if (Input.GetKeyDown(KeyCode.A))
        {
            ChangeColor();

        }
        
    }

    public void ChangeColor()
    {
        Color currentColor = sphereRenderer.material.color;

        Color blueColor = HexToColor("#62E5FF");
        Color yellowColor = HexToColor("#FDFD96");

        if (currentColor == blueColor)
        {
            sphereRenderer.material.color = yellowColor;
        }
        else
        {
            sphereRenderer.material.color = blueColor;
        }

    }

    Color HexToColor(string hex)
    {
        Color color = Color.white;
        ColorUtility.TryParseHtmlString(hex, out color);
        return color;
    }


    public void ScaleCube()
    {
        sphere.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f); 
    }

    public void ClearAction()
    {
        changeColorMode = false;
        scalingMode = false;
    }

    public void SetChangeColorMode()
    {
        changeColorMode = true;
        scalingMode = false;
    }

    public void SetScalingMode()
    {
        scalingMode = true;
        changeColorMode = false;
    }

}
