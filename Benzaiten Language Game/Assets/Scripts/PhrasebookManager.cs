using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PhrasebookManager : MonoBehaviour
{
    private DataHolder dataHolder;
    private PhraseBook phrasebook;
    private Player player;
    [SerializeField]
    private GameObject phrasePrefab;
    void Start()
    {
        dataHolder = GameObject.Find("DataHolder").GetComponent<DataHolder>();
        phrasebook = dataHolder.Phrasebook;
        player = dataHolder.player;
        
        //check player progression andset unlock
        

        foreach (Phrase phrase in phrasebook.PhraseList)
        {
            //after intro with guide unlock kaoru associated phrases
           if (phrase.tag == 1)
            {
                if(player.PlayerProgression["Guide"] >= 1)
                {
                    phrase.isUnlocked = true;
                }
                else
                {
                    phrase.isUnlocked = false;
                }
            }
           else if (phrase.tag ==2)
            {
                if (player.PlayerProgression["Kaoru"] >= 1)
                {
                    phrase.isUnlocked = true;
                }
                else
                {
                    phrase.isUnlocked = false;
                }
            }
               
            if (phrase.isUnlocked == true)
            {
                GameObject tempPhrase = Instantiate(phrasePrefab, transform);
                TextMeshProUGUI[] textList = tempPhrase.GetComponentsInChildren<TextMeshProUGUI>();

                textList[0].text = phrase.japanese.Replace("~~", dataHolder.player.PlayerName);
                textList[1].text = phrase.english.Replace("~~", dataHolder.player.PlayerName);
            }
        }
    }
}
