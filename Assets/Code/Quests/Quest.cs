using System;
using UnityEngine;

namespace Code.Quests
{
    [Serializable]
    public abstract class Quest
    {
        public string QuestName => _questName;
        public string QuestDescription => _questDescription;
        
        [field: SerializeField] private string _questName;
        [field: SerializeField] private string _questDescription;
    }
}