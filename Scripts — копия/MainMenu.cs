using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadLeve()
    {
        Debug.Log("STart Game");
        SceneManager.LoadScene("Game");  

    }
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit(); 
    }
}
