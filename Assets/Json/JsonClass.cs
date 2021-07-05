using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SerializeField]
public class JsonClass
{
    public Stand[] stand;
}


[SerializeField]
public class Stand
{
    public string title;
    public string description;
    public string image;
    public string video;
}

