using System;
using System.IO;
using System.Threading.Tasks;
using ChaldeaCommon.Interfaces;
using ChaldeaCommon.Models;
using Newtonsoft.Json;

namespace JsonGameDataService
{
    public class GameDataService : IDataService<GameData>
    {
        protected string fileLocation;

        /// <summary>
        /// Initializes a new instace of the GameDataService
        /// That is bound to a specific file for I/O
        /// </summary>
        /// <param name="fileLocation">The path to the file</param>
        /// <exception cref="FileNotFoundException" />
        /// <exception cref="ArgumentException" />
        public GameDataService(string fileLocation)
        {
            if (string.IsNullOrWhiteSpace(fileLocation))
            {
                throw new ArgumentException("fileLocation must be provided");
            }
            if (File.Exists(fileLocation))
            {
                this.fileLocation = fileLocation;
            }
            throw new FileNotFoundException($"{fileLocation} could not be located");
        }

        public Task<GameData> RetrieveData()
        {
            using (var file = File.OpenText(fileLocation))
            using (var reader = new JsonTextReader(file))
            {
                var serializer = new JsonSerializer();
                var gameData = serializer.Deserialize<GameData>(reader);
                // Initialize a new object if the file was empty
                gameData ??= new GameData();
                return Task.FromResult(gameData);
            }
        }

        public Task<bool> SaveData(GameData data)
        {
            using (var file = File.CreateText(fileLocation))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
            return Task.FromResult(true);
        }
    }
}
