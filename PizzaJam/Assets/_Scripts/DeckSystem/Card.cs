using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    private CardSO cardSO;

    [SerializeField] private TextMeshProUGUI _cardName;
    [SerializeField] private Image _cardImage;
    [SerializeField] private TextMeshProUGUI _cardDescription;
    private void Awake()
    {
        Setup();
    }

    private void Setup()
    {
        _cardName.text = cardSO.cardName;
        _cardDescription.text = cardSO.cardDescription;
        _cardImage.sprite = cardSO.cardSprite;
        gameObject.name = cardSO.cardName;
    }

    public void SetCardSO(CardSO cardSO)
    {
        this.cardSO = cardSO;
    }
}
