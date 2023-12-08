using Naninovel;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static NPCtouchingS;

public class DetectSisterNovelS : MonoBehaviour, InpcDetect
{
    //=========================================================== Editor
    public QuestLogS questLog;
    public Transform targetPosition;
    //=========================================================== Editor
    string badSister = "badSisterNani";
    string normalSister = "normalSisterNani";
    string firstQuest = "sisterNani";
    string lastSpeach = "lastSpeachNani";

    public bool isBadSister;
    private void Awake()
    {
        isBadSister = false;
    }
    public string DetectNextDialogue(GameObject talker) //gives name of script
    {
        //=========================================================== Get variable
        var service = Engine.GetService<ICustomVariableManager>();
        if ((service.GetVariableValue("isBadSister")!= null))
        {
            isBadSister = bool.Parse(service.GetVariableValue("isBadSister"));
        }
        //=========================================================== Get variable
        var inventory = talker.GetComponent<CharacterInventoryS>();
        if (questLog.curQ == 0)
        {
            transform.position = targetPosition.position;
            questLog.NextQuest();
            return firstQuest;
        }
        else if (questLog.curQ == 3 && inventory.isHaveBanana)
        {
            inventory.isHaveBanana = false;
            Destroy(inventory.itemInHands);
            questLog.NextQuest();
            return lastSpeach;
        }
        else if (isBadSister)
        {
            return badSister;
        }
        else
        {
            return normalSister;
        }
    }
}
