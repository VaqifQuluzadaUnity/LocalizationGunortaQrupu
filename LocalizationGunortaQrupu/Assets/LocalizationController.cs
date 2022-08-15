using DynamicBox.EventManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LocalizationController : MonoBehaviour
{

	private void OnEnable()
	{
		EventManager.Instance.
			AddListener<OnLanguageDropDownPressedEvent>(OnLanguageDropDownPressedEventHandler);
	}

	private void OnDisable()
	{
		EventManager.Instance.
			RemoveListener<OnLanguageDropDownPressedEvent>(OnLanguageDropDownPressedEventHandler);
	}

	private void OnLanguageDropDownPressedEventHandler(OnLanguageDropDownPressedEvent eventDetails)
	{
		List<Locale> availableLocales = LocalizationSettings.AvailableLocales.Locales;

		Locale currentSelectedLocale = availableLocales[eventDetails.LanguageIndex];

		LocalizationSettings.Instance.SetSelectedLocale(currentSelectedLocale);
	}

	//   public void OnLanguageDropDownPressed(int languageIndex)
	//{
	//	Debug.Log(languageIndex);

	//	List<Locale> availableLocales = LocalizationSettings.AvailableLocales.Locales;

	//	Locale currentSelectedLocale = availableLocales[languageIndex];

	//	LocalizationSettings.Instance.SetSelectedLocale(currentSelectedLocale);
	//}
}
