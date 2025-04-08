using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Card
{
    public enum CardPath
    {
        Common,
        TEST
    }

    public abstract class CardBase : ScriptableObject
    {
        [SerializeField] private int cost;
        protected CardPath cardPath;
        protected string cardName;

        public CardPath CardPath => cardPath;
        public string CardName => cardName;

        public abstract void Activate();
        public abstract void Generate();
    }
}