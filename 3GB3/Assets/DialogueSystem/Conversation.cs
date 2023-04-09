
using UnityEngine;

[CreateAssetMenu(fileName = "New Conversation", menuName = "Dialogue/New Conversation")]

public class Conversation : ScriptableObject
{
	[SerializeField] private DialogueLine[] allLines;
	//[SerializeField] private ChoiceLine[] allChoices;

	public DialogueLine GetLineByIndex(int index)
	{
		return allLines[index];
	}


	public int GetLength()
	{
		return allLines.Length - 1;
	}
/*
	public bool haveChoice()
	{
		return (allChoice.Length >0);
	}

	public ChoiceLine GetAllChoices(){
		return allChoices[index];
	}
	*/
}
