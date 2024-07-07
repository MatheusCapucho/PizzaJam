using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeckManager : MonoBehaviour
{ 
    public DeckSO CurrentDeckSO { get; private set; }

    private List<CardSO> currentDeck = new List<CardSO>();

    private void Awake()
    {
        Setup();
    }

    private void Setup()
    {
        CurrentDeckSO = Resources.Load<DeckSO>("Decks/CurrentDeck");
        PopulateDeck();
        ShuffleDeck();
    }

    private void PopulateDeck()
    {
        currentDeck = CurrentDeckSO.Cards;
    }
    private void ShuffleDeck()
    {
        currentDeck.ShuffleList();
    }
    public CardSO DrawCard()
    {
        if(currentDeck.Count <= 0)
        {
            PopulateDeck();
            ShuffleDeck();
        }
        
        CardSO firstCard = currentDeck[0];
        currentDeck.RemoveAt(0);

        return firstCard;

    }

    public void AddCardToDeck(CardSO cardSO)
    {
        CurrentDeckSO.Cards.Add(cardSO);
    }
    public void RemoveCardFromDeck(CardSO cardSO)
    {
        CurrentDeckSO.Cards.Remove(cardSO);
    }


}
