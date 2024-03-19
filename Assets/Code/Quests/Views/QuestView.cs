using TMPro;
using UnityEngine;

namespace Code.Quests.Views
{
    public abstract class QuestView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _questNameText;
        [SerializeField] private TextMeshProUGUI _questDescriptionText;

        public Quest QuestModel => _questModel;
        private Quest _questModel;

        public virtual void Init(Quest questModel)
        {
            _questModel = questModel;
            _questNameText.text = questModel.QuestName;
            _questDescriptionText.text = questModel.QuestDescription;
        }

        public abstract void Complete();
    }
}