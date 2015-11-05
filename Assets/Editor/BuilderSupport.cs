using UnityEngine;
using UnityEditor;

public class BuildPlayers {

	public static void PreExportStep() {
		PlayerSettings.Android.bundleVersionCode = 6789;
	}

}

