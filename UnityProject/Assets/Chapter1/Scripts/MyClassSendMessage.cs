using UnityEngine;
using System.Collections;

public class MyClassSendMessage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SendMessage("MyFunction", SendMessageOptions.DontRequireReceiver);
	}

	void MyFunction() {
		Debug.Log("Hello");
	}
}
