using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float WaitSec;
    private int WaitSecInt; 
    public TMPro.TMP_Text text;
    public GameObject WinningScreen;

    private void FixedUpdate(){
        if (WaitSec > 0){
            WaitSec -= Time.fixedDeltaTime;
            WaitSecInt = (int)WaitSec;
            text.text =  WaitSecInt.ToString();
        }
        else{
            WinningScreen.SetActive(true);
        }
    }
}
