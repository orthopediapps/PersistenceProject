using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Namemanager : MonoBehaviour
{
public string myName;
    public GameObject inputField;
    public static Namemanager Instance;

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
            Instance = this;
            DontDestroyOnLoad(gameObject);
        
    }

    
    // Start is called before the first frame update


    public void StoreName(string s)
    {
        Instance.myName = s;
        Debug.Log(myName);
    }
}
