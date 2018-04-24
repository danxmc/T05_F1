using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Trivia : MonoBehaviour {

    LevelManager levelMngr = new LevelManager();
    GameManager gameMngr = new GameManager();

    //These arrays will hold the questions for each level
    public Questions[] level1Questions;
    public Questions[] level2Questions;
    public Questions[] level3Questions;
    //currentQuestion
    public static Questions currentQuestion;
    public static List<Questions> unansweredQuestions;

    int level = 1;
   
    string question;
    // Use this for initialization
    void Start()
    {
        SetRandomQuestion();
    }

    void Update()
    {

    }

    
    public void CheckAnswer(string input)
    {
        if (input == "true")
        {
            if (currentQuestion.isTrue) {
                levelMngr.LoadLevel("Level01");
            } else {
                gameMngr.EndGame();
            }
            
        }
        else
        {
            if (currentQuestion.isTrue)
            {
                gameMngr.EndGame();
            }
            else
            {
                levelMngr.LoadLevel("Level01");
            }
        }
    }

    private void SetRandomQuestion()
    {
        switch (level)
        {
            case 1:
                unansweredQuestions = level1Questions.ToList<Questions>();
                int randomQuestionIndex = UnityEngine.Random.Range(0, unansweredQuestions.Count);
                currentQuestion = level1Questions[randomQuestionIndex];
                break;
            case 2:
                unansweredQuestions = level2Questions.ToList<Questions>();
                int randomQuestionIndex2 = UnityEngine.Random.Range(0, unansweredQuestions.Count);
                currentQuestion = level2Questions[randomQuestionIndex2];
                break;
            case 3:
                unansweredQuestions = level2Questions.ToList<Questions>();
                int randomQuestionIndex3 = UnityEngine.Random.Range(0, unansweredQuestions.Count);
                currentQuestion = level2Questions[randomQuestionIndex3];
                break;
            default:
                Debug.LogError("I cant believe it, The ball was stolen from you");
                break;
        }
    }
}
