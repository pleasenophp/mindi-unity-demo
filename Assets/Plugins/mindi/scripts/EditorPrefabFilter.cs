using MinDI.UnityEditor;

public class EditorPrefabFilter : IEditorPrefabFilter  {
	#region IEditorPrefabFilter implementation

	public bool IsPrefab (UnityEngine.GameObject obj)
	{
#if UNITY_EDITOR
		if (UnityEditor.PrefabUtility.GetPrefabObject(obj) != null && UnityEditor.PrefabUtility.GetPrefabParent(obj) == null) {	
			return true;
		}
#endif

		return false;

	}

	#endregion



}
