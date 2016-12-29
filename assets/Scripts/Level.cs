using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {

	public GameObject cannon; 
	public GameObject target; 
	public GameObject position_1; 
	public GameObject position_2;
	public GameObject position_3;
	public GameObject position_4;
	public GameObject position_5;
	public GameObject position_6;
	public GameObject panel;
	public GameObject laser;
	public GameObject barrel;
    public GameObject moveBtn;
    public GameObject rotateBtn;
    public Vector2 _direction;
	private int speed = Global.speed;

    // Unlock new level and load level select
    public void UnlockLevel (int level) {
		if (PlayerPrefs.GetInt ("OpenLevels") <= level) {
			PlayerPrefs.SetInt ("OpenLevels", level);
		}

		SceneManager.LoadScene (1);
	}

	public void MoveCanont (int  position) {
		switch (position) {
		case 1:
			target = position_1;
			break;
		case 2:
			target = position_2;
			break;
		case 3:
			target = position_3;
			break;
		case 4:
			target = position_4;
			break;
		case 5:
			target = position_5;
			break;
		case 6:
			target = position_6;
			break;
		}
	}

	void Update() {
		// Move cannon
		float speed = 0.08F;
		cannon.transform.position = Vector3.Lerp (cannon.transform.position, target.transform.position, speed);
	}		

	public void FireLaser () {
		if (GameObject.FindGameObjectWithTag ("laser") == null) {
			GameObject laserBlast = Instantiate (laser) as GameObject;

			laserBlast.transform.SetParent (panel.transform, false);
			laserBlast.transform.position = barrel.transform.position;
			laserBlast.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, speed);

			cannon.GetComponent<AudioSource> ().Play ();

			Global.laserColor = 1;

			Destroy (laserBlast, 10);
		}
	}

    public void EnableMoving()
    {
        moveBtn.SetActive(false);
        rotateBtn.SetActive(true);
    }

    public void EnableRotating()
    {
        moveBtn.SetActive(true);
        rotateBtn.SetActive(false);
    }
}
