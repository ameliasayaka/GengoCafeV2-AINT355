using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class Phrase
{
    [JsonProperty]
    public string english, japanese;
    [JsonProperty]
    public int tag;
    [JsonProperty]
    public int voice;

    public bool isUnlocked;

    [JsonConstructor]
    public Phrase(string english, string japanese,int tag,int voice)
    {
        this.english = english;
        this.japanese = japanese;
        this.tag = tag;
        this.voice = voice;

        //base phrases automatically unlocked
        if (tag == 0)
        { 
            isUnlocked = true;
        }
        else
        {
            isUnlocked = false;
        }
    }

    
}
