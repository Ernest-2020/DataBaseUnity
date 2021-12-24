using UnityEngine;

public class AddCard : MonoBehaviour
{
    [SerializeField] private Card _prefabCard;
    [SerializeField] private Transform _cardPanel;
    private CardData _cardData;
    
    public void Add()
    {
        Instantiate(_prefabCard, _cardPanel);
    }
}
