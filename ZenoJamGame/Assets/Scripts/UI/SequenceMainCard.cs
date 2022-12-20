using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Nocturne.GeneralTools;

public class SequenceMainCard : MonoBehaviour
{
    [SerializeField]
    private bool PlayAtStart;

    [SerializeField]
    private float delayBetween = 0.1f;

    [SerializeField]
    private float time = 0.1f;

    [SerializeField]
    RectTransform[] cards;

    public int currentIndex {  get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        if(cards.Length == 0)
        {
            Debug.LogError("Debe de haber al menos una tarjeta para la secuencia.");
        }

        if (PlayAtStart)
        {
            ShowAllCards();
        }
    }

    public void ShowAllCards()
    {
        StartCoroutine(ShowSequence());
    }

    public void HideAllCards()
    {
        StartCoroutine(HideSequence());
    }

    public void SelectCard(int index)
    {
        currentIndex = index;
        StartCoroutine(HideSequenceExcluted(currentIndex));
    }

    public void HideCardsExcluted()
    {
        StartCoroutine(ShowSequence());
    }

    IEnumerator ShowSequence()
    {
        for(var i = 0; i < cards.Length; i++)
        {
            cards[i].DOAnchorPosY(0f, time).SetEase(Ease.OutQuart);
            yield return Helpers.GetWait(delayBetween);
        }
    }
    IEnumerator HideSequence()
    {
        for (var i = 0; i < cards.Length; i++)
        {
            cards[i].DOAnchorPosY(-1200f, time).SetEase(Ease.InQuart);
            yield return Helpers.GetWait(delayBetween);
        }
    }

    IEnumerator HideSequenceExcluted(int index)
    {
        for (var i = 0; i < cards.Length; i++)
        {
            if (index == i)
            {
                cards[i].DOAnchorPosY(1200f, time).SetEase(Ease.InQuart);
            }
            else
            {
                cards[i].DOAnchorPosY(-1200f, time).SetEase(Ease.InQuart);
            }
            
            yield return Helpers.GetWait(delayBetween);
        }
    }
}
