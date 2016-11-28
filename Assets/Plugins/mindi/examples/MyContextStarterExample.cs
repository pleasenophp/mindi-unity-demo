using UnityEngine;
using System.Collections;
using MinDI;
using MinDI.Context;

public class MyContextStarterExample : UnityContextStarter {

	// Put your own root contexts in the chain here
	protected override IDIContext ChainUserContexts (IDIContext rootContext)
	{
		return base.ChainUserContexts (rootContext);
	}

	// This is the application entry point. Initialize the global objects here
	public override void GlobalStart(IDIContext context) {
		// IWorldModel world = context.Resolve<IWorldModel> ();
		// world.Init ();
	}

}
