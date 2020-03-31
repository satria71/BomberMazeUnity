using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudio : MonoBehaviour
{
    public AudioSource btnAudio;
    public AudioClip hoverAudio;
    public AudioClip clickAudio;

    public void HoverSound(){
        btnAudio.PlayOneShot(hoverAudio);
    }
    public void ClickSound(){
        btnAudio.PlayOneShot(clickAudio);
    }
}
