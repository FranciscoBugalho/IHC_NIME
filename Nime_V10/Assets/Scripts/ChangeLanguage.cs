using UnityEngine;
using UnityEngine.Localization.Settings;

public class ChangeLanguage : MonoBehaviour
{
    public void ToPortuguese()
    {
        //Debug.Log("Changing to Portuguese");
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale(SystemLanguage.Portuguese);
    }

    public void ToEnglish()
    {
        //Debug.Log("Changing to English");
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale(SystemLanguage.English);
    }
}
