using UnityEngine;

namespace DefaultNamespace
{
    public class SuperTower : MonoBehaviour, ITower
    {
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private float _damage;

        public float RotationSpeed => _rotationSpeed;
        public float Damage => _damage;
        
        public void SetPosition(Vector3 position)
        {
            transform.localPosition = position;
        }
    }
}