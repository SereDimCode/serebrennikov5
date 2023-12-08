using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class CharacterInventoryS : MonoBehaviour
{
    public bool isHaveBanana;
    public GameObject itemInHands;
    public AreaToSpeakYourselfS speakArea;
    private void Awake()
    {
        itemInHands = null;
        isHaveBanana = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "banana" && !isHaveBanana)
        {
            speakArea.activation = true;
            QuestLogS.inst.NextQuest();
            isHaveBanana = true;
            itemInHands = collision.gameObject;
            collision.transform.parent = transform;
            collision.transform.localPosition = Vector3.zero;
            collision.transform.localPosition = (Vector3.up * 1.5f);
        }
    }
}
