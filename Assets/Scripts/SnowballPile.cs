using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballText : MonoBehaviour {
    public GameObject target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targetPostition = new Vector3(target.transform.position.x,
                                        this.transform.position.y,
                                        target.transform.position.z);
        this.transform.LookAt(targetPostition);
    }
}
