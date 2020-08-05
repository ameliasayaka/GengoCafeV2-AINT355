using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceLines
{
    private AudioClip[] audioClips;

    public VoiceLines()
    {
        audioClips = Resources.LoadAll<AudioClip>("VoiceLines/");
    }

    public AudioClip[] AudioClips
        {
        get
        {
            return audioClips;
        }
        }
}
