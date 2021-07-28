using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public FirebaseScript dbScript;

    //What should be played in the current instance
    string currentPlayStyle = "";
    void Start()
    {
        dbScript = Camera.main.GetComponent<FirebaseScript>();
    }

    public void StartGame()
    {
        ////User Starts To Play The Game
        //Button Clicked
        Debug.Log("Starter");

        //Getting The Data
        StartCoroutine(dbScript.getAllDataFromFirebase());
        //Finding What Should Be Shown (Infographic / GameLearning)
        int GetPlayType = dbScript.Data.IndexOf("PlayType");
        Debug.Log(GetPlayType);
        Debug.Log(dbScript.Data[GetPlayType + 1]);

        //SceneManager.LoadScene("LoadBar");
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
