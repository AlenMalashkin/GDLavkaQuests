using System;
using UnityEngine;

namespace Code.Quests
{
    [Serializable]
    public class CollectItemsQuest : Quest
    {
        public int CollectedItems => _collectedItems;
        public int NeededItems => _neededItems;
        public float QuestProgress => (float) _collectedItems / _neededItems;

        [field: SerializeField] private int _collectedItems;
        [field: SerializeField] private int _neededItems;
    }
}