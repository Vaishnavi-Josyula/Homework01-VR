using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioMenuController : MonoBehaviour
{
    public AudioSource audioSource;
    //[SerializeField] private Slider slider;

    public AudioClip[] songs;
    private int currentSongIndex = 0;

    private bool isPlaying = false;
    private int volume = 10;


    // Start is called before the first frame update
    void Start()
    {
        //audioSource.Stop();
        isPlaying = true;
        audioSource.volume = volume;
        //slider.onValueChanged.AddListener(OnSliderValueChanged);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            TogglePower();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            ChangeSong();
        }

        /*if (slider.onValueChanged)
        {
            volume += 5;
            AdjustVolume(volume);
            Debug.Log("INCREASING VOLUME");
        }*/


    }

    public void TogglePower()
    {
        if (isPlaying)
        {
            Debug.Log("IS PLAYING FALSE, TOGGLE POWER FUNC");
            audioSource.Pause();
        }
        else
        {
            Debug.Log("IS PLAYING TRUE, TOGGLE POWER FUNC");
            audioSource.Play();
        }

        isPlaying = !isPlaying;
    }

    public void ChangeSong()
    {
        currentSongIndex = (currentSongIndex + 1) % songs.Length;
        audioSource.clip = songs[currentSongIndex];
        audioSource.Play();
        isPlaying = true;
    }

    public void AdjustVolume(float volume)
    {
        audioSource.volume = volume;
    }

    public void OnSliderValueChanged(float value)
    {
        // Adjust the volume based on the slider's value
        audioSource.volume = value;
        Debug.Log("Volume changed to: " + value);
    }



    public void SetNoAction()
    {
        isPlaying = false;
    }

    public void CloseMenu()
    {
        //
    }

}
