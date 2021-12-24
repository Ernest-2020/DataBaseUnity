using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(Card))]
public class EditCard : Editor
{
    private Card _card;
   
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
      
        if (GUILayout.Button("Refresh"))
        {
            _card.UpdateDataBase();
        }
        if (GUILayout.Button("RemoveCard"))
        {
            _card.RemoveCard();
        }
        _card.DataBase.DataBase[_card.Id].icon = (Sprite)EditorGUILayout.ObjectField("Иконка транспорта", _card.DataBase.DataBase[_card.Id].icon, typeof(Sprite), true);
        GUILayout.Label("Название транспорта");
        _card.DataBase.DataBase[_card.Id].nameTransport = GUILayout.TextField(_card.DataBase.DataBase[_card.Id].nameTransport);
        GUILayout.Label("Масса");
        _card.DataBase.DataBase[_card.Id].mass = GUILayout.TextField(_card.DataBase.DataBase[_card.Id].mass);
        GUILayout.Label("Вместимость");
        _card.DataBase.DataBase[_card.Id].capasity = GUILayout.TextField(_card.DataBase.DataBase[_card.Id].capasity);
        GUILayout.Label("Максимальная скорость");
        _card.DataBase.DataBase[_card.Id].maxSpeed = GUILayout.TextField(_card.DataBase.DataBase[_card.Id].maxSpeed);
        GUILayout.Label("Название уникального свойства");
        _card.DataBase.DataBase[_card.Id].nameProperty = GUILayout.TextField(_card.DataBase.DataBase[_card.Id].nameProperty);
        GUILayout.Label("Уникальное свойство");
        _card.DataBase.DataBase[_card.Id].property = GUILayout.TextField(_card.DataBase.DataBase[_card.Id].property);
    }

    private void OnEnable()
    {
        _card = (Card)target;
        _card.UpdateDataBase();
    }
    private void OnDisable()
    {
        _card.UpdateDataBase();
    }
}
