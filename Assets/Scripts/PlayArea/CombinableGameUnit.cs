using UnityEngine;

namespace MiniIT.PlayArea
{
    public class CombinableGameUnit : GameUnit, ICombinable
    {
        [field: SerializeField] public CombinableGameUnitTypes gameUnitType { get; private set; }
    }
}