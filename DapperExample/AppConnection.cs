using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace RepositoryPattern
{
    public static class AppConnection
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    }
}