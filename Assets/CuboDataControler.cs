using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuboDataControler : MonoBehaviour, IAction
{
    [SerializeField] public int numStand;
    // [SerializeField] string textoTitulo;
    [SerializeField] Text uiText;
    [SerializeField] Controller controller;

    public void Activate()
    {
        uiText.text = controller.data.stand[numStand].title;
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
