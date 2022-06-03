using UnityEngine;

namespace DefaultNamespace
{
    public interface ICase
    {
        public float Speed { get; }
        public float RotationSpeed { get; }
        public float Health { get; }

        public Vector3 TowerPosition { get; }
    }
}