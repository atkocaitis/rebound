using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D col) {

		if(col.gameObject.name == "UFO")
		{
			Debug.Log(GameObject.FindGameObjectWithTag("star"));
			if (GameObject.FindGameObjectWithTag ("star") == null) {
				col.gameObject.GetComponent<AudioSource> ().Play ();
				col.gameObject.GetComponent<Animation> ().Play ();
				Destroy(col.gameObject, 1);
			}
		}

		if(col.gameObject.name == "Laser(Clone)")
		{
            col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Destroy(col.gameObject, 1);
        }

        if (col.gameObject.transform.parent.gameObject.tag == "OneTimeReflector")
        {
            Destroy(col.gameObject.transform.parent.gameObject);
        }

    }
		
}
