using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Unit")]
public class UnitSO : ScriptableObject
{
    public int MaxHealth = 20;
    public DeckSO UnitStarterDeck;

    [HideInInspector] public int playerCurrentHealth;

}
