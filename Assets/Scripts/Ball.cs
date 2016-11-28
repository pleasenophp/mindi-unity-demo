using UnityEngine;
using System.Collections;
using MinDI;

public class Ball : ContextMonoBehaviour, IBall {

	[Injection] ICoroutineManager coroutines { get; set; }

	private Coroutine shakeCoroutine = null;

	protected override void OnInjected ()
	{
		coroutines.onGui += MyGUICall;
	}

	protected override void OnDestruction ()
	{
		Stop();
		coroutines.onGui -= MyGUICall;
	}

	public void Shake() {
		shakeCoroutine = coroutines.StartCoroutine(ShakeMe());
	}

	public void Stop() {
		if (shakeCoroutine != null) {
			coroutines.StopCoroutine (shakeCoroutine);
			shakeCoroutine = null;
		}
	}

	private void MyGUICall() {
		GUILayout.Label ("Hello, I am a ball");
	}

	private IEnumerator ShakeMe() {
		while (true) {
			this.transform.position = new Vector3 (Mathf.PingPong (Time.time*10f, 3), transform.position.y, transform.position.z);
			yield return new WaitForEndOfFrame ();
		}
	}


}
