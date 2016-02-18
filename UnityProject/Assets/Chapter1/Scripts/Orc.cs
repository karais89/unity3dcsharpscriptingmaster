using UnityEngine;
using System.Collections;

public class Orc : MonoBehaviour {
	private Transform ThisTransform = null;

	public enum OrcStates { NEUTRAL, ATTACK_MELEE, ATTACK_RANCE };

	public OrcStates CurrentState = OrcStates.NEUTRAL;

	public float OrcSpeed = 10.0f;

	public bool isFriendly = false;

	// Use this for initialization
	void Start () {
		ThisTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AttackMelee() {
		// attack
	}

	public void AttackRange() {
		// attack
	}
}
