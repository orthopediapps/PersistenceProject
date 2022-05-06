using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DataRecord : MonoBehaviour
{
    //public TextMeshProUGUI textName;
    public Text textName2;
    
    private MainManager mainManager;
   // public string playerName;
    
    
    // Start is called before the first frame update
    void Start()
    {
        mainManager = GetComponent<MainManager>();
       // DisplayName();
        if (Namemanager.Instance != null)
        {
          
            textName2.text = "Highest Score is: " + mainManager.HighestScore + "Player: " + Namemanager.Instance.myName;
            return;
        }
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*void DisplayName()
    {
        playerName = Namemanager.Instance.myName;
        
        textName2.text = "Player: " + playerName;*/
    
}
