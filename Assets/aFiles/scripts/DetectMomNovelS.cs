using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static NPCtouchingS;

public class DetectMomNovelS : MonoBehaviour, InpcDetect
{
    //=========================================================== Editor
    public QuestLogS questLog;
    //=========================================================== Editor
    string bad = "badMomNani";
    string normal = "normalMomNani";
    string lastSpeach = "lastSpeachNani";

    public bool isBadMom;
    private void Awake()
    {
        isBadMom = false;
    }
    public string DetectNextDialogue(GameObject talker) //gives name of script
    {
        //=========================================================== Get variable
        var service = Engine.GetService<ICustomVariableManager>();
        if ((service.GetVariableValue("isBadMom") != null))
        {
            isBadMom = bool.Parse(service.GetVariableValue("isBadMom"));
        }
        //=========================================================== Get variable
        var inventory = talker.GetComponent<CharacterInventoryS>();
        //=========================================================== Take banana
        if (questLog.curQ == 3 && inventory.isHaveBanana)
        {
            inventory.isHaveBanana = false;
            Destroy(inventory.itemInHands);
            questLog.NextQuest();
            return lastSpeach;
        }
        //=========================================================== Take banana
        //=========================================================== Triviality
        else if (isBadMom)
        {
            return bad;
        }
        else
        {
            return normal;
        }
        //=========================================================== Triviality
    }
}
