using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;				//	We need this in order to handle the Text object

public class ScoreKeeper : MonoBehaviour {
    public Transform player;
    public static int score = 0;			//	Player's score
	private Text scoreText;					//	So we can modify the score's Text

	// Use this for initialization
	void Start () {
		//	We dynamicaly point to the Text object in our UI.
		scoreText = GetComponent<Text>();
		scoreText.text = score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = (player.position.z + score).ToString("0,0");
    }

	public static void Reset() {
		score = 0;
	}
}
