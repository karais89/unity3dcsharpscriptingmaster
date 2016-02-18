using UnityEngine;
using System.Collections;

public class MyScriptFile : MonoBehaviour {
	public GameObject[] MyObjects;
	private int Score = 0;
	// Use this for initialization
	void Start () {
		MyObjects = new GameObject[3];
		MyObjects[0] = Camera.main.gameObject;
		MyObjects[1] = GameObject.Find("Cube");
		MyObjects[2] = GameObject.Find("Cylinder");

		// foreach
		foreach(GameObject obj in MyObjects) {
			DestroyImmediate(obj);
		}

		// for
		for(int i =MyObjects.Length - 1; i >- 0; i--) {
			DestroyImmediate(MyObjects[i]);
		}

		// while
		int NumberOfMessages = 0;

		while(NumberOfMessages < 5) {
			Debug.Log("This is Message: " + NumberOfMessages.ToString());
			++NumberOfMessages;
		}

		// func
		UpdateScore(5, false);
		UpdateScore(10, false);
		int CurrentScore = UpdateScore(15, false);

		UpdateScore(CurrentScore);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int UpdateScore(int AmountToAdd, bool PrintToConsole = true) {
		Score += AmountToAdd;
		if(PrintToConsole) { Debug.Log("Score is: " + Score.ToString()); }
		return Score;
	}
}
