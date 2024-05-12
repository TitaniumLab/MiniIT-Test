using UnityEngine;

namespace MiniIT.PlayArea
{
    public class GameUnit : MonoBehaviour
    {
        protected GameUnitPool gameUnitPool;

        public void ReleaseGameUnit()
        {
            gameUnitPool.Release(this);
        }

        public void SetPool(GameUnitPool gameUnitPool)
        {
            if (this.gameUnitPool is null)
            {
                this.gameUnitPool = gameUnitPool;
            }
        }
    }
}

