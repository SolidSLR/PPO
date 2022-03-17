using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class Master : MonoBehaviour
{

    public Dia dia;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetRequest("https://servizos.meteogalicia.gal/mgrss/predicion/jsonCPrazo.action?dia=0&request_locale=gl"));
    }

    public IEnumerator GetRequest(string url){

        using(UnityWebRequest peticion = UnityWebRequest.Get(url)){

            yield return peticion.SendWebRequest();

            switch(peticion.result){

                case UnityWebRequest.Result.Success:

                Debug.Log("Debería salir el texto de las cosas: "+peticion.downloadHandler.text);

                dia = JsonUtility.FromJson<Dia>(peticion.downloadHandler.text);

                Debug.Log("Debería indicar que hay un objeto: "+dia);

                break;

            }
        }
    }
}

public class Dia{

    public List<Predicion> listaPredicions;

    public string urlBase;

}

public class Predicion{

    public string comentario;

    public string comentarioEsp;

    public string dataActualizacion;

    public string dataPredicion;

    public int dia;

    public List<Mapas> listaMapas; 

    public int tendMax;

    public int tendMin;

    public string titulo;   

}

public class Mapas{

    public int dia;

    public int franxa;

    public string urlMapa;
}