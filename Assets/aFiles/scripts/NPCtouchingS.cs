using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UniRx.Triggers;
using UnityEngine;

public class NPCtouchingS : MonoBehaviour
{
    public string scriptName;
    public string label;
    InpcDetect inpcDetect;
    private void Awake()
    {
        inpcDetect = GetComponent<InpcDetect>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            collision.transform.Translate((collision.transform.position - transform.position).normalized * 2f);
            scriptName = inpcDetect.DetectNextDialogue(collision.gameObject);
            SwitchToNovelModeS.ToNovel(scriptName, label);

        }
    }
    public interface InpcDetect
    {
        public string DetectNextDialogue(GameObject talker);
    }
}
