using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour {

	private int levelToLoad;
	public Animator animColorFade; 	
	public AnimationClip fadeColorAnimationClip;
	public GameObject levelsPanel;
	public GameObject levelButton; 
	public GameObject levelList; 

	void Start()
	{
		// Generate levels buttons list
		for (int i = 0; i < getOpenLevels(); i++) {
			GameObject button = Instantiate (levelButton) as GameObject;
			int level = i + 1;

			button.transform.SetParent (levelList.transform, false);
			button.GetComponent <Button> ().onClick.AddListener (() => LoadLevel(level + 1));
			button.transform.Find("text").GetComponent <Text> ().text = level.ToString();
			button.transform.Find("text_shadow").GetComponent <Text> ().text = level.ToString();

		}
	}

	// Get open levels count
	public int getOpenLevels() {
		if (PlayerPrefs.GetInt ("OpenLevels") == 0) {
			return 1;
		} else {
			return PlayerPrefs.GetInt ("OpenLevels");
		};
	}

	// Load level
	public void LoadLevel (int level) {
		levelsPanel.GetComponent<AudioSource> ().Play ();

		levelToLoad = level;

		Invoke ("LoadDelayed", fadeColorAnimationClip.length * .5f);

		animColorFade.SetTrigger ("fade");
	}

	public void LoadDelayed()
	{
		//Load the selected scene
		SceneManager.LoadScene (levelToLoad);

		//Hide panel
		levelsPanel.SetActive (false);
	}

	// Delete user prefs
	public void DeletePrefs () {
		PlayerPrefs.DeleteAll();
	}
		
}
