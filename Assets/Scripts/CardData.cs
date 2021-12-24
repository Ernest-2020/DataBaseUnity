using UnityEditor;
using UnityEngine;
[CreateAssetMenu(fileName = ("CardData"))]
public class CardData : ScriptableObject
{
    private CardData _cardData;
    public int id;
    public Sprite icon;
    public string nameTransport;
    public string mass;
    public string capasity;
    public string maxSpeed;
    public string nameProperty;
    public string property;
}