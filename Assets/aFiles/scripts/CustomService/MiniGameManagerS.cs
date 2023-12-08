using Naninovel;
using System;
using System.Globalization;
using System.Threading.Tasks;
using UnityEngine;

[InitializeAtRuntime]
public class MiniGameManagerS : IEngineService<MiniGameConfigurationS>
{

    public MiniGameConfigurationS Configuration { get; }

    public MiniGameManagerS(MiniGameConfigurationS config)
    {
        Configuration = config;
    }

    public UniTask InitializeServiceAsync() => UniTask.CompletedTask;

    public void ResetService()
    {
    }

    public void DestroyService()
    {
    }
}

