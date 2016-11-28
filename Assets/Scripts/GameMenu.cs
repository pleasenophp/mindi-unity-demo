using UnityEngine;
using System.Collections;
using MinDI;

public class GameMenu : ContextMonoBehaviour {

	[Injection] ICoroutineManager coroutines { get; set; }

	protected override void OnInjected ()
	{
		Debug.Log("Game menu is now onjected!");
	}

	void OnGUI() {
		GUILayout.Label ("Hello world");
		GUILayout.Label ("Coroutines manager is: "+coroutines);
	}
}
