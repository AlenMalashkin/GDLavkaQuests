using Code.QuestList;
using Code.Quests;
using Code.Quests.Views;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Buttons
{
    public abstract class CompleteQuestButton<T> : MonoBehaviour where T : QuestView
    {
        [SerializeField] private T _questView;
        [SerializeField] private Button _completeButton;

        public T QuestView => _questView;

        private IQuestList _questList;
        
        public void Init(IQuestList questList)
        {
            _questList = questList;
        }
        
        private void OnEnable()
        {
            _completeButton.onClick.AddListener(CompleteQuest);
        }

        private void OnDisable()
        {
            _completeButton.onClick.RemoveListener(CompleteQuest);
        }

        protected abstract void CompleteQuest();
    }
}