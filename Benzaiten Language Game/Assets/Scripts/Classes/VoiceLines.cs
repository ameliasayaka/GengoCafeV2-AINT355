using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceLines
{
    private AudioClip[] audioClips;

    public VoiceLines(string path)
    {
        audioClips = Resources.LoadAll<AudioClip>(path);
        //Debug.Log(audioClips.Length);
    }

    public AudioClip[] AudioClips
        {
        get
        {
            return audioClips;
        }
        }
}
