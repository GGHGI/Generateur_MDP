namespace FormationCS
{
    static internal class Outils
    {
        public static int DemanderNombreNonPositifNonNull(string question)
        {
            return DemandeNombreEntre(question, 1, int.MaxValue);

        }
        public static int DemandeNombreEntre(string question, int min, int max)
        {
            while (true)
            {

                int nombre = DemanderNombre(question);
                if ((nombre >= min) && (nombre <= max))
                {
                    return nombre;
                }
                Console.WriteLine("Erreur, le nombre doit etre compris entre " + min + " et " + max);
                Console.WriteLine();


            }


        }

        public static int DemanderNombre(string question)
        {
            while (true)
            {
                Console.WriteLine(question);
                string reponse = Console.ReadLine();
                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("Erreur : Vous devez rentrer un nombre");
                    Console.WriteLine();
                }

            }
        }
    }
}


