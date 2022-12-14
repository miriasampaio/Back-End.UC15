namespace Back_ER02.classes
{
    public static class utils
    {
        public static void BarraCarregamento(string texto){
            Console.Clear();
            
            Console.ForegroundColor= ConsoleColor.Black;
            Console.BackgroundColor= ConsoleColor.DarkCyan;

            Console.Write($"{texto}");
            for(int i = 0; i < 8; i++){
            Console.Write($".");
            Thread.Sleep(300);}

            Console.ResetColor();
            Console.Clear();
        }

        public static void VerificarPArquivo(string caminho)
        {
            string pasta = caminho.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))
            {
                using (File.Create(caminho)) {}
            }

        }

    }
}