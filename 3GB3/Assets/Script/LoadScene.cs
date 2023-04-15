using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene: MonoBehaviour
{
    public void LoadSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void LoadMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void LoadHelp()
    {
        SceneManager.LoadScene("Help");
    }

    public void LoadCombat()
    {
        SceneManager.LoadScene("Combat");
    }

    public void LoadRoom()
    {
        SceneManager.LoadScene("Room_afterwork"); 
    }

    public void Initial()
    {
        SceneManager.LoadScene("Room01");
    }

    public void LoadRoad()
    {
        SceneManager.LoadScene("Road");
        // player = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

}
