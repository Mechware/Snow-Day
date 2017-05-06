using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballPile : MonoBehaviour {

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


    void OnTriggerEnter(Collider other) {
        print("Inside");
        if(other.CompareTag("Player")) {
            print("player inside");
            other.GetComponentInChildren<ThrowSnowball>().cooldown = other.GetComponentInChildren<ThrowSnowball>().pileCooldown;
        }
    }
    /*
    void OnTriggerStay(Collider other) {
        print("stay");
        if (other.CompareTag("Player")) {
            print("player inside");
            other.GetComponentInChildren<ThrowSnowball>().cooldown = other.GetComponentInChildren<ThrowSnowball>().pileCooldown;
        }
        
    }
    */
    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            other.GetComponentInChildren<ThrowSnowball>().cooldown = other.GetComponentInChildren<ThrowSnowball>().normalCooldown;
        }
    }
}
