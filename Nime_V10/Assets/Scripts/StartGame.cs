using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class StartGame : MonoBehaviour
{
	public void PlayGame()
	{
		string name = EventSystem.current.currentSelectedGameObject.name;
		string number = name.Substring("Button".Length);
		int sceneNumber = 1 + Int32.Parse(number);

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + sceneNumber);
	}

	public void MainMenu()
    {
		SceneManager.LoadScene(0);
	}
}
