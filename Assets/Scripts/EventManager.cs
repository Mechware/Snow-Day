using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {


    public static EventManager Instance;

    public static Action SnowballThrown;

    private void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FireSnowballThrown()
    {
        if (SnowballThrown != null) SnowballThrown();
    }
}
