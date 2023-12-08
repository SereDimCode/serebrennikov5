using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AreaToSpeakYourselfS : MonoBehaviour
{
    //=========================================================== Editor
    public bool activation;
    public string scriptName;
    //=========================================================== Editor
    string label = "Yourself";
    private void Awake()
    {
        activation = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player" &&
            activation)
        {
            QuestLogS.inst.NextQuest();
            activation = false;
            SwitchToNovelModeS.ToNovel(scriptName, label);
        }
    }
}
