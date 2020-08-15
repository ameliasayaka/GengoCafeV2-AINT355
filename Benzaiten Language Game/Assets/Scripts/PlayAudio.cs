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
        Debug.Log("Play audio activated");
        Debug.Log("index is " + voiceLineNumber);
        Debug.Log(dataHolderScript.ConversationVoiceLines.AudioClips.Length);
        //make sure index not out of range
        if (voiceLineNumber < dataHolderScript.ConversationVoiceLines.AudioClips.Length)
        {
            Debug.Log("In range");
            voiceLine = dataHolderScript.ConversationVoiceLines.AudioClips[voiceLineNumber];
            if (voicePlayer != null)
            {
                voicePlayer.clip = voiceLine;
                voicePlayer.Play();
            }
        }
    }
    public void PlayPhrase(int phraseVoiceLineNumber)
    {
        Debug.Log("Phrase int is: " + phraseVoiceLineNumber);
        voiceLine = dataHolderScript.PhraseVoiceLines.AudioClips[phraseVoiceLineNumber];
        if (voicePlayer != null)
        {
            voicePlayer.clip = voiceLine;
            voicePlayer.Play();
        }
    }
}
