using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Inventory.ORMDataModelCode;
using System.Resources;
using System.Collections;
namespace Inventory.Utils
{
    public static class Setup
    {
        private static bool appConfigFound {get; set;}
        public static string server { get; set; }
        public static string user { get; set; }
        public static string password { get; set; }
        public static string database { get; set; }
        private static string ConnectionString;
        private const string resxFile = @"..\..\Resources\StringsResources.resx";
        private static Dictionary<String, String> Messages = new Dictionary<string, string>();

        public static void Settings() {
            ReadStringsResources();
            ReadConfiguration();
            ApplyConfiguration();            
        }
        private static void ReadStringsResources() {
            using (ResXResourceReader resxReader = new ResXResourceReader(resxFile))
            {
                foreach (DictionaryEntry entry in resxReader) {
                    Messages.Add((string)entry.Key, (string)entry.Value);
                }
            
            }
        }

        public static string GetMessage(string key) {
            if(Messages.ContainsKey(key))
                return Messages[key];
            else return string.Empty;
        }
        
        private static void ApplyConfiguration() {
            //connect to database server
            if (appConfigFound)                
                //ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
                ConnectionHelper.Connect(ConnectionString, DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists);
            else
                //ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
                ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists);
            //set Spanish localizer
            DevExpress.XtraGrid.Localization.GridLocalizer.Active = new SpGridLocalizer();
        }
        private static void ReadConfiguration() {
            string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string configFile = System.IO.Path.Combine(appPath, "app.config");
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            System.Configuration.Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            ConnectionStringSettingsCollection connections = config.ConnectionStrings.ConnectionStrings;            
            ConnectionString = string.Empty;
            appConfigFound = false;
            foreach (ConnectionStringSettings connection in connections)
            {
                if (connection.Name == "Inventory.Properties.Settings.connection")
                {   
                    ConnectionString = connection.ConnectionString;
                    appConfigFound = true;
                    string[] parameters = ConnectionString.Split(new char[]{';'});
                    foreach (string parameter in parameters) {
                        int idx = parameter.IndexOf('=');                        
                        string clave = parameter.Substring(0, (idx!=-1)? idx:0).Trim();                        
                        switch (clave.ToLower()) {
                            case "server":
                                server = parameter.Substring(idx + 1);
                                break;
                            case "user id":
                                user = parameter.Substring(idx + 1);
                                break;
                            case "database":
                                database = parameter.Substring(idx + 1);
                                break;
                            case "password":
                                password = parameter.Substring(idx + 1);
                                break;
                        }
                    }
                    break;
                }
            }            
        }
    }
}
