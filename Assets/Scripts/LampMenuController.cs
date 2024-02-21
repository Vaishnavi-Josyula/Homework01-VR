using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampMenuController : MonoBehaviour
{
    public Light lampLight;
    //public Slider intensitySlider;

    private bool isOn = false;

    // Start is called before the first frame update
    void Start()
    {
        // Set up slider for intensity control
        //intensitySlider.minValue = 0;
        //intensitySlider.maxValue = 1;
        //intensitySlider.onValueChanged.AddListener(AdjustIntensity);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            TogglePower();
        }
    }

    void TogglePower()
    {
        isOn = !isOn;
        lampLight.enabled = isOn;
    }

    void AdjustIntensity(float intensity)
    {
        lampLight.intensity = intensity;
    }

    public void SetNoAction()
    {
        // No action needed in this implementation
    }

    public void CloseMenu()
    {
        //
    }

}
