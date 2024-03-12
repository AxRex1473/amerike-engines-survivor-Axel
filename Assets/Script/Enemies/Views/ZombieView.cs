using UnityEngine;
using Utils.Bindings;

namespace Enemies.Views
{
    public class ZombieView : MonoBehaviour, IZombieView
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private IntBinding _isMoving;

    }
}
