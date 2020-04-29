using UnityEngine;

public class OverTrigger : MonoBehaviour {

	public GameManager gameManager;

	void OnTriggerEnter()
	{

        Debug.Log("GAME");
		gameManager.EndGame ();
	}

}
