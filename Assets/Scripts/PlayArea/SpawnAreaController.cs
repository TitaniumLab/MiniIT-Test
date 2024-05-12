using MiniIT.Background;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace MiniIT.PlayArea
{
    public class SpawnAreaController : MonoBehaviour
    {
        [SerializeField] private Tilemap background;
        [SerializeField] private BackgroundTypes areaToSpawn;
        [SerializeField] private GameUnitBundleData gameUnitBundleData;
        [SerializeField] private Vector2 gameUnitAnchor;
        private Vector2 cellSize;

        private List<GameUnitFactory> gameUnitFactories;

        private void Start()
        {
            gameUnitFactories = new List<GameUnitFactory>();

            foreach (GameUnitData unitData in gameUnitBundleData.GameUnitData)
            {
                GameUnitFactory factory = new GameUnitFactory(unitData.UnitPrefab, transform);
                gameUnitFactories.Add(factory);
            }

            var bounds = background.cellBounds;
            var tiles = background.GetTilesBlock(bounds);

            for (int x = 0; x < bounds.size.x; x++)
            {
                for (int y = 0; y < bounds.size.y; y++)
                {
                    var tile = tiles[x + y * bounds.size.x];
                    if (tile is not null)
                    {
                        Debug.Log((tile as BackgroundTile).BackgroundType);
                        GameUnit unit = gameUnitFactories[0].GetUnit();
                        Vector3 totalOffset = new Vector3(cellSize.x * gameUnitAnchor.x, cellSize.y * gameUnitAnchor.y, zOffset);
                        Vector3Int tilemapPos = bounds.position + (Vector3Int)new Vector2Int(x, y);
                        unit.transform.position = background.CellToWorld(tilemapPos) + totalOffset;
                    }
                }
            }
        }
    }
}