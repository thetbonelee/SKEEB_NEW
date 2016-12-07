using UnityEngine;
using System.Collections;

public class ParticleEffects : MonoBehaviour {

	public GameObject collider;
	public bool selected = false;
	private bool started = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (selected && !started) {
			collider.GetComponent<score> ().selectedMult = true;
			StartEffect ();
		}
	}

	void StartEffect (){
		this.GetComponent<ParticleSystem> ().Play ();
		started = true;
	}
}
