using UnityEngine;
using UnityEditor;
#if UNITY_EDITOR
[CustomEditor(typeof(checkSizeScript))]
public class checkSize : Editor
{

    //public float height = 0f;
    public float width = 0f;
    public float lengh = 0f;
    public float mass = 0f;
    public float engine = 0f;

    public override void OnInspectorGUI() {
        checkSizeScript myScript = (checkSizeScript)target;

        //float height = 0f;
        myScript.height = EditorGUILayout.FloatField("Height", myScript.height);
        myScript.width = EditorGUILayout.FloatField("Width", myScript.width);
        myScript.lengh = EditorGUILayout.FloatField("Length", myScript.lengh);
        myScript.mass = EditorGUILayout.FloatField("Mass", myScript.mass);
        myScript.engine = EditorGUILayout.FloatField("Engine", myScript.engine);

        if (GUILayout.Button("Create SizerBox")) {
            myScript.Button_Press();

        }

        if (GUILayout.Button("Remove SizerBox")) {
            myScript.Button_Remove();
        }
    }
}
#endif      