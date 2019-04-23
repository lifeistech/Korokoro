using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorGenerator : MonoBehaviour {

	bool floor_gene = true;
	float floor_posX = 0;
	float floor_posZ = 0;
	Vector3 new_floorPos;
	public GameObject floor;
	// Use this for initialization
	void Start () {
		floor_posX = transform.position.x + Random.Range (-0.7f, 0.7f);
		floor_posZ = transform.position.z + 1;
		new_floorPos = new Vector3(floor_posX, 0, floor_posZ);
	}

	// Update is called once per frame
	void Update () {

	}

	public void OnCollisionEnter (Collision other) {
		if (other.gameObject.CompareTag ("Player") && floor_gene) {
			Instantiate (floor, new_floorPos, transform.rotation);
			floor_gene = false;
		}
		else
		{
			return;
		}
	}
	public void OnCollisionExit (Collision other) {
		if (other.gameObject.CompareTag ("Player")) {
			Destroy (this.gameObject);
		}else
		{
			return;
		}
	}
}