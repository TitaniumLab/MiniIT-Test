using MiniIT.Background;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

namespace MiniIT.PlayArea
{
    public class PlayAreaController : MonoBehaviour
    {
        [SerializeField] private Tilemap background;
        [SerializeField] private BackgroundTypes targetBackgroundType;
        [SerializeField] private float zOffset;
        [SerializeField] private Vector2 gameUnitAnchor;
        private Vector2 cellSize;



        private void Start()
        {
            cellSize = background.layoutGrid.cellSize;






        }
    }
}

