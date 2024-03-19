using System;
using System.Collections.Generic;
using Code.Quests.Views;

namespace Code.QuestList
{
    public interface IQuestList
    {
        event Action<QuestView> QuestAdded;
        event Action<QuestView> QuestRemoved;

        List<QuestView> CurrentQuestList { get; }

        void AddQuest(QuestView quest);
        void CompleteQuest(QuestView quest);
    }
}