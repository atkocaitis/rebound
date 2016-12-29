using UnityEngine;
using System.Collections;

public class CollisionStar : MonoBehaviour {

	public int color;

	void OnTriggerEnter2D (Collider2D col) {
		if (gameObject.tag == "star" && color == Global.laserColor) {
			gameObject.GetComponent<Animation> ().Play ();
			Destroy (gameObject, 1);
		} 

		if (col.gameObject.name == "Laser(Clone)" && color != Global.laserColor) {
			col.gameObject.GetComponent<Rigidbody2D>().velocity =  new Vector2(0, 0);
			Destroy (col.gameObject, 2);
		} 
    }
}
