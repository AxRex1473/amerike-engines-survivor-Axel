using System.Collections;
using Enemies.Views;
using System.Collections.Generic;
using UnityEngine;
using Player.views;
using Cysharp.Threading.Tasks;

namespace Enemies.Controllers
{
    public class ZombieController : IZombieController
    {
        private IZombieView zombieView;
        private IPlayerView playerView; 

        public ZombieController(IZombieView _zombieView, IPlayerView _playerView) 
        {
            zombieView = _zombieView;
            playerView = _playerView;
            Movement().Forget();
        }

        private async UniTask Movement()
        {
            while (true)
            {   

                Vector3 playerPosition = playerView.Transform.position;
                Vector3 direction = playerPosition - zombieView.Transform.position;
                direction.Normalize();
                float playerDirection = Mathf.Sign(direction.x);

                zombieView.FlipX = (playerDirection < 0);

                zombieView.Transform.position = Vector2.MoveTowards(zombieView.Transform.position,playerPosition,zombieView.MoveSpeed * Time.deltaTime);
                await UniTask.DelayFrame(1);
            }
        }


    }

}
