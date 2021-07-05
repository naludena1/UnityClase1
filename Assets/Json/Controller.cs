    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;


public class Controller : MonoBehaviour
{
    public JsonClass data = new JsonClass();


    void Awake()
    {
        LoadLocal();
        //StartCoroutine(GetJson("https://us-central1-fifty-year-utpl.cloudfunctions.net/hitos"));
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(data.stand[0].title);
        Debug.Log(data.stand[1].title);
    }

    //Utiliza un Json local llamado Data
    public void LoadLocal()
    {
        LoadJson(Resources.Load<TextAsset>("Datos").ToString());
    }

    //Utiliza un Json enviado desde Angular
    public void LoadJson(string jsString)
    {

        data = JsonConvert.DeserializeObject<JsonClass>(jsString);
        
    }

    //Utiliza un Json que lo obtiene mediante una peticion a un url
    IEnumerator GetJson(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                // Debug.Log(webRequest.downloadHandler.text);
                LoadJson(webRequest.downloadHandler.text);
            }
        }
    }
}
