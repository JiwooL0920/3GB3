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
        SceneManager.LoadScene("Room_afterwork");
    }

    public void LoadRoad()
    {
        SceneManager.LoadScene("Road");
    }

}
