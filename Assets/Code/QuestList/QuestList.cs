using System;
using System.Collections.Generic;
using Code.Quests.Views;

namespace Code.QuestList
{
    public class QuestList : IQuestList
    {
        public event Action<QuestView> QuestAdded;
        public event Action<QuestView> QuestRemoved;

        public List<QuestView> CurrentQuestList => _questsList;
        
        private List<QuestView> _questsList = new List<QuestView>();

        public void AddQuest(QuestView quest)
        {
            if (_questsList.Contains(quest))
                throw new Exception("This quest is already added to quest list");

            _questsList.Add(quest);
            QuestAdded?.Invoke(quest);
        }

        public void CompleteQuest(QuestView quest)
        {
            if (!_questsList.Contains(quest))
                throw new Exception("Quest you want to complete is not in list");
            
            _questsList.Remove(quest);
            QuestRemoved?.Invoke(quest);            
        }
    }
}