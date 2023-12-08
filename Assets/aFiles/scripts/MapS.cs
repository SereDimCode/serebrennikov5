using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapS : MonoBehaviour
{
    public GameObject fullMap;
    public void OpenAndClose()
    {
        if (fullMap.activeSelf)
        {
            fullMap.SetActive(false);
        }
        else
        {
            fullMap.SetActive(true);
        }
        
    }
}
