using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudio : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip clickFx;
    public AudioClip clickDel;

    public void HoverSound()
    {
        myFx.PlayOneShot(clickFx);
    }
    
    public void HoSound()
    {
        myFx.PlayOneShot(clickDel);
    }
}
