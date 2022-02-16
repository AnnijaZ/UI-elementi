using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaParadisana : MonoBehaviour {
	//Uzglabās tekstu, kurš paņemts no input lauka
	public string teksts;
	//Lauks no, kura es teksu paņemšu
	public GameObject ievadesLauks;
	//Teksta objekts, kur attēlot mainīgā teksts saturu
	public GameObject tekstaAttelosanasLauks;

	public void darbibasArTekstu(){
		teksts = ievadesLauks.GetComponent<Text> ().text;
		tekstaAttelosanasLauks.GetComponent<Text> ().text = "Sveiki " + teksts.ToUpper () + "!";
	}
}
