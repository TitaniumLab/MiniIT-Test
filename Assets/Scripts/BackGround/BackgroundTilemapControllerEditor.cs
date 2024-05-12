using MiniIT.Background;
using UnityEditor;
using UnityEngine;

namespace MiniIT.Background
{
    [CustomEditor(typeof(BackgroundTilemapController))]
    public class BackgroundTilemapControllerEditor : Editor
    {
        private string clearText = "Clear Map";
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var script = (BackgroundTilemapController)target;

            if (GUILayout.Button(clearText))
            {
                script.ClaerTilemap();
            }
        }
    }
}

