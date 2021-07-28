using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public FirebaseScript dbScript;


    public Text m_Text;
    public Button m_Button;
    public GameObject Loader;

    Vector3 limit = new Vector3(10f, 0.3f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        dbScript = Camera.main.GetComponent<FirebaseScript>();
        StartCoroutine(dbScript.downloadAndSaveImage());
        StartCoroutine(LoadScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    IEnumerator LoadScene()
    {
        yield return null;

        //Begin to load the Scene you specify
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("battleships");
        //Don't let the Scene activate until you allow it to
        asyncOperation.allowSceneActivation = false;
        Debug.Log("Pro :" + asyncOperation.progress);
        //When the load is still in progress, output the Text and progress bar
        while (!asyncOperation.isDone)
        {
            //Output the current progress
            m_Text.text = "Loading progress: " + (asyncOperation.progress * 100) + "%";

            // Check if the load has finished
            if (asyncOperation.progress >= 0.9f)
            {
                
                m_Button.gameObject.SetActive(true);

                //Change the Text to show the Scene is ready
                m_Text.text = "Game Ready";
                //Wait to you press the space key to activate the Scene
                if (Loader.gameObject.transform.localScale != limit)
                {
                    Loader.gameObject.transform.localScale += new Vector3(0.1f, 0f, 0);
                }
                
                
            }

            
            yield return null;
        }
        
    }

}
