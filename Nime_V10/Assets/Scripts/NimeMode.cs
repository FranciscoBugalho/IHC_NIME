using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NimeMode : MonoBehaviour
{
    public GameObject SoundSlider;
    public GameObject BeatButton;
    public AudioSource sound;
    public Sprite[] spriteArray;
    private bool isBeatActive;

    public void DisplayObject()
    {
        if (SoundSlider != null)
        {
            if (SoundSlider.active == true)
            {
                SoundSlider.SetActive(false);
            }
            else
            {
                SoundSlider.SetActive(true);
            }
        }
    }

    void Start()
    {
        isBeatActive = false;
    }

    public void InteractBeatButton()
    {
        if (BeatButton != null)
        {
            Image aux = BeatButton.GetComponent<Image>();
            if (isBeatActive)
            {
                sound.Stop();
                isBeatActive = false;
                aux.sprite = spriteArray[0];
            }
            else
            {
                sound.Play();
                isBeatActive = true;
                aux.sprite = spriteArray[1];
            }
        }
    }
}
