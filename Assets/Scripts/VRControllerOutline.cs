using UnityEngine;

public class VRControllerOutline : MonoBehaviour
{
    private Outline currentOutline; 

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitObject = hit.collider.gameObject;

            Outline outline = hitObject.GetComponent<Outline>();

            if (outline != null)
            {
                outline.enabled = true;

                currentOutline = outline;
            }
            else
            {
                DeactivateCurrentOutline();
            }
        }
        else
        {
            DeactivateCurrentOutline();
        }
    }

    void DeactivateCurrentOutline()
    {
        if (currentOutline != null)
        {
            currentOutline.enabled = false;
            currentOutline = null; 
        }
    }
}
