using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemies.Views
{
    public interface IZombieView
    {
        Transform Transform { get; }
        int state { get; }
        bool FlipX { set; }
        float MoveSpeed { get; }
        GameObject GameObject { get; }
    }
}