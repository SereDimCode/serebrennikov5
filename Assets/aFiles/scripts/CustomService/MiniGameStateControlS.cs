using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameStateControlS : MonoBehaviour
{
    //game openning in novel mode async, MinigameManagerS is service
    public GameObject miniGame;
    public void OpenGame()
    {
        miniGame.SetActive(true);
    }
    public void CloseGame()
    {
        miniGame.SetActive(false);
    }
}
