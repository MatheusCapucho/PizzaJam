using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Card/DefenseCard")]
public class CardDefenseSO : CardSO
{
    [Header("Defense Related")]
    public int defenseValue;
    public int defenseMultiplier = 1;
}
