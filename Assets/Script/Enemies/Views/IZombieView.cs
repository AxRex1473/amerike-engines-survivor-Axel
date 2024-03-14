using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemies.Views
{
    public interface IZombieView
    {
        float MoveSpeed { get; }
        Transform Transform { get; }
        bool FlipSprite { get; set; }
    }
}