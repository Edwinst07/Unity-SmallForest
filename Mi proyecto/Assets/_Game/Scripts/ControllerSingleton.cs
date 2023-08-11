using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSingleton : MonoBehaviour
{

    #region Singleton
    public static ControllerSingleton Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            DestroyImmediate(gameObject);
            return;

        }   
        Instance = this;
    }

    #endregion
}
