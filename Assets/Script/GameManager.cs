using Cysharp.Threading.Tasks;
using Map.views;
using Player.controllers;
using Player.views;
using Enemies.Controllers;
using Enemies.Views;
using UnityEngine;
using Utils.AdresableLoader;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private PlayerView playerViewSource; 
    private void Awake()
    {
        if(Instance)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            CreateGame().Forget();
        }
    }

    private async UniTaskVoid CreateGame()
    {
        var MapView = await AdresableLoader.InstantiateAsync<IMapView>("Map_NewAx");
        var playerView = await AdresableLoader.InstantiateAsync<IPlayerView>("Player_Default");
        IPlayerController playerController = new PlayerController(playerView);

        var enmeyView = await AdresableLoader.InstantiateAsync<IZombieView>("Zombie_Default");
        IZombieController zombieController = new ZombieController(enmeyView, playerView);
    }
}
