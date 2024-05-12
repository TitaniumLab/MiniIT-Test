using System;
using UnityEngine;

namespace MiniIT.PlayArea
{
    [Serializable]
    public class GameUnitData
    {
        [field: SerializeField] public GameUnit UnitPrefab { get; private set; }
        [field: SerializeField] public int RandomSpawnWeight { get; private set; }
    }

}