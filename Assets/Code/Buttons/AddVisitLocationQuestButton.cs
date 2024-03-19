using System;
using Code.Configs;
using Code.Factories;
using Code.QuestList;
using Code.Quests;
using Code.Quests.Views;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace Code.Buttons
{
    public class AddVisitLocationQuestButton : MonoBehaviour
    {
        [SerializeField] private VisitLocationQuestView _questViewPrefab;
        [SerializeField] private Button _addQuestButton;
        [SerializeField] private Transform _parent;

        private IQuestFactory _questFactory;
        private IQuestList _questList;
        private VisitLocationQuestConfig _visitLocationQuestConfig;

        private void Awake()
        {
            _visitLocationQuestConfig = Resources.Load<VisitLocationQuestConfig>("Configs/VisitLocatoinQuestConfig");
        }

        public void Init(IQuestFactory questFactory, IQuestList questList)
        {
            _questFactory = questFactory;
            _questList = questList;
        }
        
        private void OnEnable()
        {
            _addQuestButton.onClick.AddListener(AddQuest);
        }

        private void OnDisable()
        {
            _addQuestButton.onClick.RemoveListener(AddQuest);
        }

        private void AddQuest()
        {
            QuestView view = _questFactory.CreateQuest(_questViewPrefab, 
                _visitLocationQuestConfig
                    .VisitLocationQuests[Random.Range(0, _visitLocationQuestConfig
                        .VisitLocationQuests.Length)],
                _parent);

            _questList.AddQuest(view);
        }
    }
}