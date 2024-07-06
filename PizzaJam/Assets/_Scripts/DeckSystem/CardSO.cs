using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSO : ScriptableObject
{
    [Header("Card Attributes")]
    public string cardName;
    public int cardID;
    public Sprite cardSprite;
    public CardType CardType;
    [TextArea(0, 5)] public string cardDescription;
}
