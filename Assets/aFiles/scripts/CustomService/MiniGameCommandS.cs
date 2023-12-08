using Naninovel;
using Naninovel.Commands;
using System.Threading;

[Documentation("Adds time to game's calendar in the form of days and/or hours.")]
public class MiniGameCommandAdd : Command
{
    public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        var uiManager = Engine.GetService<IUIManager>();
        var ui = uiManager.GetUI<MiniGameUIS>();

        await ui.ActivateMiniGame();
    }
}
public class MiniGameCommandRemove : Command
{
    public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        var uiManager = Engine.GetService<IUIManager>();
        var ui = uiManager.GetUI<MiniGameUIS>();

        await ui.RemoveMiniGame();
    }
}
