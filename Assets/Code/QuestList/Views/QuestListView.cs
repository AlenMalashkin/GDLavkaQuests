using Code.Quests.Views;
using UnityEngine;

namespace Code.QuestList.Views
{
    public class QuestListView : MonoBehaviour
    {
        private IQuestList _questList;

        public void Init(IQuestList questList)
        {
            _questList = questList;
        }

        private void OnEnable()
        {
            _questList.QuestRemoved += OnQuestRemoved;
        }

        private void OnDisable()
        {
            _questList.QuestRemoved -= OnQuestRemoved;
        }

        private void OnQuestRemoved(QuestView questView)
        {
            questView.Complete();
        }
    }
}