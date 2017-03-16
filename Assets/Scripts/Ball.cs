using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public float lifetime;
	public Color color;

	void Awake () {
		SetRandomColor ();
		SetLifetime ();
	}
	
	void SetLifetime () {
		if (lifetime > 0.0f) {
			Destroy(gameObject, lifetime);
		} 
	}

	void SetRandomColor () {
		// Set random Color
		Material mat = GetComponent<MeshRenderer> ().materials [0];
		Color color = Random.ColorHSV();

		mat.color = color;
	}
}
