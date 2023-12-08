using Naninovel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToNovelModeS : MonoBehaviour
{
    public static void ToNovel(string scriptName_, string lavel_)
    {
        //=========================================================== Close adventure
        Camera.main.depth = -1;
        AdventureModeS.inst.gameObject.SetActive(false);
        //=========================================================== Close adventure
        //=========================================================== Open novel
        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = true;
        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        scriptPlayer.PreloadAndPlayAsync(scriptName_, label: lavel_).Forget();
        //=========================================================== Open novel
    }
}
