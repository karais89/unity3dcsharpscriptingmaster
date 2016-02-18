using UnityEngine;
using System.Collections;

public class MyNewScriptSwitch : MonoBehaviour {
	public enum EnemyState { CHASE, FLEE, FIGHT, HIDE};
	public EnemyState ActiveState = EnemyState.CHASE;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		switch (ActiveState) {
		case EnemyState.FIGHT:
		{
			Debug.Log("Entered fight state");
		}
			break;

		case EnemyState.FLEE:
		case EnemyState.HIDE:
		{
			Debug.Log("Entered file or hide state");
		}
			break;

		default:
		{
			Debug.Log("Entered chase state");
		}
			break;
		}	
	}
}
