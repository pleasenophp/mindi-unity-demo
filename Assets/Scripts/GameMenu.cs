using UnityEngine;
using System.Collections;
using MinDI;

public class GameMenu : ContextMonoBehaviour {

	[Injection] ICoroutineManager coroutines { get; set; }
	[Injection] IDIFactory<IBall> ballFactory { get; set; }

	private IBall ball = null;

	protected override void OnInjected ()
	{
		Debug.Log("Game menu is now onjected!");
		coroutines.onGui += MyGUICall;
	}

	protected override void OnDestruction ()
	{
		coroutines.onGui -= MyGUICall;
	}

	private void MyGUICall() {
		GUILayout.Label ("Hello world");
		GUILayout.Label ("Coroutines manager is: "+coroutines);

		if (ball == null) {
			if (GUILayout.Button ("Spawn ball")) {
				ball = ballFactory.Create ();
			}
		} else {
			if (GUILayout.Button ("Shake ball")) {
				ball.Shake ();
			}

			if (GUILayout.Button ("Stop ball")) {
				ball.Stop ();
			}

			if (GUILayout.Button ("Destroy ball")) {
				ball = ballFactory.Destroy (ball);
			}
		}
	}
}
