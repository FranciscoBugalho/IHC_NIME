using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization.Settings;

public class GifScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] animatedImages;
    public Sprite[] imagesPt;
    public Image animatedObj;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.GetLocale(SystemLanguage.English))
        {
            animatedObj.sprite = animatedImages[(int)(Time.time * 5) % animatedImages.Length];
        } 
        else
        {
            animatedObj.sprite = imagesPt[(int)(Time.time * 5) % imagesPt.Length];
        }
    }
}
