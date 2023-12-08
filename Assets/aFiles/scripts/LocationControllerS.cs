using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationControllerS : MonoBehaviour, ISingleton
{
    public static LocationControllerS inst;
    public Transform[] maps;
    public enum Side
    {
        left, right
    }
    public void Init()
    {
        inst = this;
    }
}
