using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Trivia : MonoBehaviour {

    public Text questionText;

    //These arrays will hold the questions for each level
    public string[] level1Questions;
    //currentQuestion
    private  string currentQuestion;


    int level = 1;

    private bool isTrue;
    private bool answer;

    string question;
    // Use this for initialization
    void Start()
    {
        SetRandomQuestion();
    }


    
    public void TrueAnswer()
    {
        Debug.Log("Correct");
        answer = true;
        CheckAnswer();
    }

    public void FalseAnswer()
    {
        Debug.Log("Incorrect");
        answer = false;
        CheckAnswer();
    }

    void CheckAnswer()
    {
        if (answer == isTrue)
        {
            GameObject.Find("LevelManager").GetComponent<LevelManager>().LoadLevel("Level01");
        }
        else
        {
            GameObject.Find("LevelManager").GetComponent<LevelManager>().LoadLevel("Menu");
        }
    }

    private void SetRandomQuestion()
    {
        int randomQuestionIndex = UnityEngine.Random.Range(0, level1Questions.Length);
        if (randomQuestionIndex % 2 == 0)
        {
            isTrue = true;
        }
        else
        {
            isTrue = false;
        }
            currentQuestion = level1Questions[randomQuestionIndex];
            questionText.text = currentQuestion;
    }
}
