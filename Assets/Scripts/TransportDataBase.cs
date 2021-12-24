using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "TransportDataBase", menuName = ("DataBase/Transport"))]
public class TransportDataBase : ScriptableObject
{
    [SerializeField] private List<CardData> _listData = new List<CardData>();
    private Dictionary<int, CardData> _dataBase = new Dictionary<int, CardData>();
    public Dictionary<int, CardData> DataBase => _dataBase;

    public List<CardData> ListData => _listData;

}




