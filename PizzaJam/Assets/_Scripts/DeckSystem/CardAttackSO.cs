using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Card/Attack Card")]
public class CardAttackSO : CardSO
{
    [Header("Attack Related")]
    public int attackValue;
    public int attackMultiplier = 1;
}
