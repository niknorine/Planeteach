using UnityEngine;
using System.Collections;

public class Orbit : MonoBehaviour {

    public GameObject planet;
    public GameObject myPlanet;
    public float speed;
    public float mySpeed;
	public GameObject earth;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        


        OrbitAround();
	
	}

    void OrbitAround() 
    {
        transform.RotateAround(myPlanet.transform.position, Vector3.up, mySpeed * Time.deltaTime);

        transform.RotateAround(planet.transform.position, Vector3.up, speed * Time.deltaTime);
    }

	void OnMouseDown()
	{
		earth.gameObject.setActive (true);
	}
}
