using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AdminLock : MonoBehaviour
{
    public InputField Password;
    string password;

    bool check;

    public FirebaseScript dbScript;
    // Start is called before the first frame update
    void Start()
    {
        dbScript = Camera.main.GetComponent<FirebaseScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(dbScript.processComplete == true)
        //{
        //    foreach (var x in dbScript.Data)
        //    {
        //        if (x == "Password")
        //        {
        //            Debug.Log(dbScript.Data[dbScript.Data.IndexOf(x) + 1]);
        //            if (dbScript.Data[dbScript.Data.IndexOf(x) + 1] == password)
        //            {
        //                Debug.Log("Access Granted");
        //                dbScript.processComplete = false;
        //                SceneManager.LoadScene("AdminRoom");
        //            }
        //            if (dbScript.Data[dbScript.Data.IndexOf(x) + 1] == password)
        //            {
        //                Debug.Log("Access Denied");
        //                dbScript.processComplete = false;
        //            }
        //        }
        //    }

               

        }
    }

//    public void Submit()
//    { 
        
//        password = Password.text;

//        StartCoroutine(dbScript.getAllDataFromFirebase());     
        
//    }
//}
