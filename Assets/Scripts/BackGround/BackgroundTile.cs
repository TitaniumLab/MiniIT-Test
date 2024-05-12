using UnityEngine;
using UnityEngine.Tilemaps;

namespace MiniIT.Background
{
    [CreateAssetMenu(fileName = "New Level Tile", menuName = "2D/Tiles/Level Tile")]
    public class BackgroundTile : Tile
    {
        [field: SerializeField] public BackgroundTypes BackgroundType { get; private set; }
    }
}