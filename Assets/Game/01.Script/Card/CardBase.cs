using System.Collections;
using System.Collections.Generic;
using Game.Player;
using UnityEngine;

namespace Game.Card
{
    public enum CardPath
    {
        Common,
    }

    public abstract class CardBase : ScriptableObject
    {
        [SerializeField] protected int cost;
        [SerializeField] protected CardPath cardPath;
        [SerializeField] protected string cardName;

        public int Cost => cost;
        public CardPath CardPath => cardPath;
        public string CardName => cardName;

        public abstract void Activate(PlayerController owner, Unit unit);
        public abstract void Generate();
    }
}