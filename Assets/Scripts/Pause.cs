using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    InputManager input;
    private void Awake()
    {
        if (!GameObject.Find("Menu"))
        {
            input = GameObject.Find("SysManager").GetComponent<InputManager>();
        }
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        input.m_isPause = false;
        input.m_pausing = false;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
