using System;
using Cysharp.Threading.Tasks;
using Map.views;
using Player.controllers;
using Player.views;
using Enemies.Controllers;
using Enemies.Views;
using DefaultNamespace;
using UnityEngine;
using Utils.AdresableLoader;
using AudioChannel.Views;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private Game _game;
    
    private void Awake()
    {
        if(Instance)    
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;

            _game = new Game();
            //_game.CreateLevel().Forget();
            DontDestroyOnLoad(gameObject);
            //CreateGame().Forget();
        }
    }
}
