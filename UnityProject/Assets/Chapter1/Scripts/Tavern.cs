using UnityEngine;
using System.Collections;

public class Tavern : MonoBehaviour {

	public MyCharacter[] Characters = null;

	// Use this for initialization
	void Start () {
		Characters = new MyCharacter[5];

		Characters[0] = new ManCharacter();
		Characters[1] = new WomanCharacter();
		Characters[2] = new OrcCharacter();
		Characters[3] = new ManCharacter();
		Characters[4] = new WomanCharacter();

		EnterTavern();
	}

	void EnterTavern ()
	{
		foreach(MyCharacter C in Characters) {
			C.SayGreeting();
		}
	}
}
