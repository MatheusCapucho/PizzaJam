using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Card/New Card")]
public class CardSO : ScriptableObject
{
    [Header("Card Attributes")]
    public string cardName;
    public int cardID;
    public Sprite cardSprite;
    public CardType CardType;
    [TextArea(0, 5)] public string cardDescription;

    [Header("Attack Related")]
    public int attackValue;
    public int attackMultiplier = 1;

    [Header("Defense Related")]
    public int defenseValue;
    public int defenseMultiplier = 1;
}
