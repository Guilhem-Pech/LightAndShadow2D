using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor (typeof (FieldOfView))]
public class FieldOfViewEditor : Editor {
	private void OnSceneGUI() {
		FieldOfView fow = (FieldOfView)target;
		Handles.color = Color.white;
		Vector2 position = fow.transform.position;
		
		Handles.DrawWireArc (position, Vector3.forward, Vector3.up, 360, fow.viewRadius);
		Vector2 viewAngleA = fow.Dir2DFromAngle (-fow.viewAngle / 2, false);
		Vector2 viewAngleB = fow.Dir2DFromAngle (fow.viewAngle / 2, false);

		Handles.DrawLine (position, position + viewAngleA * fow.viewRadius);
		Handles.DrawLine (position, position + viewAngleB * fow.viewRadius);
		
	}

}
