using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName ="Carta", menuName ="Carta Nueva")]
public class Card : ScriptableObject
{
    public string cardName;

    public string description;

    public Sprite spriteImage;

    public void LoadCard(CardData loadedCard)
    {
        cardName = loadedCard.cardName;
        spriteImage = loadedCard.spriteImage;
        description= loadedCard.description;
    }
}

[SerializeField]
public class CardData
{
    public string cardName;

    public string description;

    public Sprite spriteImage;
}