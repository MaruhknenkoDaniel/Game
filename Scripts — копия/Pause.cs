using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public bool pause;

    public GameObject PauseMenu;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (pause)
            {
                Resume();
            }


            else
            {
                Inpause();

            }
        }
    }
    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
        pause = false;

    }
    public void Inpause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 1.0f;
        pause = true;

    }

    public void Exit()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
    }
}
