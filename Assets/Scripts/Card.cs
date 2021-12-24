using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Card : MonoBehaviour
{
    [SerializeField] private TransportDataBase _dataBase;
    [SerializeField] private  Image _image;
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _mass;
    [SerializeField] private TextMeshProUGUI _capasity;
    [SerializeField] private TextMeshProUGUI _maxSpeed;
    [SerializeField] private TextMeshProUGUI _nameProperty;
    [SerializeField] private TextMeshProUGUI _property;
    [SerializeField]private int _id;

    public int Id  => _id;

    public TransportDataBase DataBase  => _dataBase;

    public void UpdateDataBase()
    {
        _dataBase.ListData.Clear();
        _dataBase.DataBase.Clear();
        _dataBase.ListData.AddRange(Resources.LoadAll<CardData>("Data"));
        foreach (var card in _dataBase.ListData)
        {
            card.id = _dataBase.ListData.IndexOf(card);
            _dataBase.DataBase.Add(card.id, card);
        }
        RefreshData();
    
    }
    private void RefreshData()
    {
        if (_id > _dataBase.ListData.Count-1 || _id < 0)
        {
            Debug.Log("Не правельный ID");
        }
        else
        {
            _name.text = _dataBase.DataBase[_id].nameTransport;
            _image.sprite = _dataBase.DataBase[_id].icon;
            _mass.text = _dataBase.DataBase[_id].mass;
            _capasity.text = _dataBase.DataBase[_id].capasity;
            _maxSpeed.text = _dataBase.DataBase[_id].maxSpeed;
            _nameProperty.text = _dataBase.DataBase[_id].nameProperty;
            _property.text = _dataBase.DataBase[_id].property;
        }
    }

    public void RemoveCard()
    {
        DestroyImmediate(gameObject);
    }
}

