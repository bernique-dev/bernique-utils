using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(MinMaxInt))]
public class MinMaxIntPropertyDrawer : PropertyDrawer {

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {

        SerializedProperty minProperty = property.FindPropertyRelative("m_min");
        SerializedProperty maxProperty = property.FindPropertyRelative("m_max");

        Rect labelRect = new Rect(position.min, new Vector2(position.width / 3, position.height));
        GUI.Label(labelRect, property.name);

        Rect minRect = new Rect(labelRect.min + new Vector2(labelRect.width, 0), new Vector2(position.width / 3, position.height));
        Rect maxRect = new Rect(minRect.min + new Vector2(minRect.width, 0), new Vector2(position.width / 3, position.height));

        EditorGUI.PropertyField(minRect, minProperty, GUIContent.none);
        EditorGUI.PropertyField(maxRect, maxProperty, GUIContent.none);
    }

}