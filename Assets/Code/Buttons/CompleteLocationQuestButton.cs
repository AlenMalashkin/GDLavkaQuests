using Code.Quests.Views;

namespace Code.Buttons
{
    public class CompleteLocationQuestButton : CompleteQuestButton<VisitLocationQuestView>
    {
        protected override void CompleteQuest()
        {
            QuestView.Complete();
        }
    }
}