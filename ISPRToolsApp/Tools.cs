using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace ISPRToolsApp
{
    public class Tools
    {
        public static IConfigurationRoot Configuration;
        public const string AppSettngs = "appSettings.json";

        public static string CodeFolder()
        {
            return Tools.Configuration == null ? "" : Tools.Configuration["CodeFolder"].ToString();
        }

        public static string OriginFolder()
        {
            return Tools.Configuration == null ? "" : Tools.Configuration["OriginFolder"].ToString();
        }
        public static string ExportFolder()
        {
            return Tools.Configuration == null ? "" : Tools.Configuration["ExportFolder"].ToString();
        }

        public static void AddOrUpdateAppSetting<T>(string sectionPathKey, T value)
        {
            try
            {
                var filePath = Path.Combine(AppContext.BaseDirectory, AppSettngs);
                string json = File.ReadAllText(filePath);
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                SetValueRecursively(sectionPathKey, jsonObj, value);

                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, output);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing app settings | {0}", ex.Message);
            }
        }

        private static void SetValueRecursively<T>(string sectionPathKey, dynamic jsonObj, T value)
        {
            // split the string at the first ':' character
            var remainingSections = sectionPathKey.Split(":", 2);

            var currentSection = remainingSections[0];
            if (remainingSections.Length > 1)
            {
                // continue with the procress, moving down the tree
                var nextSection = remainingSections[1];
                SetValueRecursively(nextSection, jsonObj[currentSection], value);
            }
            else
            {
                // we've got to the end of the tree, set the value
                jsonObj[currentSection] = value;
            }
        }
    }
}
