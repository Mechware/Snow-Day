using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowSnowball : MonoBehaviour {
    public GameObject snowball;
    public float velocity = 10;
    Vector3 playerVelocity;
    public float cooldown = 1;
    bool onCooldown = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            print("Throw");
            print(onCooldown);
            Snowball();
        }
    }

    void Snowball() {
        if (!onCooldown) {
            Vector3 lookingAt = (Input.mousePosition);
            GameObject clone;
            playerVelocity = GetComponentInParent<CharacterController>().velocity;

            clone = Instantiate(snowball, transform.position + transform.forward, transform.rotation) as GameObject;
            clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * velocity) + playerVelocity;
            onCooldown = true;
            EventManager.Instance.FireSnowballThrown();
            StartCoroutine(coolingDown());

        } else { return; }

    }
    IEnumerator coolingDown() {
        yield return new WaitForSeconds(cooldown);
        onCooldown = false;
    }
}
