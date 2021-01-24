using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    private bool isMute;   
    void Start()
    {
        isMute = PlayerPrefs.GetInt("Mute") == 1;
        AudioListener.pause = isMute;
    }

        public void MuteButton()
    {
        isMute = !isMute;
        AudioListener.pause = isMute;
        PlayerPrefs.SetInt("Mute", isMute ? 1 : 0);
    }
}
