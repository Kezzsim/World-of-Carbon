﻿
using UnityEngine;
using System.Collections;

public class ColorTracker : MonoBehaviour {

    public static ColorTracker _instance = null;
	
    void Start()
    {

    }
    void Awake()
    {
            if(_instance == null)
            {
                _instance = GameObject.FindObjectOfType<ColorTracker>();

                if(_instance == null)
                {
                    GameObject container = new GameObject("ColorTracker");
                    _instance = container.AddComponent<ColorTracker>();

                }
            }
            Debug.Log(this.GetInstanceID());
         
    }

    private static string color = "BW";


	

    void Update()
    {

    }
    public static void SetMolColor(string t_color)
    {
        color = t_color;
    }

    public static void ApplyColor(FormManager fMan)
    {
        fMan.color = color;
    }
}
