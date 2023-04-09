using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tester : MonoBehaviour
{

    public Conversation convo;
    public Button navButton;
    public GameObject panel;

    public void StartConvo()
    {
        DialogueManager.StartConversation(convo);
        navButton.enabled = true;
        panel.gameObject.SetActive(false);
    }
    
}
