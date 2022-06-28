using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public AudioSource sound;

	public void QuitGame()
    {
		Debug.Log("Quit!");
		Application.Quit();
    }

	public void PlayNIME()
	{
		sound.Play();
		StartCoroutine(ChangeToScene());
	}

	public IEnumerator ChangeToScene()
	{
		yield return new WaitForSeconds((float)0.25);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void ChangeNime(int sceneNumber)
	{
		SceneManager.LoadScene(sceneNumber);
	}
}
