using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene: MonoBehaviour
{
    public void LoadCombat()
    {
        SceneManager.LoadScene("Combat");
    }

    public void LoadRoom()
    {
        SceneManager.LoadScene("Room");
    }

    public void LoadRoad()
    {
        SceneManager.LoadScene("Home");
    }

}
