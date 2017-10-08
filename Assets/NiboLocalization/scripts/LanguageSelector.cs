using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSelector : MonoBehaviour {

    public Text inLanguageCode;
    public Text lblActiveLanguage;

     void Awake()
    {
       lblActiveLanguage.text = ("Active Language: " + LocalizationText.GetLanguage());
    }

    public void LanguageSelectorAction(){
        LocalizationText.SetLanguage(inLanguageCode.text);
        print(inLanguageCode.text); 
        lblActiveLanguage.text = ("Active Language: " +LocalizationText.GetLanguage());
    }
}
