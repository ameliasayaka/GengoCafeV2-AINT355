using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhraseButton : MonoBehaviour
{
    public int phraseInt;
    PlayAudio playAudioScript;
    GameObject audioHolder;
    // Start is called before the first frame update
    void Start()
    {
        //phraseInt = 0;
        audioHolder = GameObject.FindGameObjectWithTag("VoiceHolder");
        playAudioScript = audioHolder.GetComponent<PlayAudio>();
        
    }

    public void CallPlayAudio()
    {
        playAudioScript.PlayPhrase(phraseInt);
    }


}
