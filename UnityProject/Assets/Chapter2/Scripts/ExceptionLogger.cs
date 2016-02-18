using UnityEngine;
using System.Collections;
using System.IO;

public class ExceptionLogger : MonoBehaviour {

	private System.IO.StreamWriter SW;

	public string LogFileName = "log.txt";

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this.gameObject);

		SW = new System.IO.StreamWriter(Application.persistentDataPath + "/" + LogFileName);
		Debug.Log(Application.persistentDataPath + "/" + LogFileName);
	}

	void OnEnable() {
		Application.RegisterLogCallback(HandleLog);
	}

	void OnDisable() {
		Application.RegisterLogCallback(null);
	}

	void HandleLog(string logSring, string stackTrace, LogType type) {
		if(type == LogType.Exception || type == LogType.Error) {
			SW.WriteLine("Logged at: " + System.DateTime.Now.ToString()
			             + " - Log Desc: " + logSring
			             + " - Trace : " + stackTrace
			             + " - type : " + type.ToString());
		}
	}

	void OnDestroy() {
		SW.Close();
	}
}
