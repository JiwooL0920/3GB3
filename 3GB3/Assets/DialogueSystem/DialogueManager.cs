using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;




public class DialogueManager : MonoBehaviour
{
	public TextMeshProUGUI speakerName, dialogue, navButtonText;
	public Image speakerSprite; 


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
		}
		else
		{
			Destroy(gameObject);
		}
	}

	public static void StartConversation(Conversation convo)
	{
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
		if(currentIndex > currentConvo.GetLength())
        {
			instance.anim.SetBool("isOpen",false);
			return;
        }
		speakerName.text = currentConvo.GetLineByIndex(currentIndex).speaker.GetName();
		dialogue.text = currentConvo.GetLineByIndex(currentIndex).dialogue;
		speakerSprite.sprite = currentConvo.GetLineByIndex(currentIndex).speaker.GetSprite();
		currentIndex++;

		if(currentIndex >= currentConvo.GetLength())
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
