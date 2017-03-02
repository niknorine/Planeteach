using UnityEngine;
using System.Collections;

public class TelescopeMov : MonoBehaviour {

    float speed = 8f;
	
	// Update is called once per frame
	void Update () {
        transform.Translate (new Vector3(
            Input.GetAxis("Horizontal") * speed,
            Input.GetAxis("Vertical") * speed,
            0) * Time.deltaTime);
	
	}
}
