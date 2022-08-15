using UnityEngine;

public class MainMenuButtonsView : MonoBehaviour
{
	[SerializeField] private MainMenuButtonsController controller;


	public void OnLanguageDropDownPressed(int languageIndex)
	{
		controller.onLanguageDropDownPressed(languageIndex);
	}
}
