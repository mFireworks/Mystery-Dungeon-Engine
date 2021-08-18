using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Assets.GameEngine.DungeonEngine.DungeonGen.Generators;
using Assets.GameEngine.DungeonEngine.DungeonGen.Enviroment;

namespace Assets.GameEngine.DungeonEngine.DungeonGen
{
    public class DungeonLevel : MonoBehaviour
    {

        [Tooltip("What is the horizontial bounds of this dungeon level?")]
        [Min(10)]
        public int xRadius = 10;
        [Tooltip("What is the vertical bounds of this dungeon level?")]
        [Min(10)]
        public int yRadius = 10;
        [Tooltip("Which enviroment controller is this dungeon using?")]
        public EnviromentController enviroment;
        [Tooltip("What are the different generators that can be used to generate the levels of this dungeon")]
        public List<GeneratorInterface> generators;

        // Deff more information will be needed in here, like creature/item/tile spawn lists

        public void GenerateFloor()
        {
            bool[,] dungeonMap = generators[Random.Range(0, generators.Count - 1)].GenerateLevel(xRadius, yRadius);

            enviroment.produceEnviroment(dungeonMap);
        }
    }
}