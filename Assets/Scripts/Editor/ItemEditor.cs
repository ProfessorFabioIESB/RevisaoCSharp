using UnityEngine;
using UnityEditor;

[CustomEditor(typeof (Item))]
public class ItemEditor : Editor
{
    SerializedProperty nameProp = null;
    SerializedProperty descriptionProp = null;
    SerializedProperty damageProp = null;
    SerializedProperty imageProp = null;

    void OnEnable(){
        nameProp = serializedObject.FindProperty("itemName");
        descriptionProp = serializedObject.FindProperty("itemDescription");
        damageProp = serializedObject.FindProperty("itemDamage");
        imageProp = serializedObject.FindProperty("itemSprite");
    }

    public override void OnInspectorGUI(){
        //base.OnInspectorGUI();

        GUILayout.BeginHorizontal();
            GUILayout.Label("Item Name", EditorStyles.label);

            GUIStyle textDescStyle = new GUIStyle(EditorStyles.textField){
                //fontSize = 15,
                //fixedHeight = 20,
                //alignment = TextAnchor.UpperLeft
            };

            nameProp.stringValue = EditorGUILayout.TextField(nameProp.stringValue, textDescStyle);
        GUILayout.EndHorizontal();
        //////////////////////
        GUILayout.Space(8.0f);

        GUILayout.Label("Item Description", EditorStyles.label);
        GUIStyle textDescStyle2 = new GUIStyle(EditorStyles.textArea){
            fontSize = 15,
            fixedHeight = 80,
            alignment = TextAnchor.UpperLeft
        };

        descriptionProp.stringValue = EditorGUILayout.TextArea(descriptionProp.stringValue, textDescStyle2);
        //////////////////////
        GUILayout.Space(8.0f);
        GUILayout.BeginHorizontal();
            GUILayout.Label("Item Damage", EditorStyles.largeLabel);

            damageProp.floatValue = EditorGUILayout.Slider(damageProp.floatValue, 1, 50);
        GUILayout.EndHorizontal();
        //////////////////////
        GUILayout.Space(8.0f);

        imageProp.objectReferenceValue = (Sprite)EditorGUILayout.ObjectField
        ("Item Image", imageProp.objectReferenceValue, typeof(Sprite));

        serializedObject.ApplyModifiedProperties();
    }
}
