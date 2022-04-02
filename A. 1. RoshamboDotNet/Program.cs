using System;
using System.Collections.Generic;
using System.Threading;

namespace RoshamboDotNet
{
    /// <summary>
    /// The entry class of the program.
    /// La classe point d'entree du programme.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The available hand signs in the game.
        /// Les signes de la main disponibles dans le jeu.
        /// </summary>
        enum HandSign
        {
            Rock,
            Paper,
            Scissors
        }

        /// <summary>
        /// The available victory results in the game.
        /// Les resultats de victoire possibles.
        /// </summary>
        enum Victory
        {
            Player,
            Computer,
            DrawMatch
        }

        /// <summary>
        /// Association between the hand signs for the program code and their text representation for human beings.
        /// Association des signes de la main pour l'ordinateur avec leur representation textuelle pour les humains.
        /// </summary>
        private static readonly Dictionary<HandSign, string> HandSignNames = new Dictionary<HandSign, string>() {
            { HandSign.Rock, "Rock" },
            { HandSign.Paper, "Paper" },
            { HandSign.Scissors, "Scissors" }
        };

        /// <summary>
        /// Association of the hand signs and the one they defeat.
        /// Association entre un signe de la main et celui contre lequel il gagne.
        /// </summary>
        private static readonly Dictionary<HandSign, HandSign> WinCombinations = new Dictionary<HandSign, HandSign>() {
            { HandSign.Rock, HandSign.Scissors },
            { HandSign.Paper, HandSign.Rock },
            { HandSign.Scissors, HandSign.Paper }
        };

        /// <summary>
        /// Association of a letter and the hand sign for the player choice.
        /// Association d'une lettre avec un signe de la main pour le choix du joueur.
        /// </summary>
        private static readonly Dictionary<char, HandSign> ChoiceCombinations = new Dictionary<char, HandSign>()
        {
            { 'r', HandSign.Rock },
            { 'p', HandSign.Paper },
            { 's', HandSign.Scissors }
        };

        /// <summary>
        /// The random generator used for the computer's choices.
        /// Un generateur de nombres aleatoires pour effectuer le choix par l'ordinateur.
        /// </summary>
        private static Random RandomGenerator;

        /// <summary>
        /// Program entry point.
        /// Point d'entree du programme.
        /// </summary>
        /// <param name="args">
        /// Program arguments (not used here).
        /// Arguments du programme (inutilises dans cet exemple).
        /// </param>
        static void Main(string[] args)
        {
            // Initialize the random number generator with a value that always change: time (in milliseconds)!
            // --
            // Initialisation du generateur de nombres aleatoires avec une valeur qui change a chaque lancement : le temps (en millisecondes).
            RandomGenerator = new Random(DateTime.Now.Millisecond);

            // Display the welcome message in the console (the opened text window).
            // It writes the message on a new line.
            // --
            // Affiche un message de bienvenue dans la console (la fenetre de texte ouverte dans laquelle le programme s'execute).
            // Cette instruction ecrit le texte sur une nouvelle ligne.
            Console.WriteLine("=== Welcome to play Roshambo! ===");

            // Jump only one new line in the console.
            // --
            // Pour sauter une nouvelle ligne, sans texte.
            Console.WriteLine();

            // Think of splitting your code into functions.
            // The goal is to have both small function core but also an "auto-commented" code.
            // For example, as the function is named "DisplayRules" we do not need to add a comment
            // for explaining that we are printing the rules here and we still understand what the code does.
            // --
            // Une chose importante quand on code, c'est de bien separer les differentes parties du programme
            // en fonctions. Ce decoupage permet un code plus leger, plus facile a lire et avec une certaine
            // tendance a s'auto-commenter. Ici par exemple, il n'y a pas besoin d'ajouter un commentaire
            // pour expliquer qu'on affiche les regles du jeu puisque le nom de la fonction nous l'indique deja.
            DisplayRules();
            Console.WriteLine();

            Console.WriteLine("-- START --");

            // Scores of each player, the amount of round each of them has won.
            // --
            // Scores de chaque joueur pour compter le nombre de manche remportees.
            int playerScore = 0;
            int computerScore = 0;

            // Condition of the main loop. Defined to true by default to run the loop at least once.
            // --
            // Condition de la boucle principale. Elle est definie par defaut a "true" (vrai/oui) pour
            // pouvoir executer au moins une fois la bouche principale.
            bool playAgain = true;

            // Program main loop.
            // The program won't stop until the "playAgain" value is turned to false.
            // --
            // La boucle principale du programme.
            // Le programme ne s'arretera pas tant que la valeur "playAgain" ne vaudra pas "false" (= faux/non).
            while (playAgain)
            {
                // Get the player and computer choices and evaluate the victory condition.
                // --
                // On recuperer les choix du joueur et de l'ordinateur pour ensuite voir qui gagne cette manche.
                HandSign playerHandSign = PlayerChoice();
                HandSign computerHandSign = ComputerChoice();
                Victory result = HasPlayerWon(playerHandSign, computerHandSign);

                // Update the scores.
                // --
                // Mise a jour des scores individuels.
                switch (result)
                {
                    case Victory.Player:
                        playerScore += 1;
                        break;
                    case Victory.Computer:
                        computerScore += 1;
                        break;
                    default:
                        break;
                }

                // Here the player can stop the main loop and thus exit the program as expected.
                // --
                // Ici le joueur peut interrompre la boucle principe pour quitter le jeu de la facon
                // attendue par le programme.
                playAgain = AskPlayAgain();
                Console.WriteLine();
            }

            // Print final scores.
            // --
            // On finalise le programme avec l'affichage des scores individuels.
            Console.WriteLine();
            ShowFinalScore(playerScore, computerScore);
            Console.WriteLine();
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("-- END --");

            Console.Write("\n\n");
            Console.WriteLine("Press any key to close this window...");
            Console.ReadKey();
            // End of the program.
            // The memory is freed and data cannot be accessed anymore even if we launch again the game.
            // --
            // Fin du programme.
            // La memoire est liberee et les donnees ne peuvent plus etre accedees y compris si on
            // relance le jeu.
        }

        /// <summary>
        /// Displays the rules of the game.
        /// Affiche les regles du jeu.
        /// </summary>
        static void DisplayRules()
        {
            // Ask the player to display the rules of the game.
            // --
            // On demande au joueur s'il veut afficher les regles du jeu.
            Console.WriteLine("Display the game rules?");
            Console.WriteLine("Press \"Y\" for Yes, any other key to bypass.");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            // Jump a new line in the console.
            // --
            // On saute une ligne pour avoir un affichage plus lisible dans la console.
            Console.WriteLine();

            // Only display the rules if the player presses the Y key.
            // --
            // On n'affiche les regles que si le joueur appuie sur la touche Y.
            if (keyInfo.Key == ConsoleKey.Y)
            {
                Console.WriteLine("-- RULES --");
                Console.WriteLine("You choose a hand sign between:");

                // Parse the HandSign enumeration so that each of its values is displayed.
                // --
                // On parcourt le contenu de l'enumeration HandSign pour afficher chacune de ses valeurs.
                foreach (int value in Enum.GetValues(typeof(HandSign)))
                {
                    // Convert the integer value from the enum HandSign to a HandSign entry.
                    // --
                    // On convertit la valeur numerique de l'enumeration en une valeur de HandSign.
                    HandSign handSign = (HandSign)value;

                    // Get the text corresponding to this hand sign in the dictionary "HandSignNames".
                    // --
                    // On recupere le texte correspondant a cette valeur de HandSign dans le dictionnaire "HandSignNames".
                    string handSignName = HandSignNames[handSign];

                    Console.WriteLine("- " + handSignName);
                }

                Console.WriteLine();
                Console.WriteLine("The computer chooses one of them too.\nThen:");

                // Once again parsing the HandSign enumeration for printing the way to win a round.
                // --
                // Une fois encore on parcourt l'enumeration HandSign, cette fois pour afficher quel
                // signe gagne contre tel autre.
                foreach (int value in Enum.GetValues(typeof(HandSign)))
                {
                    // Get the hand sign name of the winner.
                    // --
                    // On recupere le signe du vainqueur.
                    HandSign winner = (HandSign)value;
                    string winnerName = HandSignNames[winner];

                    // Get the hand sign name against which the "winner" wins from the dictionary "WinCombinations".
                    // --
                    // On regarde quel signe est associe au vainqueur dans le dictionnaire "WinCombinations".
                    HandSign loser = WinCombinations[winner];
                    string loserName = HandSignNames[loser];

                    Console.WriteLine("- " + winnerName + " win(s) against " + loserName);
                }

                Console.WriteLine();
                Console.WriteLine("No one wins nor loses if the two hand signs are the same!");
                // End of the rule explanations.
            }
        }

        /// <summary>
        /// Prompts the player to select a hand sign to play for the current round.
        /// Demande au joueur quel signe de la main il veut jouer dans la manche.
        /// </summary>
        /// <returns>
        /// The hand sign selected by the player.
        /// Le signe de la main selectionne par le joueur.
        /// </returns>
        static HandSign PlayerChoice()
        {
            // Set a default value for the player hand sign (C# requires this
            // initialization in this case).
            // --
            // On definit une valeur par defaut pour le signe de la main
            // (C# nous oblige a faire une initialisation dans ce cas).
            HandSign playerHandSign = HandSign.Paper;

            // Loop until the player press a key associated to a hand sign.
            // --
            // On va boucler tant que le joueur n'aura pas tape sur une des touches
            // du clavier attendue par le programme a cette etape.
            bool validChoice = false;

            while (!validChoice)
            {
                Console.WriteLine("Make your choice:");

                // Display the choices by printing the keyboard key and its corresponding hand sign.
                // --
                // Affiche les choix de signes de la main avec la touche a appuyer correspondante.
                foreach (var choicePair in ChoiceCombinations)
                {
                    char choiceLetter = choicePair.Key;
                    HandSign choiceHandSign = choicePair.Value;
                    string choiceHandSignName = HandSignNames[choiceHandSign];
                    Console.WriteLine("Type " + Char.ToUpper(choiceLetter) + " for the " + choiceHandSignName);
                }

                // Get the player's input key.
                // --
                // On recupere la touche pressee par le joueur.
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                // Get the character (~letter) associated to the pressed key.
                // --
                // On recupere le caractere (~lettre) associee a la touche enfoncee.
                char promptedChar = Char.ToLower(keyInfo.KeyChar);

                if (ChoiceCombinations.ContainsKey(promptedChar))
                {
                    // If the key letter is one of the expected one, override the player hand sign value.
                    // --
                    // Si la letter correspondant a la touche enfoncee est l'une de celles attendues par
                    // le programme, on peut donc remplacee le signe par defaut (au debut de la fonction)
                    // par le symbole correspondant a cette touche.
                    validChoice = true;
                    playerHandSign = ChoiceCombinations[promptedChar];
                }
                else
                {
                    // Otherwise, print a message to inform the player the pressed key is invalid and loop again.
                    // --
                    // Sinon, on informe le joueur que son choix n'est pas possible et on recommence un tour de boucle.
                    Console.WriteLine("Invalid choice! Try again please.");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            string playerHandSignName = HandSignNames[playerHandSign];
            Console.WriteLine("You have selected the " + playerHandSignName + ".");

            // Return the hand sign of the player.
            // --
            // On retourne le signe choisi par le joueur.
            return playerHandSign;
        }

        /// <summary>
        /// Returns a random hand sign for the computer.
        /// Retourne un signe de la main choisi aleatoirement pour l'ordinateur.
        /// </summary>
        /// <returns>
        /// The hand sign of the computer.
        /// Le signe de la main choisi par l'ordinateur.
        /// </returns>
        static HandSign ComputerChoice()
        {
            // Add some delay before executing the next steps of the program.
            // --
            // On met un court delai avant de poursuivre l'execution du programme et
            // eviter que le jeu ne soit trop rapide.
            Thread.Sleep(millisecondsTimeout: 200);
            Console.WriteLine("The computer is choosing a hand sign...");
            Thread.Sleep(millisecondsTimeout: 2000);

            // Get the values so that we can know the amount of possible values.
            // --
            // On recuperer les valeurs de l'enumeration HandSign pour en deduire le nombre
            // de possibilites.
            Array values = Enum.GetValues(typeof(HandSign));
            // Here is the amount of available hand signs.
            // --
            // Le type Array possede une longueur qui nous donne le nombre de valeurs (ici
            // la quantite de signes de la main contenus dans l'enumeration HandSign).
            int maxValue = values.Length;
            // Pick one of the possible values for hand signs.
            // --
            // On prend aleatoirement une des valeurs possibles avec le generateur de nombres aleatoires.
            int randomValue = RandomGenerator.Next(0, maxValue);
            // Convert this picked value to a hand sign.
            // --
            // On convertit la valeur numerique en valeur de HandSign.
            HandSign computerHandSign = (HandSign)randomValue;
            // This is the hand sign the computer has selected!
            // --
            // On peut alors retourner cette valeur!
            return computerHandSign;
        }

        /// <summary>
        /// Get the victory result.
        /// Deduction du resultat de la manche.
        /// </summary>
        /// <param name="playerHandSign">
        /// Hand sign the player's chosen.
        /// Le signe choisi par le joueur.
        /// </param>
        /// <param name="computerHandSign">
        /// Hand sign the computer's chosen.
        /// Le signe choisi par l'ordinateur.
        /// </param>
        /// <returns>
        /// DrawMatch if both players have chosen the same hand sign.
        /// Player if the player wins.
        /// Computer if the computer wins.
        /// --
        /// DrawMatch (match nul) si les deux joueurs ont choisi le meme signe.
        /// Player (joueur) si le joueur humain a gagne.
        /// Computer (ordinateur) si le joueur ordinateur a gagne.
        /// </returns>
        static Victory HasPlayerWon(HandSign playerHandSign, HandSign computerHandSign)
        {
            // For setting back the previous console color.
            // --
            // On conserve la valeur initiale du texte affiche dans la console.
            ConsoleColor oldConsoleColor = Console.ForegroundColor;

            // If both have chosen the same sign.
            // --
            // Si les deux joueur ont pris le meme signe.
            if (playerHandSign == computerHandSign)
            {
                // Pick the name of one of the hand signs as they are equal.
                // --
                // On recuperer le nom du signe d'un des deux joueurs puisque ce sont les memes.
                string handSignName = HandSignNames[playerHandSign];
                // Show the text corresponding to a draw match.
                // --
                // On affiche le texte correspondant a un match nul.

                // Change the color of the console text (it's so cute <3).
                // --
                // On change la couleur du texte de la console (pour faire joli).
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Draw! The two players have chosen " + handSignName + ".");
                // Set back the previous console color.
                // --
                // On restaure la couleur du texte de la console avec celle recuperee au tout debut de la fonction.
                Console.ForegroundColor = oldConsoleColor;
                return Victory.DrawMatch;
            }

            string playerHandSignName = HandSignNames[playerHandSign];
            string computerHandSignName = HandSignNames[computerHandSign];

            bool playerWins = WinCombinations[playerHandSign] == computerHandSign;

            if (playerWins)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations! You've won with " + playerHandSignName + " against " + computerHandSignName + "!!");
                Console.ForegroundColor = oldConsoleColor;
                return Victory.Player;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oh no! The computer's defeated you with " + computerHandSignName + " against your " + playerHandSignName + "...");
                Console.ForegroundColor = oldConsoleColor;
                return Victory.Computer;
            }
        }

        /// <summary>
        /// Prompts the player to play again or not.
        /// Demander au joueur s'il veut encore jouer ou non.
        /// </summary>
        /// <returns>
        /// true if the player plays again; false otherwise.
        /// true (oui) si le joueur veut rejouer; false (non) autrement.
        /// </returns>
        static bool AskPlayAgain()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("Press \"Y\" to continue or any other key to quit the game.");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            return keyInfo.Key == ConsoleKey.Y;
        }

        /// <summary>
        /// Shows the final score.
        /// Afficher le score final.
        /// </summary>
        /// <param name="playerScore">
        /// Score of the player.
        /// Score du joueur (humain).
        /// </param>
        /// <param name="computerScore">
        /// Score of the computer.
        /// Score de l'ordinateur.
        /// </param>
        static void ShowFinalScore(int playerScore, int computerScore)
        {
            // Constant values cannot be changed. They are a good way to name values and
            // make code more understandable.
            // --
            // Les valeurs constantes ne peuvent pas etre modifiees. Elles sont un bon
            // moyen de nommer des valeurs et de rendre le code plus facile a comprendre.
            const int CountLoops = 3;
            const int WaitTime = 300;

            // Console.Write() does not add a line jump after the printed text. You can continue
            // the line by calling another write method (~function) of Console.
            // --
            // Console.Write() n'ajoute pas un saut de ligne apres le texte. Cela signifie qu'on
            // peut continuer a ecrire sur la meme ligne en appelant une autre methode (~fonction)
            // de Console.
            Console.Write("The final score is");

            for (int loop = 0; loop < CountLoops; loop++)
            {
                // Make the program waits for a while (here, 300ms) before printing a dot.
                // Just for fun of course!
                // --
                // On laisse le programme prendre son temps (300ms) pour afficher un point (sur un total
                // de trois points de suspension). Juste pour le plaisir de faire durer le suspense !
                Thread.Sleep(WaitTime);
                Console.Write(".");
            }

            // Again the program waits before displaying the result.
            // --
            // On attend encore un peu avant l'affichage du score, toujours pour s'amuser un peu.
            Thread.Sleep(WaitTime);
            Console.Write(" ");
            Console.Write(playerScore + " - " + computerScore);
            Console.WriteLine();

            // We can customize much more the final message according to the scores!
            // --
            // On pourrait tres bien ajouter d'autres textes selon les scores obtenus par les
            // deux joueurs !
            if (playerScore > computerScore)
            {
                Console.WriteLine("That was AMAZING!");
            }
        }
    }
}
