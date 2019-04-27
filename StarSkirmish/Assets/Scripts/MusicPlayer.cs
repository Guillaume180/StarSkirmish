using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    //Simply drag an audiosource (preferably on the gameobject this is attached to) and an audio clip (from anywhere in your project folders) into the inspector tab where the public variables are declared.

    //A reference to our audio source.
    public AudioSource myAudioSource;

    //A reference to our audiosource clip.
    public AudioClip myAudioClip;

    // Start is called before the first frame update
    void Start()
    {
        //Sets the audiosource's clip to a specific audio clip.
        myAudioSource.clip = myAudioClip;

        //Plays the audiosource.
        myAudioSource.Play();
    }

}
