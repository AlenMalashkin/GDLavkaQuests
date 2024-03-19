using UnityEngine;

namespace Code.Quests.Views
{
    public class VisitLocationQuestView : QuestView
    {
        [SerializeField] private Animation _animation;
        
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