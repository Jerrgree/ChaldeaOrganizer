using ChaldeaCommon.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChaldeaCommon.Interfaces
{
    public interface IDataService<T>
    {
        Task<T> RetrieveData();

        Task<bool> SaveData(T data);
    }
}
