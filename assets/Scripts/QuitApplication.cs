using UnityEngine;
using System.Collections;

public class QuitApplication : MonoBehaviour {

	public GameObject quitButton;


	public void Quit()
	{
		quitButton.GetComponent<AudioSource> ().Play ();
		Invoke ("closeApp", 0.08F);
	}

	private void closeApp() {
		//If we are running in a standalone build of the game
		#if UNITY_STANDALONE
		//Quit the application
		Application.Quit();
		#endif

		//If we are running in the editor
		#if UNITY_EDITOR
		//Stop playing the scene
		UnityEditor.EditorApplication.isPlaying = false;
		#endif
	}
}
