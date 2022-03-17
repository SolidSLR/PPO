using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
// UnityWebRequest.Get example

// Access a website and use UnityWebRequest.Get to download a page.
// Also try to download a non-existing page. Display the error.

public class Old_Trivia_Master : MonoBehaviour
{

    public Trivia trivia;

    void Start()
    {
        StartCoroutine(GetRequest("https://opentdb.com/api.php?amount=10&category=15"));

    }

    IEnumerator GetRequest(string uri)
    {
        
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();



            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    //Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);

                    trivia = JsonUtility.FromJson<Trivia>(webRequest.downloadHandler.text);

                    //trivia.results = JsonUtility.FromJson<Questions>();

                    //Debug.Log(trivia.response_code+" "+trivia.results[0].category);

                    foreach (Questions item in trivia.results){

                        Debug.Log("Categoría: "+item.category);
                        Debug.Log("Tipo: "+item.type);
                        Debug.Log("Dificultad: "+item.dificulty);
                        Debug.Log("Pregunta: "+item.question);
                        Debug.Log("Respuesta correcta: "+item.correct_answer);
                        
                        for(int i = 0; i < item.incorrect_answers.Count; i++){

                            Debug.Log("Respuesta incorrecta "+(i+1)+": "+item.incorrect_answers[i]);

                        }
                    }
                    break;
            }
        }
    }
}

[Serializable]
public class Trivia{

    public int response_code;
    public List<Questions> results;

}

[Serializable]
public class Questions{

    public string category;

    public string type;

    public string dificulty;

    public string question;

    public string correct_answer;

    public List<string> incorrect_answers;

}