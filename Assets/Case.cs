using UnityEngine;

namespace DefaultNamespace
{
    public class Case : MonoBehaviour, ICase
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private float _health;
        [SerializeField] private Vector3 _towerPosition;

        public float Speed => _speed;
        public float RotationSpeed => _rotationSpeed;
        public float Health => _health;
        public Vector3 TowerPosition => _towerPosition;
    }
}