using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MiniGameConfigurationS : Configuration
{
        [Tooltip("The start time and date on new game. \nFormat: YYYY-MM-DD HH:MM:SS")]
        public string StartDate = "2020-01-01 12:00:00";
}
