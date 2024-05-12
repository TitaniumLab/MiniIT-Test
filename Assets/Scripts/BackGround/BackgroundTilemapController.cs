using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace MiniIT.Background
{
    public class BackgroundTilemapController : MonoBehaviour
    {
        [field: SerializeField] public Tilemap BackgroundTilemap { get; private set; }
        [field: SerializeField] public Tilemap asdf { get; private set; }

        private void Start()
        {
            //var bounds = BackgroundTilemap.cellBounds;
            //var tiles = BackgroundTilemap.GetTilesBlock(bounds);
            //var newTiles = new TileBase[tiles.Length];

            //for (int x = 0; x < bounds.size.x; x++)
            //{
            //    for (int y = 0; y < bounds.size.y; y++)
            //    {
            //        var tile = tiles[x + y * bounds.size.x];
            //        if (tile is not null)
            //        {
                        
            //        }
            //    }
            //}
            //Debug.Log(bounds);
            //Debug.Log(tiles.Length);
            //Debug.Log(asdf.cellBounds);
            //Debug.Log(asdf.GetTilesBlock(asdf.cellBounds).Length);

        }

        private void Update()
        {

        }

        public void ClaerTilemap()
        {
            BackgroundTilemap.ClearAllTiles();
        }
    }
}