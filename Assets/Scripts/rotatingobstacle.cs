using UnityEngine;
using System.Collections;

public class rotatingobstacle : MonoBehaviour {
	public float speed = 25f;
	public Vector3 directions;

	void Update () {
		transform.Rotate(Time.deltaTime * speed * directions);
	}
}
