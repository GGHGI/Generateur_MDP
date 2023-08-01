using FormationCS;

namespace generateurdemotdepasse
{
    class Program
    {

        static void Main(string[] args)

        {

            const int Nbdemotdepasse = 10;


            int longueurmotdepasse = Outils.DemanderNombreNonPositifNonNull("longueur du\n" +
                "mot de passe : \n"
               );

            int choixAlphabet = Outils.DemandeNombreEntre("Que souhaitez vous dans votre mot de passe ? \n" +
                "1 - minuscule\n" +
                "2 - majuscule\n" +
                "3- caractere speciaux et chiffre\n" +
                "4 - caractere, chiffres, et caracteres speciaux\n" +
                "Votre choix : ", 1, 4);
            Console.WriteLine();


            string minuscules = " abcdefghijklmopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "123456789";
            string caracteresSpeciaux = "!?=#";
            string alphabet = minuscules + majuscules + chiffres + caracteresSpeciaux;


            string motdepasse = "";

            Random rand = new Random();

            if (choixAlphabet == 1)

            {
                alphabet = minuscules;
            }
            else if (choixAlphabet == 2)
            {
                alphabet = majuscules;
            }
            else if (choixAlphabet == 3)
            {
                alphabet = chiffres + caracteresSpeciaux;
            }
            else if (choixAlphabet == 4)
            {
                alphabet = chiffres + caracteresSpeciaux + majuscules + minuscules;
            }

            int longueurAlphabet = alphabet.Length; /*on initialise toujours apres le choix du client*/
            int index = 0;

            for (int j = 0; j < Nbdemotdepasse; j++)
            {
                motdepasse = ""; /* je reinitialise la boucle à chaque tour pour avoir toujours le meme chiffre au motdepasse*/
                for (int i = 0; i < longueurmotdepasse; i++)
                {

                    index = rand.Next(0, longueurAlphabet);
                    motdepasse += alphabet[index];


                }
                Console.WriteLine("mot de passe:" + motdepasse);
                Console.WriteLine();
            }




            /*

            string motDePasse = "";
            motDePasse += alphabet[index];
            Console.WriteLine(motDePasse);*/
        }
    }
}