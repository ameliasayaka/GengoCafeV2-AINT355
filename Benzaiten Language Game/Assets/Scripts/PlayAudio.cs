using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    private AudioSource voicePlayer;
    private AudioClip voiceLine;
    private GameObject dataHolder;
    private DataHolder dataHolderScript;

    // Start is called before the first frame update
    void Start()
    {
        voicePlayer = gameObject.GetComponent<AudioSource>();
        dataHolder = GameObject.FindGameObjectWithTag("DataHolder");
        dataHolderScript = dataHolder.GetComponent<DataHolder>();
    }

    public void PlayVoiceLine(int voiceLineNumber)
    {
        voiceLine = dataHolderScript.VoiceLines.AudioClips[voiceLineNumber];
        if (voicePlayer != null)
        {
            voicePlayer.clip = voiceLine;
            voicePlayer.Play();
        }
    }
}
