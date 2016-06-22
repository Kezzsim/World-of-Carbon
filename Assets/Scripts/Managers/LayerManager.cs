﻿using UnityEngine;
using System.Collections;

public class LayerManager : MonoBehaviour {

    public bool DebugControls = true;
    public uint lnum = 0;
    public GameObject[] layers = new GameObject[3];
    private GameObject currentLayer;

	// Use this for initialization
	void Start () {
        currentLayer = layers[0];

        currentLayer.SetActive(true);
        foreach (Transform child in currentLayer.transform)
        {
            child.gameObject.SetActive(true);
        }

        for(int i=1; i<layers.Length; i++)
        {
            layers[i].SetActive(false);
            foreach (Transform child in layers[i].transform)
            {
                child.gameObject.SetActive(false);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (DebugControls)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                SwitchLayer(0);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                SwitchLayer(1);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                SwitchLayer(2);
            }
        }
	}

    // Switches the active layer.
    public void SwitchLayer(uint nextLayer)
    {
        currentLayer.SetActive(false);
        foreach (Transform child in currentLayer.transform)
        {
            child.gameObject.SetActive(false);
        }

        currentLayer = layers[nextLayer];
        currentLayer.SetActive(true);
        foreach (Transform child in currentLayer.transform)
        {
            child.gameObject.SetActive(true);
        }
        

        currentLayer = layers[nextLayer];

        
    }
}
