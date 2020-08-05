using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class Phrase
{
    [JsonProperty]
    public string english, japanese;
    public bool isUnlocked;

    [JsonConstructor]
    public Phrase(string english, string japanese)
    {
        this.english = english;
        this.japanese = japanese;
        isUnlocked = false;
    }

    
}
