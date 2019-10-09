using ChaldeaCommon.Interfaces;
using ChaldeaCommon.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonDataServices
{
    public abstract class BaseJsonDataService<T> : IDataService<T> where T : new()
    {
        protected string fileLocation;

        /// <summary>
        /// Initializes a new instace of the GameDataService
        /// That is bound to a specific file for I/O
        /// </summary>
        /// <param name="fileLocation">The path to the file</param>
        /// <exception cref="FileNotFoundException" />
        /// <exception cref="ArgumentException" />
        protected BaseJsonDataService(string fileLocation)
        {
            if (string.IsNullOrWhiteSpace(fileLocation))
            {
                throw new ArgumentException("fileLocation must be provided");
            }
            if (File.Exists(fileLocation))
            {
                this.fileLocation = fileLocation;
            }
            else
            {
                throw new FileNotFoundException($"{fileLocation} could not be located");
            }
        }

        public virtual Task<T> RetrieveData()
        {
            using var file = File.OpenText(fileLocation);
            using var reader = new JsonTextReader(file);

            var serializer = new JsonSerializer();
            var data = serializer.Deserialize<T>(reader);

            data ??= new T();

            return Task.FromResult(data);
        }

        public virtual Task<bool> SaveData(T data)
        {
            using var file = File.CreateText(fileLocation);

            var serializer = new JsonSerializer()
            {
                Formatting = Formatting.Indented
            };
            serializer.Serialize(file, data);
            return Task.FromResult(true);
        }
    }
}
