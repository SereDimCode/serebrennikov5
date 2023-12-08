using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestLogS : MonoBehaviour, ISingleton
{
    //=========================================================== Editor
    public TextMeshProUGUI tmp;
    public GameObject banana;
    public NextLocationS secondThirdBind;
    //=========================================================== Editor
    public static QuestLogS inst;
    public string[] quests;
    public int curQ;
    public string logText;
   
    private void Awake()
    {
        quests = new string[] {
            "talk with sister",
            "find banana",
            "bring banana",
            "find sister",
            ""
        };
        curQ = 0;
        logText = quests[curQ];
        tmp.text = logText;
    }
    public void NextQuest()
    {
        curQ++;
        ShowLog();
        if (curQ == 1)
        {
            banana.SetActive(true);
        }
        if (curQ == 2)
        {
            secondThirdBind.GetComponent<Collider2D>().isTrigger = false;
        }
    }
    public void ShowLog()
    {
        if (curQ < quests.Length)
        {
            logText = quests[curQ];
            tmp.text = logText;
        }
    }

    public void Init()
    {
        inst = this;
    }
}
