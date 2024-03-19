using Code.Quests;
using Code.Quests.Views;
using UnityEngine;

namespace Code.Factories
{
    public interface IQuestFactory
    {
        TView CreateQuest<TView, TModel>(TView questView, TModel questModel, Transform parent)
            where TView : QuestView 
            where TModel : Quest;
    }
}