using System;
using UnityEngine;

public class GameEvents
{
    public static Action<int, int> OnPlayerUseAttackCard;
    public static Action<int, int> OnPlayerUseDefenseCard;
    public static Action OnPlayerUseSpecialCard;
}
