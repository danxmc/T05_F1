using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour {

    public string level;



    // Method is triggered when object touches the collider GO
    //Then loads the screen
    public void OnTriggerEnter(Collider collider)
    {
        LevelManager levelMngr = new LevelManager();
        levelMngr.LoadLevel(level);
    }
}
