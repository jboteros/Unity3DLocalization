using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalizationCode : MonoBehaviour {

    public Text T1, T2, T3;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		T1.text = LocalizationText.GetText("lbl-settings");
		T2.text = LocalizationText.GetText("lbl-acept");
		T3.text = LocalizationText.GetText("lbl-cancel");
	}
}
