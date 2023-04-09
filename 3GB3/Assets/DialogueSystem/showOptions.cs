using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showOptions : MonoBehaviour 
 {
     public GameObject panel;
     int counter;
     public Button choice1, choice2, choice3;

 
     public void SwitchShowHide()
     {
         counter++;
 
         if (counter % 2 == 1)
         {
             panel.gameObject.SetActive (false);
             choice1.enabled = false;
             choice2.enabled = false;
             choice3.enabled = false;
         } 
         else
         {
             panel.gameObject.SetActive (true);
             choice1.enabled = true;
             choice2.enabled = true;
             choice3.enabled = true;
         }
     }

     

    
 
 }