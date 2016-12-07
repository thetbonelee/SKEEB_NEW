using UnityEngine;
using System.Collections;

public class cameraOrbit : MonoBehaviour {

    public GameObject pivot;
    public float speed;
    private int neg = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Orbit();
	}
    void Orbit()
    {
        if(transform.localPosition.x < -9 || transform.localPosition.x > 5)
        {
            neg *= -1;
        }

        transform.RotateAround(pivot.transform.position, Vector3.up, speed*neg);
    }
}
