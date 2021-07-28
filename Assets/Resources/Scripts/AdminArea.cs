using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminArea : MonoBehaviour
{
    // Start is called before the first frame update
    public FirebaseScript dbScript;

    public Text Tries;

    public Text Dates1;
    public Text Dates2;
    public Text Dates3;
    public Text Dates4;
    public Text Dates5;
    public Text Dates6;
    public Text Dates7;
    public Text Dates8;
    public Text Dates9;
    public Text Dates10;
    void Start()
    {
        dbScript = Camera.main.GetComponent<FirebaseScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void GetAmountOfPlays()
    //{
    //    StartCoroutine(dbScript.initFirebase());
    //    int i = 0;

    //    foreach (var x in dbScript.Data)
    //    {
    //        if(x == "LogInAmount")
    //        {
    //            Debug.Log(dbScript.Data[i + 1]);
    //            Tries.text = dbScript.Data[i + 1].ToString();
    //        }
    //        i++;
    //    }
    //}

    //public void GetLogIns()
    //{
    //    Debug.Log("Button");
    //    //StartCoroutine(dbScript.initFirebase());
    //    int i = 0;

    //    for (int a = 1; a <= 11; a++)
    //    {
    //        foreach (var x in dbScript.Data)
    //        {
    //            if (x == "LogInDate" + a)
    //            {            

    //                if(a == 1)
    //                {
    //                    Dates1.text = dbScript.Data[dbScript.Data.IndexOf(x) + 1].ToString();
    //                }
    //                if (a == 2)
    //                {
    //                    Dates2.text = dbScript.Data[dbScript.Data.IndexOf(x) + 1].ToString();
    //                }
    //                if (a == 3)
    //                {
    //                    Dates3.text = dbScript.Data[dbScript.Data.IndexOf(x) + 1].ToString();
    //                }
    //                if (a == 3)
    //                {
    //                    Dates3.text = dbScript.Data[dbScript.Data.IndexOf(x) + 1].ToString();
    //                }
    //                if (a == 4)
    //                {
    //                    Dates4.text = dbScript.Data[dbScript.Data.IndexOf(x) + 1].ToString();
    //                }
    //                if (a == 5)
    //                {
    //                    Dates5.text = dbScript.Data[dbScript.Data.IndexOf(x) + 1].ToString();
    //                }
    //                if (a == 6)
    //                {
    //                    Dates6.text = dbScript.Data[dbScript.Data.IndexOf(x) + 1].ToString();
    //                }
    //                if (a == 7)
    //                {
    //                    Dates7.text = dbScript.Data[dbScript.Data.IndexOf(x) + 1].ToString();
    //                }
    //                if (a == 8)
    //                {
    //                    Dates8.text = dbScript.Data[dbScript.Data.IndexOf(x) + 1].ToString();
    //                }
    //                if (a == 9)
    //                {
    //                    Dates9.text = dbScript.Data[dbScript.Data.IndexOf(x) + 1].ToString();
    //                }
    //                if (a == 10)
    //                {
    //                    Dates10.text = dbScript.Data[dbScript.Data.IndexOf(x) + 1].ToString();
    //                }

    //            }
                
    //        }
    //    }

        

        
    //}
}
