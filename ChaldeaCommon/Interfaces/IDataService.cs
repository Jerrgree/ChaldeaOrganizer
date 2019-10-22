using System.Threading.Tasks;

namespace ChaldeaCommon.Interfaces
{
    public interface IDataService<T> where T : new()
    {
        /// <summary>
        /// Retrieves stored data. If data does not exist, returns a default empty data
        /// </summary>
        /// <returns></returns>
        Task<T> RetrieveData();

        /// <summary>
        /// Saves data
        /// </summary>
        /// <param name="data">The data to save</param>
        /// <returns></returns>
        Task<bool> SaveData(T data);
    }
}