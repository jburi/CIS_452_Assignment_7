using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public bool checkpointHit;
	public bool finishHit;

	private void Update()
	{
		if (checkpointHit == true && finishHit == true)
		{
			SceneManager.LoadScene("Win");
		}
	}
}
