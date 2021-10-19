using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    KeyCode[] debugKey = { KeyCode.S, KeyCode.T, KeyCode.A, KeyCode.R };
    int debugKeyProgress = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug
        if(!Switches.debugMode)
        {
            if(Input.GetKeyDown(debugKey[debugKeyProgress]))
            {
                debugKeyProgress ++;
                if(debugKeyProgress == debugKey.Length)
                {
                    Switches.debugMode = true;
                    Debug.Log("Debug mode on");
                }
            }
        }


    }
}
