using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DynamicBox.EventManagement;
public class OnLanguageDropDownPressedEvent : GameEvent
{
  public int LanguageIndex;

  public OnLanguageDropDownPressedEvent(int _languageIndex)
	{
		LanguageIndex = _languageIndex;
	}
}
