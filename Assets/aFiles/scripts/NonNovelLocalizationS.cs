using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;
using UnityEngine.UI;

public class NonNovelLocalizationS : Text
{
    [ManagedText("QuestText")]
    public static string q0 = "talk with sister";
    protected override void Awake()
    {
        base.Awake();

        text = q0; // ѕрисвоить метке текущее значение управл€емой текстовой записи.

        // ќбновить метку, когда пользователь мен€ет локаль в процессе выполнени€.
        Engine.GetService<ILocalizationManager>().OnLocaleChanged += _ => text = q0;
    }
}
