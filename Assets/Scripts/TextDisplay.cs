using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Text scoreText = GetComponent<Text> ();
        scoreText.text = Trivia.currentQuestion.fact;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
