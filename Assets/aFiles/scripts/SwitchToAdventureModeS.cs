using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CommandAlias("adventure")]
public class SwitchToAdventureMode : Command
{
    public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        //=========================================================== Disable input
        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = false;
        //=========================================================== Disable input
        //=========================================================== Stop scripts
        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        scriptPlayer.Stop();
        //=========================================================== Stop scripts
        //=========================================================== Open adventure
        Camera.main.depth = 10;
        AdventureModeS.inst.gameObject.SetActive(true);
        //=========================================================== Open adventure
        //=========================================================== Save Variables nani
        var service = Engine.GetService<CustomVariableManager>();
        var variables =  new List<CustomVariable>();

        foreach (var variable in service.GetAllVariables())
        {
            variables.Add(variable);
        }
        SavedVariablesS.inst.variables = variables;

        //=========================================================== Save Variables nani
        //=========================================================== Reset nani
        var stateManager = Engine.GetService<IStateManager>();
        await stateManager.ResetStateAsync();
        SavedVariablesS.inst.InputVariables(); //DONT DELETE MY VARS!!
        //=========================================================== Reset nani
    }
}
