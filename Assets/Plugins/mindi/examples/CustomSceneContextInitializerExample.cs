using MinDI;
using UnityEngine;
using MinDI.Context;


// The attribute specifies the name of the scene 
// [SceneContext("myScene")]
public class CustomSceneContextInitializerExample : ISceneContextInitializer {
	#region IContextInitializer implementation

	// Init context for this scene here
	public void Initialize (IDIContext context)
	{
		// context.s().Bind<ISimpleSceneController>(() => new SimpleSceneController());
		// context.mbs().BindResource<IMyView, MyView>("myViewPrefab");
	}

	// Resolve the objects that must be auto-instantiated on this scene here
	public void AutoInstantiate(IDIContext context) {
		// context.Resolve<SimpleSceneCameraView>();
	}

	#endregion
	
}
