using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AddCard))]
public class EditAddCard : Editor
{
    private AddCard _addCard;

    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        _addCard = (AddCard)target; 


        if (GUILayout.Button("Add Card"))
        {
            _addCard.Add();
        }

    }
}
