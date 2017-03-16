using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBall : MonoBehaviour {
	public GameObject prefab;
	public Vector3 position;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space)) {
			CreateBall ();
		}
	}

	void CreateBall () {
		GameObject ball = Instantiate (prefab, position, Quaternion.identity, gameObject.transform);

		// Set random Color
		Material mat = ball.GetComponent<MeshRenderer> ().materials [0];
		Color color = Random.ColorHSV();

		mat.color = color;
	}
}
