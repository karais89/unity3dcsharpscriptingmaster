using UnityEngine;
using System.Collections;

public class Database : MonoBehaviour {

	public int MyNumber {
		get {
			return iMyNumber;
		}
		set {
			if(value >= 1 && value <= 10) {
				iMyNumber = value;

				// Event call
				NumberChanged();
			}
		}
	}

	private int iMyNumber;

	// Use this for initialization
	void Start () {

		MyNumber = 11;

		MyNumber = 7;
	}

	void NumberChanged() {
		Debug.Log("Variable iMyNumber changed to : " + iMyNumber.ToString());
	}
}
