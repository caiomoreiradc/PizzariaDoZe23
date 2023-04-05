using System.Globalization;

namespace PizzariaDoZe
{
    static class Program
    {
        [STAThread]
         static void Main()
        {
            #region Idioma
            string auxIdiomaRegiao = "en-US"; 
                                              
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao);
            #endregion
            ApplicationConfiguration.Initialize();
            Application.Run(new paginaInicial());
        }

    }
}