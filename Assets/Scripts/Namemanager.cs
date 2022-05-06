using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Namemanager : MonoBehaviour
{

    public static Namemanager Instance;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


}
