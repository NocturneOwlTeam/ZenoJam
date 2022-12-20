using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardContainer : MonoBehaviour
{
    public Card card;

    [SerializeField]
    private TextMeshProUGUI textName;

    [SerializeField]
    private Image cardIcon;

    void Start()
    {

    }

    public void SetData(Card cardData)
    {
        card = cardData;
        cardIcon.sprite = cardData.spriteImage;
    }
}
