using UnityEngine;
using System.Collections;

public class CollisionReflector : MonoBehaviour {

	public int color;
	private string colorName;

	void OnCollisionEnter2D (Collision2D col) {

		switch (color) {
		case 1:
			colorName = "red";
			break;
		case 2:
			colorName = "blue";
			break;
		case 3:
			colorName = "yello";
			break;
		}

		if(col.gameObject.name == "Laser(Clone)")
		{
			GameObject trail = Instantiate (GameObject.Find(colorName)) as GameObject;

			trail.transform.SetParent (col.transform, false);
			trail.transform.position = col.transform.position;

			Global.laserColor = color;
        }

    }
		
}
