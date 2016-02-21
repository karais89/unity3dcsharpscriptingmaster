using UnityEngine;
using System.Collections;

public class ScoreSetter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameManager.Instance.HighScore = 100;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
