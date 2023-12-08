using System;
using System.Collections.Generic;
using System.Linq;
using Naninovel;
using Naninovel.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameUIS : CustomUI
{
    MiniGameStateControlS minigameObject;
    string sceneName = "DTT Level Select";
    bool isSceneWasDeleted;

    protected override void Awake()
    {
        base.Awake();
        minigameObject = FindAnyObjectByType<MiniGameStateControlS>();
    }
    public UniTask ActivateMiniGame()
    {
        if (minigameObject!=null)
        minigameObject.OpenGame();
        return UniTask.CompletedTask;
    }
    public UniTask RemoveMiniGame()
    {
        if (minigameObject != null)
            minigameObject.CloseGame();
        if (!isSceneWasDeleted)
        {
            SceneManager.UnloadSceneAsync(sceneName);
            isSceneWasDeleted = true;
        }
        return UniTask.CompletedTask;
    }
}