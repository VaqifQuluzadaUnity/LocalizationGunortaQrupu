using DynamicBox.EventManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtonsController : MonoBehaviour
{
  [SerializeField] private MainMenuButtonsView view;

  public void onLanguageDropDownPressed(int languageIndex)
	{
		EventManager.Instance.Raise(new OnLanguageDropDownPressedEvent(languageIndex));
	}
}
