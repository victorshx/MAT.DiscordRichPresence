using System;
using MAT.DiscordRichPresence.Core;
using Flurl.Http;
using System.Reflection;

namespace MAT.DiscordRichPresence.Helpers
{
    class UpdateCheck
    {
        private class VersionHolder
        {
            public string Version { get; set; }
            public string Info { get; set; }
        }

        /// <summary>
        /// Downloads the data from an online JSON file
        /// Compares JSON file data to assembly version to see if there's an update available
        /// </summary>
        /// <returns>string</returns>
        public static string IsAvailable()
        {
            try
            {
                //Console does not support async-await, have to make it synchronous 
                var newest = Const.VERSION_FILE_URL.GetJsonAsync<VersionHolder>();
                newest.Wait();

                var newestObject = newest.Result;
                if (!string.IsNullOrWhiteSpace(newestObject.Version))
                {
                    Version availableVersion = new Version(newestObject.Version);
                    Version currentVersion = new Version(Assembly.GetExecutingAssembly().GetName().Version.ToString());
                    return currentVersion.CompareTo(availableVersion) < 0 ? newestObject.Info : string.Empty;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return string.Empty;
        }
    }
}
