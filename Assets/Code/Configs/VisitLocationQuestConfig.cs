using Code.Quests;
using UnityEngine;

namespace Code.Configs
{
    [CreateAssetMenu(fileName = "VisitLocatoinQuestConfig", menuName = "Visit Location Quest Config", order = 1)]
    public class VisitLocationQuestConfig : ScriptableObject
    {
        [SerializeField] private VisitLocationQuest[] _visitLocation;

        public VisitLocationQuest[] VisitLocationQuests => _visitLocation;
    }
}