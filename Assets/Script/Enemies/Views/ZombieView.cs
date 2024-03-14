using UnityEngine;
using Utils.Bindings;

namespace Enemies.Views
{
    public class ZombieView : MonoBehaviour, IZombieView
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private IntBinding State;
        [SerializeField] private SpriteRenderer spriteRenderer;

        public float MoveSpeed => _moveSpeed;

        public Transform Transform => transform;

        public bool FlipSprite { get => spriteRenderer.flipX; set => spriteRenderer.flipX = value; }

    }
}
