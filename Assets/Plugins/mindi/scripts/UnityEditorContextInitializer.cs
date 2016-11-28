namespace MinDI.UnityEditor {

	public class UnityEditorContextInitializer : IGlobalContextInitializer {
		#region IContextInitializer implementation
		public void Initialize (IDIContext context)
		{
			context.s().Bind<IEditorPrefabFilter>(() => new EditorPrefabFilter());
		}
		#endregion
	}

}
