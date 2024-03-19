using Code.Buttons;
using Code.Factories;
using Code.QuestList;
using Code.QuestList.Views;
using UnityEngine;

namespace Code.CompositeRoot.Roots
{
    public class MainRoot : Root
    {
        [SerializeField] private QuestListView _questListView;
        [SerializeField] private AddCollectItemsQuestButton _collectItemsQuestButton;
        [SerializeField] private AddVisitLocationQuestButton _visitLocationQuestButton;
        
        public override void Compose()
        {
            IQuestList questList = new QuestList.QuestList();
            IQuestFactory questFactory = new QuestFactory(questList);
            _collectItemsQuestButton.Init(questFactory, questList);
            _visitLocationQuestButton.Init(questFactory, questList);
            _questListView.Init(questList);
        }
    }
}