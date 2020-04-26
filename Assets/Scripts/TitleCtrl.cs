using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleCtrl : MonoBehaviour {
    	// Use this for initialization
	void Start () {
		
	}
	public void OpenFacebook(){
		Application.OpenURL("https://www.facebook.com/TryHarderOkay");
	}

}
