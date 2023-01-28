using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;

namespace Asteroids
{
    public class DiffucultyTool : EditorWindow
    {
        [MenuItem("FG2022-ToolDevAssignment/DiffucultyTool")]
        private static void ShowWindow()
        {
            var window = GetWindow<DiffucultyTool>();
            window.titleContent = new GUIContent("DiffucultyTool");
            window.Show();
        }

        AsteroidType[] asteroidTypes;
        AsteroidType asteroid;

        private void OnEnable()
        {
            Selection.selectionChanged += Repaint;

            string[] guids = AssetDatabase.FindAssets("t:AsteroidType");
            IEnumerable<string> paths = guids.Select(AssetDatabase.GUIDToAssetPath);
            asteroidTypes = paths.Select(AssetDatabase.LoadAssetAtPath<AsteroidType>).ToArray();
            if (asteroidTypes.Length > 0)
            {
                SetAsteroid(0);
            }
        }

        private void OnDisable() => Selection.selectionChanged -= Repaint;


        private void OnGUI()
        {
            using (new EditorGUI.DisabledScope(asteroid))
            {
                GUILayout.Box(asteroid.name);
            }
        }





        private void SetAsteroid(int nextTypeNumber)
        {
            if (nextTypeNumber >= asteroidTypes.Length)
            {
                nextTypeNumber = 0;
            }
            asteroid = asteroidTypes[nextTypeNumber];
        }

    }
}