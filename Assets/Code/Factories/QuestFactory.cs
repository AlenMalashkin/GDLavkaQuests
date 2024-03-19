using Code.Buttons;
using Code.QuestList;
using Code.Quests;
using Code.Quests.Views;
using UnityEngine;

namespace Code.Factories
{
    public class QuestFactory : IQuestFactory
    {
        private IQuestList _questList;

        public QuestFactory(IQuestList questList)
        {
            _questList = questList;
        }

        public TView CreateQuest<TView, TModel>(TView questView, TModel questModel, Transform parent) where TView : QuestView where TModel : Quest
        {
            TView view = Object.Instantiate(questView, parent);
            view.Init(questModel);
            view.GetComponentInChildren<CompleteQuestButton<TView>>().Init(_questList);
            return view;
        }
    }
}