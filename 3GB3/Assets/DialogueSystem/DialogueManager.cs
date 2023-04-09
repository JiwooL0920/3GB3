using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;




public class DialogueManager : MonoBehaviour
{
	public TextMeshProUGUI speakerName, dialogue, navButtonText, showChoicesText;
	public Image speakerSprite; 
	public Button showChoices;
	public Button navButton;

	public TextMeshProUGUI choice1, choice2, choice3;

	private int currentIndex;
	private Conversation currentConvo;
	private static DialogueManager instance;
	private Animator anim;
	
	
	
	private void Awake()
	{
		if(instance == null)
		{
			instance = this;
			anim = GetComponent<Animator>();
			instance.anim.SetBool("isOpen", false);
			showChoices.enabled = false;
			navButton.enabled = true;
		}
		else
		{
			Destroy(gameObject);
		}
	}


	public static void StartConversation(Conversation convo)
	{
		//showChoices.enabled = false;
		//navButton.enabled = true;

		instance.anim.SetBool("isOpen", true);
		Debug.Log("load");
		instance.currentIndex = 0;
		instance.currentConvo = convo;
		instance.speakerName.text = "";
		instance.dialogue.text = "";
		
		instance.navButtonText.text = ">";
		
		

		instance.ReadNext();
	}
	public void ReadNext()
    {
		
		if(currentConvo.haveChoice() && currentIndex > currentConvo.GetLength()-1)
		{
			
			showChoices.enabled = true;
			navButton.enabled = false;
			//navButtonText.text = "X"
			showChoicesText.text = "Show Choices";

			
		}
		if( currentIndex > currentConvo.GetLength())
        {
			showChoices.enabled = true;
			navButton.enabled = false;
			instance.anim.SetBool("isOpen",false);
			navButton.enabled = true;
			return;
        }
		speakerName.text = currentConvo.GetLineByIndex(currentIndex).speaker.GetName();
		dialogue.text = currentConvo.GetLineByIndex(currentIndex).dialogue;
		speakerSprite.sprite = currentConvo.GetLineByIndex(currentIndex).speaker.GetSprite();
		currentIndex++;

		if(currentConvo.haveChoice())
		{
			choice1.text = currentConvo.GetChoiceByIndex(0).choice;
			choice2.text = currentConvo.GetChoiceByIndex(1).choice;
			choice3.text = currentConvo.GetChoiceByIndex(2).choice;
		}

		if(currentIndex >= (int)currentConvo.GetLength())
		{
			//navButtonText.text = "X";
			
		}
    }

	
/*
	private IEnumerator TypeText(string text)
	{
		dialogue.text = "";
		bool complete = false;
		int index = 0;

		while(!complete)
		{
			dialogue.text += text[index];
			index++;

			yield return new WaitForSeconds(0.02f);
			if(index == text.Length -1)
			complete = true;
		}

	}
	
*/
}
