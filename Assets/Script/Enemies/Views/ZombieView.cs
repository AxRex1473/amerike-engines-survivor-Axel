using UnityEngine;
using Utils.Bindings;

namespace Enemies.Views
{
    public class ZombieView : MonoBehaviour, IZombieView
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private IntBinding _state;
        [SerializeField] private SpriteRenderer spriteRenderer;

        public Transform Transform => transform;

        public int State
        {
            set => _state.Value = value;
        }

        public int state => throw new System.NotImplementedException();

        public bool FlipX { set => spriteRenderer.flipX = value; }

        public float MoveSpeed => _moveSpeed;
        public GameObject GameObject => gameObject;
    }
}
