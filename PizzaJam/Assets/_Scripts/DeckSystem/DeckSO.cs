using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new deck", menuName = "new deck")]
public class DeckSO : ScriptableObject
{
    public string DeckName;
    public List<CardSO> Cards;
}
