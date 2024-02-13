using UnityEngine;

public class ObjectHighlighter : MonoBehaviour
{
    private Outline outline; // Reference to the Outline component
    private bool isPointingAtObject = false; // Flag to track if the pointer is pointing at an object

    void Start()
    {
        outline = GetComponent<Outline>();
        if (outline != null)
        {
            outline.enabled = false;
        }
    }

    void Update()
    {
        if (isPointingAtObject)
        {
            if (outline != null)
            {
                outline.enabled = true;
            }
        }
        else
        {
            if (outline != null)
            {
                outline.enabled = false;
            }
        }
    }

    public void PointerEnter()
    {
        isPointingAtObject = true;
    }

    public void PointerExit()
    {
        isPointingAtObject = false;
    }
}
