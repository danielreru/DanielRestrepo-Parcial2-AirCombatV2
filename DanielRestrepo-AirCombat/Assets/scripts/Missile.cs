using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		this.transform.Translate(0.0f, 0.0f, 38.2f * Time.deltaTime);
	}

	void OnCollisionEnter(Collision collision){

		if (collision.collider.gameObject.tag == "MarsAlien") {

			GameObject Marsexplosion = GameObject.Instantiate (Resources.Load ("prefab/Marsexplosion") as GameObject);


				Marsexplosion.transform.position = collision.collider.gameObject.transform.position;

			Destroy (collision.collider.gameObject);

			Destroy (this.gameObject);
		}

		if (collision.collider.gameObject.tag == "JupiterAlien") {

			GameObject JupiterExplosion = GameObject.Instantiate (Resources.Load ("prefab/JupiterExplosion") as GameObject);


				JupiterExplosion.transform.position = collision.collider.gameObject.transform.position;
		
			Destroy (collision.collider.gameObject);

			Destroy (this.gameObject);
		}
		if (collision.collider.gameObject.tag == "ally") {


			GameObject son = collision.collider.gameObject.transform.Find ("luzverde").gameObject;


			son.gameObject.GetComponent<Light> ().color = new Color (0, 0, 1);
		
			Destroy (this.gameObject);
		
		}
	
	}
}