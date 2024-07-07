using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialDeckChoice : MonoBehaviour
{

    [SerializeField] private DeckSO deck;

    private DeckSO currentDeck;

    private void Awake()
    {
        currentDeck = Resources.Load<DeckSO>("Decks/CurrentDeck");
    }


    public void SelectThisDeck()
    {
        currentDeck.Cards = deck.Cards;
    }


}
