using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LocalizationComponent : MonoBehaviour
{

	public string key;
	private string _language = LocalizationText.GetLanguage ();

	void Awake ()
	{
		key = gameObject.name;
	}

	void Start ()
	{

		SetAllText ();

	}

	void Update ()
	{		

		if (LocalizationText.GetLanguage () != _language) {
			_language = LocalizationText.GetLanguage ();
			SetAllText ();
		}
	}


	private void SetAllText ()
	{
		gameObject.GetComponent<Text> ().text = LocalizationText.GetText (key).Replace ("#n", System.Environment.NewLine);
		Debug.Log (LocalizationText.GetText (key));
	}
}
