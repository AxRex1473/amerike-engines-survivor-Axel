using System.Collections;
using Enemies.Views;
using System.Collections.Generic;
using UnityEngine;

namespace Enemies.Controllers
{
    public class ZombieController : IZombieController
    {
        private IZombieView _zombieView;

        public ZombieController(IZombieView zombieView) 
        {
            _zombieView = zombieView;
        }
    }

}
