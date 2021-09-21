using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    private bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                Time.timescale = 0;
                panel.SetActive(true);
                isPaused = true;
            }
            else
            {
                Time.timescale = 1;
                panel.SetActive(true);
                isPaused = true;
            }
            
        }
    }
}
