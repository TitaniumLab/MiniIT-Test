using UnityEngine;
using UnityEngine.Pool;

namespace MiniIT.PlayArea
{
    public class GameUnitPool 
    {
        private GameUnit gameUnitPrefab;
        private Transform parentTransform;
        private ObjectPool<GameUnit> pool;

        public GameUnitPool(GameUnit prefab, Transform transform)
        {
            pool = new ObjectPool<GameUnit>(CreateUnit, GetUnit, ReleaseUnit);
            gameUnitPrefab = prefab;
            parentTransform = transform;
        }

        public GameUnit Get()
        {
            return pool.Get();
        }

        public void Release(GameUnit unit)
        {
            pool.Release(unit);
        }

        private GameUnit CreateUnit()
        {
            var unit = Object.Instantiate(gameUnitPrefab, parentTransform);
            unit.SetPool(this);
            return unit;
        }

        private void GetUnit(GameUnit unit)
        {
            unit.gameObject.SetActive(true);
        }

        private void ReleaseUnit(GameUnit unit)
        {
            unit.gameObject.SetActive(false);
        }
    }
}

