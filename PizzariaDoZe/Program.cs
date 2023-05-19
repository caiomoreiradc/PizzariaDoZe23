using System.Configuration;
using System.Data.Common;
using System.Globalization;

namespace PizzariaDoZe
{
    static class Program
    {
        [STAThread]
         static void Main()
        {
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);
            #region Idioma
            string? auxIdiomaRegiao = ConfigurationManager.AppSettings.Get("IdiomaRegiao");

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao!);
            #endregion
            ApplicationConfiguration.Initialize();
            Application.Run(new paginaInicial());
        }
    }
}