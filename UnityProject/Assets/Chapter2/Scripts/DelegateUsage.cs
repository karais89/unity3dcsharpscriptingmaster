using UnityEngine;
using System.Collections;

public class DelegateUsage : MonoBehaviour 
{
	public delegate void EventHandler(int Paraml, int Param2);

	public EventHandler[] EH = new EventHandler[10];

	void Awake() {
		EH[0] = HandleMyEvent;
	}

	void Start() {
		foreach(EventHandler e in EH) {
			if(e != null) {
				e(0, 0);
			}
		}
	}

	void HandleMyEvent(int Param1, int Param2) {
		Debug.Log("Event Called");
	}
}
