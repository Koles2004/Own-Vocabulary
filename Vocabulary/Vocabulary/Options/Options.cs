using System.Configuration;

namespace Vocabulary.Options
{
    public static class Options
    {
        public static string ConnectionString
        {
            get
            {
                // default Connection String
                string defaultConnectionString = "Data Source=(local);Initial Catalog=Vocabulary;Integrated Security=True";

                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["Vocabulary"];

                return settings != null ? settings.ConnectionString : defaultConnectionString;
            }
        }
    }
}