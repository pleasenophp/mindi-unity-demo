using MinDI;
using UnityEngine;
using MinDI.Context;


// Uncomment
// [SceneContext("_root")]
public class RootSceneContextInitializerExample : ISceneContextInitializer {
	#region IContextInitializer implementation

	// This is usually not needed for the root scene
	public void Initialize (IDIContext context)
	{
	}

	// Put the auto instantiation of permanent mono behaviours for the application here
	public void AutoInstantiate(IDIContext context) {
		// context.Resolve<IWorldTimer>();
	}

	#endregion
}
