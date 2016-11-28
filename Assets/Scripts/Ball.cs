using UnityEngine;
using System.Collections;
using MinDI;

public class Ball : ContextMonoBehaviour, IBall {

	[Injection] ICoroutineManager coroutines { get; set; }

	protected override void OnInjected ()
	{
		coroutines.onGui += MyGUICall;
	}

	protected override void OnDestruction ()
	{
		coroutines.onGui -= MyGUICall;
	}

	public void Shake() {
		coroutines.StartCoroutine(ShakeMe());
	}

	public void Stop() {
		coroutines.StopCoroutine(ShakeMe());
	}

	private void MyGUICall() {
		GUILayout.Label ("Hello, I am a ball");
	}

	private IEnumerator ShakeMe() {
		while (true) {
			this.transform.position = new Vector3 (Mathf.PingPong (Time.time, 3), transform.position.y, transform.position.z);
			yield return new WaitForEndOfFrame ();
		}
	}


}
