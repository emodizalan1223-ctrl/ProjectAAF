using System;

internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string ujJatek = "i";

        while (ujJatek == "i")
        {
            int player = 0;
            int dealer = 0;
            int card;

            string playerCards = "";
            string dealerCards = "";

            card = random.Next(1, 12);
            player += card;
            playerCards = card.ToString();

            card = random.Next(1, 12);
            player += card;
            playerCards += ", " + card;

            card = random.Next(1, 12);
            dealer += card;
            dealerCards = card.ToString();

            card = random.Next(1, 12);
            dealer += card;
            dealerCards += ", " + card;

            Console.Clear();
            Console.WriteLine("*** BLACKJACK ***");

            Console.WriteLine("\nHúzások:");
            Console.WriteLine("Te:");
            foreach (string x in playerCards.Split(','))
            {
                switch (int.Parse(x))
                {
                    case 1: Console.WriteLine("+-----+\n| 1   |\n|     |\n+-----+"); break;
                    case 11: Console.WriteLine("+-----+\n| A   |\n|     |\n+-----+"); break;
                    case 2: Console.WriteLine("+-----+\n| 2   |\n|     |\n+-----+"); break;
                    case 3: Console.WriteLine("+-----+\n| 3   |\n|     |\n+-----+"); break;
                    case 4: Console.WriteLine("+-----+\n| 4   |\n|     |\n+-----+"); break;
                    case 5: Console.WriteLine("+-----+\n| 5   |\n|     |\n+-----+"); break;
                    case 6: Console.WriteLine("+-----+\n| 6   |\n|     |\n+-----+"); break;
                    case 7: Console.WriteLine("+-----+\n| 7   |\n|     |\n+-----+"); break;
                    case 8: Console.WriteLine("+-----+\n| 8   |\n|     |\n+-----+"); break;
                    case 9: Console.WriteLine("+-----+\n| 9   |\n|     |\n+-----+"); break;
                    case 10: Console.WriteLine("+-----+\n| 10  |\n|     |\n+-----+"); break;
                }
            }
            Console.WriteLine("Osztó:");
            foreach (string y in dealerCards.Split(','))
            {
                switch (int.Parse(y))
                {
                    case 1: Console.WriteLine("+-----+\n| 1   |\n|     |\n+-----+"); break;
                    case 11: Console.WriteLine("+-----+\n| A   |\n|     |\n+-----+"); break;
                    case 2: Console.WriteLine("+-----+\n| 2   |\n|     |\n+-----+"); break;
                    case 3: Console.WriteLine("+-----+\n| 3   |\n|     |\n+-----+"); break;
                    case 4: Console.WriteLine("+-----+\n| 4   |\n|     |\n+-----+"); break;
                    case 5: Console.WriteLine("+-----+\n| 5   |\n|     |\n+-----+"); break;
                    case 6: Console.WriteLine("+-----+\n| 6   |\n|     |\n+-----+"); break;
                    case 7: Console.WriteLine("+-----+\n| 7   |\n|     |\n+-----+"); break;
                    case 8: Console.WriteLine("+-----+\n| 8   |\n|     |\n+-----+"); break;
                    case 9: Console.WriteLine("+-----+\n| 9   |\n|     |\n+-----+"); break;
                    case 10: Console.WriteLine("+-----+\n| 10  |\n|     |\n+-----+"); break;
                }
            }

            Console.WriteLine("\n=== EREDMÉNY ===");
            Console.WriteLine("Te összeged: " + player);
            Console.WriteLine("Osztó összege: " + dealer);

            while (player < 21)
            {
                Console.WriteLine("\nHit vagy Stand? (h/s)");
                string valasz = Console.ReadLine();

                if (valasz == "h")
                {
                    card = random.Next(1, 12);
                    player += card;
                    playerCards += ", " + card;
                }
                else if (valasz == "s")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hiba!");
                }

                Console.Clear();
                Console.WriteLine("*** BLACKJACK ***");

                Console.WriteLine("\nHúzások:");
                Console.WriteLine("Te:");
                foreach (string x in playerCards.Split(','))
                {
                    switch (int.Parse(x))
                    {
                        case 1: Console.WriteLine("+-----+\n| 1   |\n|     |\n+-----+"); break;
                        case 11: Console.WriteLine("+-----+\n| A   |\n|     |\n+-----+"); break;
                        case 2: Console.WriteLine("+-----+\n| 2   |\n|     |\n+-----+"); break;
                        case 3: Console.WriteLine("+-----+\n| 3   |\n|     |\n+-----+"); break;
                        case 4: Console.WriteLine("+-----+\n| 4   |\n|     |\n+-----+"); break;
                        case 5: Console.WriteLine("+-----+\n| 5   |\n|     |\n+-----+"); break;
                        case 6: Console.WriteLine("+-----+\n| 6   |\n|     |\n+-----+"); break;
                        case 7: Console.WriteLine("+-----+\n| 7   |\n|     |\n+-----+"); break;
                        case 8: Console.WriteLine("+-----+\n| 8   |\n|     |\n+-----+"); break;
                        case 9: Console.WriteLine("+-----+\n| 9   |\n|     |\n+-----+"); break;
                        case 10: Console.WriteLine("+-----+\n| 10  |\n|     |\n+-----+"); break;
                    }
                }
                Console.WriteLine("Osztó:");
                foreach (string y in dealerCards.Split(','))
                {
                    switch (int.Parse(y))
                    {
                        case 1: Console.WriteLine("+-----+\n| 1   |\n|     |\n+-----+"); break;
                        case 11: Console.WriteLine("+-----+\n| A   |\n|     |\n+-----+"); break;
                        case 2: Console.WriteLine("+-----+\n| 2   |\n|     |\n+-----+"); break;
                        case 3: Console.WriteLine("+-----+\n| 3   |\n|     |\n+-----+"); break;
                        case 4: Console.WriteLine("+-----+\n| 4   |\n|     |\n+-----+"); break;
                        case 5: Console.WriteLine("+-----+\n| 5   |\n|     |\n+-----+"); break;
                        case 6: Console.WriteLine("+-----+\n| 6   |\n|     |\n+-----+"); break;
                        case 7: Console.WriteLine("+-----+\n| 7   |\n|     |\n+-----+"); break;
                        case 8: Console.WriteLine("+-----+\n| 8   |\n|     |\n+-----+"); break;
                        case 9: Console.WriteLine("+-----+\n| 9   |\n|     |\n+-----+"); break;
                        case 10: Console.WriteLine("+-----+\n| 10  |\n|     |\n+-----+"); break;
                    }
                }

                Console.WriteLine("\n=== EREDMÉNY ===");
                Console.WriteLine("Te összeged: " + player);
                Console.WriteLine("Osztó összege: " + dealer);
            }

            while (player <= 21 && dealer < 17)
            {
                card = random.Next(1, 12);
                dealer += card;
                dealerCards += ", " + card;

                Console.Clear();
                Console.WriteLine("*** BLACKJACK ***");

                Console.WriteLine("\nHúzások:");
                Console.WriteLine("Te:");
                foreach (string x in playerCards.Split(','))
                {
                    switch (int.Parse(x))
                    {
                        case 1: Console.WriteLine("+-----+\n| 1   |\n|     |\n+-----+"); break;
                        case 11: Console.WriteLine("+-----+\n| A   |\n|     |\n+-----+"); break;
                        case 2: Console.WriteLine("+-----+\n| 2   |\n|     |\n+-----+"); break;
                        case 3: Console.WriteLine("+-----+\n| 3   |\n|     |\n+-----+"); break;
                        case 4: Console.WriteLine("+-----+\n| 4   |\n|     |\n+-----+"); break;
                        case 5: Console.WriteLine("+-----+\n| 5   |\n|     |\n+-----+"); break;
                        case 6: Console.WriteLine("+-----+\n| 6   |\n|     |\n+-----+"); break;
                        case 7: Console.WriteLine("+-----+\n| 7   |\n|     |\n+-----+"); break;
                        case 8: Console.WriteLine("+-----+\n| 8   |\n|     |\n+-----+"); break;
                        case 9: Console.WriteLine("+-----+\n| 9   |\n|     |\n+-----+"); break;
                        case 10: Console.WriteLine("+-----+\n| 10  |\n|     |\n+-----+"); break;
                    }
                }
                Console.WriteLine("Osztó:");
                foreach (string y in dealerCards.Split(','))
                {
                    switch (int.Parse(y))
                    {
                        case 1: Console.WriteLine("+-----+\n| 1   |\n|     |\n+-----+"); break;
                        case 11: Console.WriteLine("+-----+\n| A   |\n|     |\n+-----+"); break;
                        case 2: Console.WriteLine("+-----+\n| 2   |\n|     |\n+-----+"); break;
                        case 3: Console.WriteLine("+-----+\n| 3   |\n|     |\n+-----+"); break;
                        case 4: Console.WriteLine("+-----+\n| 4   |\n|     |\n+-----+"); break;
                        case 5: Console.WriteLine("+-----+\n| 5   |\n|     |\n+-----+"); break;
                        case 6: Console.WriteLine("+-----+\n| 6   |\n|     |\n+-----+"); break;
                        case 7: Console.WriteLine("+-----+\n| 7   |\n|     |\n+-----+"); break;
                        case 8: Console.WriteLine("+-----+\n| 8   |\n|     |\n+-----+"); break;
                        case 9: Console.WriteLine("+-----+\n| 9   |\n|     |\n+-----+"); break;
                        case 10: Console.WriteLine("+-----+\n| 10  |\n|     |\n+-----+"); break;
                    }
                }

                Console.WriteLine("\n=== EREDMÉNY ===");
                Console.WriteLine("Te összeged: " + player);
                Console.WriteLine("Osztó összege: " + dealer);
            }

            Console.WriteLine();

            if (player > 21)
            {
                Console.WriteLine("Túllépted a 21-et! Az osztó nyert.");
            }
            else if (dealer > 21)
            {
                Console.WriteLine("Az osztó túllépte a 21-et. Te nyertél!");
            }
            else if (player > dealer)
            {
                Console.WriteLine("Te nyertél!");
            }
            else if (player < dealer)
            {
                Console.WriteLine("Az osztó nyert!");
            }
            else
            {
                Console.WriteLine("Döntetlen!");
            }

            Console.WriteLine("\nSzeretnél újra játszani? (i/n)");
            ujJatek = Console.ReadLine().ToLower();
        }

        Console.Clear();
        Console.WriteLine("Köszönöm a játékot!");
        Console.ReadKey();
    }
}