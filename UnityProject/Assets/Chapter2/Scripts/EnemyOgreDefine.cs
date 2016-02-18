using UnityEngine;
using System.Collections;

public class EnemyOgreDefine : MonoBehaviour {

	// Use this for initialization
	void Start () {
#if SHOW_DEBUG_MESSAGES
		Debug.Log("Pos : " + transform.position.ToString());
#endif
		Debug.Log("Start function called");
	}
}
