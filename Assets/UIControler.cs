using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControler : MonoBehaviour, IAction
{
    [SerializeField] GameObject panel;

    [SerializeField] CursorControler cursorControler;

    // Start is called before the first frame update
    void Start()
    {
        panel.transform.localScale = new Vector3(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate()
    {
        LeanTween.scale(panel, new Vector3(1, 1, 1), 0.5F);
        //panel.transform.localScale = new Vector3(1, 1, 1);
        cursorControler.ActiveCursor();
    }

    public void Desactivate()
    {
        LeanTween.scale(panel, new Vector3(0, 0, 0), 0.5F);
        //panel.transform.localScale = new Vector3(0, 0, 0);
        cursorControler.DesactiveCursor();
    }
}
