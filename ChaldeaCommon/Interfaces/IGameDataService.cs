using ChaldeaCommon.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChaldeaCommon.Interfaces
{
    public interface IGameDataService
    {
        GameData RetrieveData();

        bool SaveData(GameData data);
    }
}
