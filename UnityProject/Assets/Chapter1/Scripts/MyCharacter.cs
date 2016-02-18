using UnityEngine;
using System.Collections;

public class MyCharacter : MonoBehaviour {
	public string CharName = "";
	public int Health = 100;
	public int Strength = 100;
	public float Speed = 10.0f;
	public bool isAwake = true;

	public virtual void SayGreeting() {
		Debug.Log("Hello, my friend");
	}
}

public class ManCharacter : MyCharacter {
	public override void SayGreeting () {
		Debug.Log("Hello, I`m a man");
	}
}

public class WomanCharacter : MyCharacter {
	public override void SayGreeting () {
		Debug.Log("Hello, I`m a woman");
	}
}

public class OrcCharacter : MyCharacter {
	public override void SayGreeting () {
		Debug.Log("Heelo, I`m an Orc");
	}
}