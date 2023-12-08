using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedVariablesS : MonoBehaviour, ISingleton
{
    public List<CustomVariable> variables;
    public static SavedVariablesS inst;
    private void Awake()
    {
        variables = new List<CustomVariable>();
    }
    public void Init()
    {
        inst = this;
    }
    public void InputVariables()
    {
        var service = Engine.GetService<ICustomVariableManager>();
        foreach(var variable in variables)
        {
            service.SetVariableValue(variable.Name, variable.Value);
        }
    }
}
