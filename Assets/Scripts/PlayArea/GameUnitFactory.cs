using UnityEngine;

namespace MiniIT.PlayArea
{
    public class GameUnitFactory
    {
        private GameUnitPool pool;

        public GameUnitFactory(GameUnit prefab, Transform transform)
        {
            pool = new GameUnitPool(prefab, transform);
        }

        public GameUnit GetUnit()
        {
            GameUnit unit = pool.Get();
            Debug.Log($"Unit ¹{unit.name} spawned.");
            return unit;
        }
    }
}