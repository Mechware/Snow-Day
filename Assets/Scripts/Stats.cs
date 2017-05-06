using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {


    public static int numberOfSnowballsThrown = 0;

	// Use this for initialization
	void Start () {
        EventManager.SnowballThrown += RecordSnowballThrown;
	}
	
    void RecordSnowballThrown()
    {
        numberOfSnowballsThrown++;
        print("SNow ball thrown, total number thrown: " + numberOfSnowballsThrown);
    }

	// Update is called once per frame
	void Update () {
		
	}


}
