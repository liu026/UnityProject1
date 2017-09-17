using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour {

	public void LoadScene(string game1)
	{
		Application.LoadLevel (game1);
	}
}
