namespace App_Disk_Pizza_Nostra_Casa
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Fonte e tamanho padr�o da aplica��o.
            Application.SetDefaultFont(new Font(new FontFamily("Arial"), 10f));

            // Inicializando a aplica��o.
            Application.Run(new View.Modules.Login.form_login());

        }

    }

}