using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DataController : MonoBehaviour
{
    [SerializeField] GameObject standObj;
    [SerializeField] Controller controller;
    // [SerializeField] GameObject img;
   



    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform stand in standObj.transform)
        {
            // Debug.Log(stand.GetChild(0).gameObject);
            LoadStandData(stand.GetChild(0).gameObject, stand.GetChild(0).gameObject.GetComponent<CuboDataControler>().numStand);
        }
                                                                                    
                                                                                                                                                                                                        
    }

    // Update is called once per frame
    void Update(){                                                                                               
                                                                                                                            
    }

    public void LoadStandData(GameObject imagen,int numStand) {

        // Debug.Log(controller.data.stand[numStand].image);

        StartCoroutine(LoadImg(imagen, controller.data.stand[numStand].image));

        
    }


    IEnumerator LoadImg(GameObject imagen, string urlImg)
    {
        UnityWebRequest imgRequest = UnityWebRequestTexture.GetTexture(urlImg);
        yield return imgRequest.SendWebRequest();
        if (imgRequest.isNetworkError || imgRequest.isHttpError)
        {
            Debug.LogError(imgRequest.error);
            yield break;
        }
        else
        {
            Texture2D dowloadImage = DownloadHandlerTexture.GetContent(imgRequest) as Texture2D;
            imagen.GetComponent<Renderer>().material.mainTexture = dowloadImage; //Imagen 3D
            
        }
    }
 }
    
