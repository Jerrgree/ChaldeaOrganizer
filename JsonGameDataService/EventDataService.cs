using System;
using System.Collections.Generic;
using System.Text;
using ChaldeaCommon.Models;
using System.IO;

namespace JsonDataServices
{
    public class EventDataService : BaseJsonDataService<EventData>
    {
        /// <summary>
        /// Initializes a new instace of the GameDataService
        /// That is bound to a specific file for I/O
        /// </summary>
        /// <param name="fileLocation">The path to the file</param>
        /// <exception cref="FileNotFoundException" />
        /// <exception cref="ArgumentException" />
        public EventDataService(string fileLocation) : base(fileLocation) { }
    }
}
