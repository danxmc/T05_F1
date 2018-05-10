using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Trivia : MonoBehaviour {
    public TextAsset textFile;
    public Text questionText;

    //These arrays will hold the questions for each level
    public List <String> levelQuestions;
    //currentQuestion
    private  string currentQuestion;

    private bool isTrue;
    private bool answer;

    string question;
    // Use this for initialization
    void Start()
    {
        ProcessTextFile();
        SetRandomQuestion();
    }

    void ProcessTextFile()
    {
        /* split the text file by newline characters */
        string[] lineArray = textFile.text.Split("\n"[0]);
        /* loop over each line in the file */
        foreach (string thisLine in lineArray)
        {
            /* split each line by | */
            /* load question and answer to arrays */
            levelQuestions.Add(thisLine);
        }
        Debug.Log("I found " + levelQuestions.Count + " questions ");
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
            GameObject.Find("LevelManager").GetComponent<LevelManager>().LoadLevel("Credits");
        }
    }

    private void SetRandomQuestion()
    {
        int randomQuestionIndex = UnityEngine.Random.Range(0, levelQuestions.Count);
        if (randomQuestionIndex % 2 == 0)
        {
            isTrue = true;
        }
        else
        {
            isTrue = false;
        }
            currentQuestion = levelQuestions[randomQuestionIndex];
            questionText.text = currentQuestion;
    }
}
