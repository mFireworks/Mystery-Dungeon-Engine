using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.GameEngine.DungeonEngine.DungeonGen
{
    public class Dungeon : MonoBehaviour
    {
        [Tooltip("What is the name of this dungeon?")]
        public string dungeonName = "New Dungeon";
        [Tooltip("A list of all the dungeon levels within this dungeon. We need at least 1 floor to be able to enter this dungeon.")]
        public List<DungeonLevel> dungeonLevels;
        // Add a list of restrictions for this dungeon

        private int currentFloor = 0;

        private void Start()
        {
            EnterDungeon();
        }

        void EnterDungeon()
        {
            currentFloor = 0;
            dungeonLevels[currentFloor].GenerateFloor();
        }

        void GenerateNextFloor()
        {
            ++currentFloor;
            dungeonLevels[currentFloor].GenerateFloor();
        }
    }
}