using UnityEngine;

public class VRControllerOutline : MonoBehaviour
{
    private Outline currentOutline; // Reference to the Outline component of the currently pointed object

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);

        // Cast a ray from the controller/pointer
        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitObject = hit.collider.gameObject;

            // Check if the hit object has an Outline component
            Outline outline = hitObject.GetComponent<Outline>();

            if (outline != null)
            {
                // Enable the Outline component of the hit object
                outline.enabled = true;

                // Store the reference to the current outline
                currentOutline = outline;
            }
            else
            {
                // If the hit object does not have an Outline component,
                // deactivate the current outline if it exists
                DeactivateCurrentOutline();
            }
        }
        else
        {
            // If no object is hit by the ray, deactivate the current outline if it exists
            DeactivateCurrentOutline();
        }
    }

    void DeactivateCurrentOutline()
    {
        // Deactivate the current outline if it exists
        if (currentOutline != null)
        {
            currentOutline.enabled = false;
            currentOutline = null; // Clear the reference
        }
    }
}
