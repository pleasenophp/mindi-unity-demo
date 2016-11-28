using UnityEngine;
using System.Collections;
using MinDI;

[SceneContext("game")]
public class GameSceneContextInitializer : ISceneContextInitializer  {
	public void Initialize (IDIContext context)
	{
		context.mbm().BindResource<IBall, Ball>("ball");
	}

	public void AutoInstantiate (IDIContext context)
	{
		// Entry point to the scene, auto instantiate some objects here
	}

}
