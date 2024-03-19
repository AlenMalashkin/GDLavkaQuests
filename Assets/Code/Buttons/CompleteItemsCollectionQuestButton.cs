using Code.Quests.Views;

namespace Code.Buttons
{
    public class CompleteItemsCollectionQuestButton : CompleteQuestButton<CollectItemsQuestView>
    {
        protected override void CompleteQuest()
        {
            if (QuestView.CollectItemsQuestModel.QuestProgress == 1f)
                QuestView.Complete();
        }
    }
}