using Cysharp.Threading.Tasks;
using Enemies.Controller;
using Enemies.Views;
using Player.views;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using Utils.AdresableLoader;

namespace Enemies.Controllers
{
    public class EnemiesSpawnerController : IEnemiesSpawnerController 
    {
        private IEnemiesSpawnerView _enemiesSpawnerView;
        private IZombieView _zombieView;
        private IObjectPool<GameObject> _zombiePool;
        private const int PoolSize = 1000;
        private IPlayerView _playerView;

        public EnemiesSpawnerController (IEnemiesSpawnerView enemiesSpawnerView, IPlayerView playerView)
        {
            _enemiesSpawnerView = enemiesSpawnerView;
            _playerView = playerView;

            GenerateZombie().Forget();
        }

        private async UniTaskVoid GenerateZombie()
        {
            _zombieView = await AdresableLoader.InstantiateAsync<IZombieView>("Zombie_Default");

            _zombiePool = new ObjectPool<GameObject>(CreatePooledItem, OnTakedFromPool, OnReturnedPool, OnDestroyPoolObject , true, 10, PoolSize);

            for (int i = 0; i < 10; i++) 
            {
                _zombiePool.Get();
            }
        }

        private GameObject CreatePooledItem()
        {
            var position = _enemiesSpawnerView.Position;
            var enemyPosition = position + Random.insideUnitCircle * _enemiesSpawnerView.Radius;
            var enemy = Object.Instantiate(_zombieView.GameObject, enemyPosition, Quaternion.identity);
            var zombieView = enemy.GetComponent<IZombieView>();

            var zombieController = new ZombieController(zombieView, _playerView);
            return enemy;
        }

        private void OnTakedFromPool(GameObject gameObject)
        {
            gameObject.SetActive(true);
        }

        private void OnReturnedPool(GameObject gameObject) 
        {
            gameObject.SetActive(false);
        }

        private void OnDestroyPoolObject(GameObject gameObject) 
        {
            Object.Destroy(gameObject);
        }
    }
}
