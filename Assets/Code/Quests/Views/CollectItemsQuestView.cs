using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Quests.Views
{
    public class CollectItemsQuestView : QuestView
    {
        [SerializeField] private TextMeshProUGUI _collectedItemsText;
        [SerializeField] private TextMeshProUGUI _neededItemsText;
        [SerializeField] private Image _progressBar;
        [SerializeField] private Animation _animation;

        public CollectItemsQuest CollectItemsQuestModel => _collectItemsQuestModel;
        private CollectItemsQuest _collectItemsQuestModel;

        public override void Init(Quest questModel)
        {
            base.Init(questModel);

            if (!(questModel is CollectItemsQuest collectItemsQuestModel))
                return;

            _collectItemsQuestModel = collectItemsQuestModel;
            _collectedItemsText.text = collectItemsQuestModel.CollectedItems + "";
            _neededItemsText.text = collectItemsQuestModel.NeededItems + "";
            _progressBar.fillAmount = collectItemsQuestModel.QuestProgress;
        }

        public override void Complete()
        {
            _animation.Play();
        }

        public void OnAnimationComplete()
        {
            Destroy(gameObject);
        }
    }
}