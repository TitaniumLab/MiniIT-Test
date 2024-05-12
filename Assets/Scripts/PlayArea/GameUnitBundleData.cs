using UnityEngine;

namespace MiniIT.PlayArea
{
    [CreateAssetMenu(fileName = "New GameUnitBundleData", menuName = "GameUnitBundleData", order = 51)]
    public class GameUnitBundleData : ScriptableObject
    {
        [field: SerializeField] public GameUnitData[] GameUnitData { get; private set; }
    }
}