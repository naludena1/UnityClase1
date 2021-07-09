using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class CuboDataControler : MonoBehaviour, IAction
{
    [SerializeField] public int numStand;
    // [SerializeField] string textoTitulo;
    [SerializeField] Text uiText;
    [SerializeField] Controller controller;
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] GameObject btnVideo;

    public void Activate()
    {
        uiText.text = controller.data.stand[numStand].title;

        if (!controller.data.stand[numStand].video.Equals(""))
        {
            btnVideo.SetActive(true);
            videoPlayer.url = controller.data.stand[numStand].video;
        }
        else{
            btnVideo.SetActive(false);

        }

        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
