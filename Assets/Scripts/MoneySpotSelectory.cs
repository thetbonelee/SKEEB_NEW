using UnityEngine;
using System.Collections;

public class MoneySpotSelectory : MonoBehaviour {

	public GameObject[] cylinders;
	// Use this for initialization
	void Start () {
		cylinders = GameObject.FindGameObjectsWithTag ("Cylinder");
		int random = Random.Range (0, cylinders.Length);
		Debug.Log (cylinders[random]);
		cylinders [random].GetComponent<ParticleEffects> ().selected = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
