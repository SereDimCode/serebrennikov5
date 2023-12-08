using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureModeS : MonoBehaviour, ISingleton
{
    public static AdventureModeS inst;

    public void Init()
    {
        inst = this;
    }

    private void Awake()
    {
        //=========================================================== start in adventure
        Camera.main.depth = -1;
        gameObject.SetActive(false);
        //=========================================================== start in adventure
    }

}
