using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemies.Views
{
    public interface IEnemiesSpawnerView
    {
        float Radius { get; }
        Vector2 Position { get; }
    }
}
