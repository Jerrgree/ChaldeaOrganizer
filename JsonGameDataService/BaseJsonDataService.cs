using ChaldeaCommon.Interfaces;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace JsonDataServices
{
    public abstract class BaseJsonDataService<T> : IDataService<T> where T : new()
    {
        protected readonly string fileLocation;

        /// <summary>
        /// Initializes a new instace of the GameDataService
        /// That is bound to a specific file for I/O
        /// </summary>
        /// <param name="fileLocation">The path to the file</param>
        /// <exception cref="FileNotFoundException" />
        /// <exception cref="ArgumentException" />
        internal BaseJsonDataService(string fileLocation)
        {
            if (string.IsNullOrWhiteSpace(fileLocation))
            {
                throw new ArgumentException($"{nameof(fileLocation)} must be provided");
            }

            this.fileLocation = File.Exists(fileLocation) ? fileLocation : throw new FileNotFoundException($"{fileLocation} could not be located");
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