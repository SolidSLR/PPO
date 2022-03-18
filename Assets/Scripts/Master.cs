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

                Debug.Log("URL base: "+dia.urlBase);

                Predicion predicion = dia.listaPredicions[0];

                Debug.Log("Comentario do día: "+predicion.comentario);

                Debug.Log("Título: "+predicion.titulo);

                Mapas mapas = predicion.listaMapas[0];

                Debug.Log("Franxa: "+mapas.franxa);

                Debug.Log("URL do mapa: "+url);

                break;

            }
        }
    }
}

[Serializable]
public class Dia{

    public List<Predicion> listaPredicions;

    public string urlBase;

}

[Serializable]
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

[Serializable]
public class Mapas{

    public int dia;

    public int franxa;

    public string urlMapa;
}