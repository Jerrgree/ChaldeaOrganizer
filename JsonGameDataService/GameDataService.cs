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
        public GameDataService(string fileLocation)
        {
            this.fileLocation = fileLocation;
        }
        public Task<GameData> RetrieveData()
        {
            try
            {
                using (var file = File.OpenText(fileLocation))
                using (var reader = new JsonTextReader(file))
                {
                    var serializer = new JsonSerializer();
                    return Task.FromResult(serializer.Deserialize<GameData>(reader));
                }
            }
            catch (FileNotFoundException)
            {
                return Task.FromResult(new GameData());
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
