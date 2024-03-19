using Code.CompositeRoot.Roots;
using UnityEngine;

namespace Code.CompositeRoot
{
    public class CompositionRoot : MonoBehaviour
    {
        [SerializeField] private Root[] _roots; 
    
        private void Awake()
        {
            foreach (var root in _roots)
            {
                root.Compose();
            }
        }
    }
}