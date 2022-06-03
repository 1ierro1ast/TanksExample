using UnityEngine;

namespace DefaultNamespace
{
    public interface ITower
    {
        public float RotationSpeed { get; }
        public float Damage { get; }

        public void SetPosition(Vector3 position);
    }
}