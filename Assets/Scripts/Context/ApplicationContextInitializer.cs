using UnityEngine;
using System.Collections;
using MinDI;

public class ApplicationContextInitializer : IApplicationContextInitializer {
	public void Initialize (IDIContext context)
	{
		context.mbs().BindResource<Settings>("settings");
	}

	
}
