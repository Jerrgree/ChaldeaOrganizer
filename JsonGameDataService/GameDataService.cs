using System;
using System.IO;
using ChaldeaCommon.Interfaces;
using ChaldeaCommon.Models;
using Newtonsoft.Json;

namespace JsonGameDataService
{
    public class GameDataService : IGameDataService
    {
        protected string fileLocation;
        public GameDataService(string fileLocation)
        {
            this.fileLocation = fileLocation;
        }
        public GameData RetrieveData()
        {
            try
            {
                using (var file = File.OpenText(fileLocation))
                using (var reader = new JsonTextReader(file))
                {
                    var serializer = new JsonSerializer();
                    return serializer.Deserialize<GameData>(reader);
                }
            }
            catch (FileNotFoundException)
            {

                return new GameData();
            }
        }

        public bool SaveData(GameData data)
        {
            try
            {
                using (var file = File.CreateText(fileLocation))
                {
                    var serializer = new JsonSerializer();
                    serializer.Serialize(file, data);
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
