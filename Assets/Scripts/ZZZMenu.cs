using System;
using MinDI;
using UnityEngine;

public class ZZZMenu : ContextMonoBehaviour
{
	[Injection] public Settings settings { get; set; }
	[Injection] ISceneLoader sceneLoader { get; set; }

	void OnGUI() {
		GUILayout.Label ("Hi, I'm zzz scene!");
		GUILayout.Label ("The ball color in settings is "+settings.ballColor);

		if (GUILayout.Button ("Go back to game scene")) {
			sceneLoader.Load ("game");
		}

	}
}

