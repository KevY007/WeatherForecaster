using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecaster
{
    public static partial class Global
    {
        public static List<Log> Logs = new List<Log>();
    }

    /// <summary>
    /// The user activity log backbone.
    /// </summary>
    public class Log
    {
        /// <summary>
        /// The ID of the Log. Unique.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The user who is concerned with this Log.
        /// </summary>
        public User User { get; set; }


        /// <summary>
        /// The timestamp of the log.
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Summary of the action taken.
        /// </summary>
        public string Action { get; set; }

        public Log(int id, User user, DateTime timestamp, string action) 
        {
            this.Id = id;
            this.User = user;
            this.Timestamp = timestamp;
            this.Action = action;
        }
    }
}
