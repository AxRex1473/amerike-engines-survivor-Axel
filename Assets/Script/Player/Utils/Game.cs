using Cysharp.Threading.Tasks;
using Enemies.Controllers;
using Enemies.Views;
using Map.controllers;
using Map.views;
using Player.controllers;
using Player.views;
using Utils.AdresableLoader;

namespace DefaultNamespace
{
    public class Game
    {
        public Game()
        {
            
        }

        public async UniTaskVoid CreateLevel()
        {
            var mapView = await AdresableLoader.InstantiateAsync<IMapView>("Map_NewAx");
            IMapController mapController = new MapController(mapView);

            var playerView = await AdresableLoader.InstantiateAsync<IPlayerView>("Player_Default");
            IPlayerController playerController = new PlayerController(playerView);
        }
    }
}
