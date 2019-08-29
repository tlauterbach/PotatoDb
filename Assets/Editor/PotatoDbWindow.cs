using UnityEditor;
using UnityEngine;

namespace PotatoDb.Editor {

	/// <summary>
	/// Editor window class for editing your PotatoDb content
	/// </summary>
	public class PotatoDbWindow : EditorWindow {

		[MenuItem("Potato Db", menuItem = "Window/PotatoDb")]
		public static void ShowWindow() {
			PotatoDbWindow window = GetWindow<PotatoDbWindow>(false, "Potato Db", true);
			window.minSize = new Vector2(400f, 300f);
			window.ShowTab();
		}

		private void OnGUI() {
		

		}

	}

}


