using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Card : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
 
    [SerializeField] private CardSO cardSO;

    [SerializeField] private TextMeshProUGUI _cardName;
    [SerializeField] private Image _cardImage;
    [SerializeField] private TextMeshProUGUI _cardDescription;

    private Vector3 _cardPosition;
    private Vector3 _cardScale;
    private void Awake()
    {
        Setup();
    }

    private void Setup()
    {
        _cardName.text = cardSO.cardName;
        _cardDescription.text = cardSO.cardDescription;
        _cardImage.sprite = cardSO.cardSprite;
        gameObject.name = cardSO.cardName;
        _cardPosition = transform.position;
        _cardScale = transform.localScale;
    }

    private void OnEnable()
    {
        switch(cardSO.CardType) 
        {
            case CardType.ATTACK:
                GameEvents.OnPlayerUseAttackCard += UseAttackCard; break;
            case CardType.DEFENSE:
                GameEvents.OnPlayerUseDefenseCard += UseDefenseCard; break;
            case CardType.EFFECT:
                GameEvents.OnPlayerUseSpecialCard += UseSpecialCard; break;
        }
    }

    private void OnDisable()
    {
        switch (cardSO.CardType)
        {
            case CardType.ATTACK:
                GameEvents.OnPlayerUseAttackCard -= UseAttackCard; break;
            case CardType.DEFENSE:
                GameEvents.OnPlayerUseDefenseCard -= UseDefenseCard; break;
            case CardType.EFFECT:
                GameEvents.OnPlayerUseSpecialCard -= UseSpecialCard; break;
        }
    }

    private void UseSpecialCard()
    {
        throw new NotImplementedException();
    }

    private void UseDefenseCard(int arg1, int arg2)
    {
        throw new NotImplementedException();
    }

    private void UseAttackCard(int arg1, int arg2)
    {
        throw new NotImplementedException();
    }

    public void SetCardSO(CardSO cardSO)
    {
        this.cardSO = cardSO;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StartCoroutine(CardHovered(false));
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        StartCoroutine(CardHovered(true));
    }

    IEnumerator CardHovered(bool scaleUP)
    {

        float timeElapsed = 0f;
        Vector3 endScale;
        Vector3 endPos;

        if (scaleUP)
        {
            endScale = _cardScale * 1.4f;
        }
        else
        {
            endScale = _cardScale;
        }


        while (timeElapsed < .5f)
        {
            timeElapsed += Time.deltaTime;
            transform.localScale = Vector3.Lerp(transform.localScale, endScale, Time.deltaTime);
        }

        yield return null;
    }
}
