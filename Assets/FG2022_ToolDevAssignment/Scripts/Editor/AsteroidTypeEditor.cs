using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Asteroids
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(AsteroidType))]
    public class AsteroidTypeEditor : Editor
    {

        SerializedObject so;
        SerializedProperty propMinForce;
        SerializedProperty propMaxForce;
        SerializedProperty propMinSize;
        SerializedProperty propMaxSize;
        SerializedProperty propMinTorque;
        SerializedProperty propMaxTorque;
        SerializedProperty propShape;
        SerializedProperty propColor;

        void OnEnable()
        {
            so = serializedObject;
            propMinForce = so.FindProperty("minForce");
            propMaxForce = so.FindProperty("maxForce");
            propMinSize = so.FindProperty("minSize");
            propMaxSize = so.FindProperty("maxSize");
            propMinTorque = so.FindProperty("minTorque");
            propMaxTorque = so.FindProperty("maxTorque");
            propShape = so.FindProperty("shape");
            propColor = so.FindProperty("color");
        }

        public override void OnInspectorGUI()
        {
            so.Update();
            GUILayout.Label("Difficulty Settings", EditorStyles.boldLabel);
            using (new GUILayout.VerticalScope(EditorStyles.helpBox))
            {
                EditorGUILayout.PropertyField(propMinForce);
                EditorGUILayout.PropertyField(propMaxForce);
                EditorGUILayout.PropertyField(propMinSize);
                EditorGUILayout.PropertyField(propMaxSize);
                EditorGUILayout.PropertyField(propMinTorque);
                EditorGUILayout.PropertyField(propMaxTorque);
            }
            GUILayout.Label("Object shape");
            using (new GUILayout.VerticalScope(EditorStyles.helpBox))
            {
                EditorGUILayout.PropertyField(propShape);
                EditorGUILayout.PropertyField(propColor);
            }
            so.ApplyModifiedProperties();
        }
    }
}
