using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BattleManager : MonoBehaviour
{
    public GamePhase CurrentPhase { get; private set; }

    [SerializeField] private UnitSO _playerSO;
    [SerializeField] private UnitSO _enemySO;

    private int playerCurrentHealth;
    private int enemyCurrentHealth;

    private void Start()
    {
        playerCurrentHealth = _playerSO.playerCurrentHealth;
        enemyCurrentHealth = _enemySO.MaxHealth;
    }
    public void ChangeGamePhase(GamePhase phase)
    {
        CurrentPhase = phase;
    }

    public void PlayerAction(CardSO card)
    { 
        switch (card.CardType)
        {
            case CardType.ATTACK:
                GameEvents.OnPlayerUseAttackCard?.Invoke(card.attackValue, card.attackMultiplier); break;
            case CardType.DEFENSE: 
                GameEvents.OnPlayerUseDefenseCard?.Invoke(card.defenseValue, card.defenseMultiplier); break;
            case CardType.EFFECT:
                GameEvents.OnPlayerUseSpecialCard?.Invoke(); break;
        }
    }



}
