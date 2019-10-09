using ChaldeaCommon.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace JsonDataServices
{
    public class GameDataService : BaseJsonDataService<GameData>
    {
        /// <summary>
        /// Initializes a new instace of the GameDataService
        /// That is bound to a specific file for I/O
        /// </summary>
        /// <param name="fileLocation">The path to the file</param>
        /// <exception cref="FileNotFoundException" />
        /// <exception cref="ArgumentException" />
        public GameDataService(string fileLocation) : base(fileLocation) { }
    }
}
