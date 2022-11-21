using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pausePanel;
    public void PauseOn()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void PauseOff()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }
}
