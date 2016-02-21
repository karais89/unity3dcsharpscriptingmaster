using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager Instance {
		get {
			return instance;
		}
	}

	private static GameManager instance = null;

	public int HighScore = 0;

	public bool IsPaused = false;
	public bool InputAllowed = true;

	void Awake() {
		if(instance) {
			DestroyImmediate(gameObject);
			return;
		}

		instance = this;
		
		DontDestroyOnLoad(gameObject);
	
		Debug.Log("Awake");
	}


	// Use this for initialization
	void Start () {
		Debug.Log("start");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
