using Assets.Scripts.GameData;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.EditorScripts
{
    [CustomEditor(typeof(ConfigFileWriter))]
    public class ConfigFileWriterButton : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            ConfigFileWriter myScript = (ConfigFileWriter)target;
            if (GUILayout.Button("Save"))
            {
                myScript.WriteAllFiles();
            }
        }

    }
}