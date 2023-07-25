using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
   //no start or update methods

    public static MainManager instance;
    public Color teamColor;

    private void Awake()
    {
        if (instance) 
        {
            Destroy(gameObject);
            return;
        }
       instance = this;
       DontDestroyOnLoad(gameObject);
    }
}
