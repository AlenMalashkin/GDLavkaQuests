using Code.Quests;
using UnityEngine;

namespace Code.Configs
{
    [CreateAssetMenu(fileName = "CollectItemsQuestConfig", menuName = "Collect Items Quest Config", order = 0)]
    public class CollectItemsQuestConfig : ScriptableObject
    {
        [SerializeField] private CollectItemsQuest[] collectItemsQuests;

        public CollectItemsQuest[] CollectItemsQuests => collectItemsQuests;
    }
}