using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;
	public Credits credits;
	public GameObject gameOverPanel;
    public Text gameOverText;
    public float restartDelay = 1f;
	public GameObject completeLevelUI;

	public void CompleteLevel()
	{
		completeLevelUI.SetActive (true);
	}

	public void EndGame()
	{

		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			credits.run();
			gameOverPanel.SetActive(true);
			gameOverText.text="Game Over!";
		    Invoke ("Restart", restartDelay);
		}


	}

	void Restart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

}
