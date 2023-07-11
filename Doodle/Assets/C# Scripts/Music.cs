using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite onMusic;
    public Sprite offMusic;

    public Slider slider;
    public Image MusicButton;
    public bool isOn;
    public static bool isOn1;
    public AudioSource ad;

    
    void Start()
    {
        isOn = true;
        isOn1 = isOn;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerPrefs.GetInt("music") == 0)
        {
            MusicButton.GetComponent<Image>().sprite = onMusic;
            ad.enabled = true;
            isOn = true;
            isOn1 = isOn;
        }
        if (PlayerPrefs.GetInt("music") == 1)
        {
            MusicButton.GetComponent<Image>().sprite = offMusic;
            ad.enabled = false;
            isOn = false;
            isOn1 = isOn;
        }
        ad.volume = slider.value;
    }

    public void offSound()
    {
        if(!isOn)
        {
            PlayerPrefs.SetInt("music", 0);
        }
        else if (isOn)
        {
            PlayerPrefs.SetInt("music", 1);
        }
    }
}
