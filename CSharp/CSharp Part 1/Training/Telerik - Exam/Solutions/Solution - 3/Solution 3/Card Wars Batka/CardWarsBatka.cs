using System;
using System.IO;
using System.Numerics;

class CardWarsBatka
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\sample-input.txt");
        Console.SetIn(reader);
        int  N = int.Parse(Console.ReadLine()); // give number of games in the match (N)
        BigInteger player1HandScore = 0;
        BigInteger player2HandScore = 0;
        BigInteger player1GameHandScore = 0;
        BigInteger player2GameHandScore = 0;
        BigInteger player1MatchGameHandScore = 0;
        BigInteger player2MatchGameHandScore = 0;
        BigInteger gamesWonPlayer1 = 0;
        BigInteger gamesWonPlayer2 = 0;
        for (int k = 0; k < N; k++)
        {
            player1GameHandScore = 0;
            player2GameHandScore = 0;
            string player1Hand1 = Console.ReadLine();
            string player1Hand2 = Console.ReadLine();
            string player1Hand3 = Console.ReadLine();
            string player2Hand1 = Console.ReadLine();
            string player2Hand2 = Console.ReadLine();
            string player2Hand3 = Console.ReadLine();
            string[] player1Hand = { player1Hand1, player1Hand2, player1Hand3 };
            string[] player2Hand = { player2Hand1, player2Hand2, player2Hand3 };
            for (int i = 0; i < 3; i++)
            {
                player1HandScore = 0;
                if (player1Hand[i] == "A")
                {
                    player1HandScore = 1;
                }
                else if (player1Hand[i] == "2")
                {
                    player1HandScore = 10;
                }
                else if (player1Hand[i] == "3")
                {
                    player1HandScore = 9;
                }
                else if (player1Hand[i] == "4")
                {
                    player1HandScore = 8;
                }
                else if (player1Hand[i] == "5")
                {
                    player1HandScore = 7;
                }
                else if (player1Hand[i] == "6")
                {
                    player1HandScore = 6;
                }
                else if (player1Hand[i] == "7")
                {
                    player1HandScore = 5;
                }
                else if (player1Hand[i] == "8")
                {
                    player1HandScore = 4;
                }
                else if (player1Hand[i] == "9")
                {
                    player1HandScore = 3;
                }
                else if (player1Hand[i] == "10")
                {
                    player1HandScore = 2;
                }
                else if (player1Hand[i] == "J")
                {
                    player1HandScore = 11;
                }
                else if (player1Hand[i] == "Q")
                {
                    player1HandScore = 12;
                }
                else if (player1Hand[i] == "K")
                {
                    player1HandScore = 13;
                }
                // check for special cards "Z" and "Y" for player 1
                else if (player1Hand[i] == "Z")
                {
                    player1MatchGameHandScore = player1MatchGameHandScore * 2;
                }
                else if (player1Hand[i] == "Y")
                {
                    player1MatchGameHandScore = player1MatchGameHandScore - 200;
                }
                //calculate point score for the game for player 1
                player1GameHandScore = player1GameHandScore + player1HandScore;
            }
            for (int j = 0; j < 3; j++)
            {
                player2HandScore = 0;
                if (player2Hand[j] == "A")
                {
                    player2HandScore = 1;
                }
                else if (player2Hand[j] == "2")
                {
                    player2HandScore = 10;
                }
                else if (player2Hand[j] == "3")
                {
                    player2HandScore = 9;
                }
                else if (player2Hand[j] == "4")
                {
                    player2HandScore = 8;
                }
                else if (player2Hand[j] == "5")
                {
                    player2HandScore = 7;
                }
                else if (player2Hand[j] == "6")
                {
                    player2HandScore = 6;
                }
                else if (player2Hand[j] == "7")
                {
                    player2HandScore = 5;
                }
                else if (player2Hand[j] == "8")
                {
                    player2HandScore = 4;
                }
                else if (player2Hand[j] == "9")
                {
                    player2HandScore = 3;
                }
                else if (player2Hand[j] == "10")
                {
                    player2HandScore = 2;
                }
                else if (player2Hand[j] == "J")
                {
                    player2HandScore = 11;
                }
                else if (player2Hand[j] == "Q")
                {
                    player2HandScore = 12;
                }
                else if (player2Hand[j] == "K")
                {
                    player2HandScore = 13;
                }
                // check for special cards "Z" and "Y" for player 2
                else if (player2Hand[j] == "Z")
                {
                    
                    player2MatchGameHandScore = player2MatchGameHandScore * 2;
                }
                else if (player2Hand[j] == "Y")
                {
                    player2MatchGameHandScore = player2MatchGameHandScore - 200;
                }
                //calculate point score for the game for player 2
                player2GameHandScore = player2GameHandScore + player2HandScore;
            }
            // check for special card "X"        
            if ((player1Hand1 == "X" || player1Hand2 == "X" || player1Hand3 == "X") & (player2Hand1 == "X" || player2Hand2 == "X" || player2Hand3 == "X"))
            {
                player1MatchGameHandScore = player1MatchGameHandScore + 50;
                player2MatchGameHandScore = player2MatchGameHandScore + 50;
            }
            else if ((player1Hand1 == "X" || player1Hand2 == "X" || player1Hand3 == "X") & (player2Hand1 != "X" & player2Hand2 != "X" & player2Hand3 != "X"))
            {
                Console.Write("X card drawn! Player one wins the match!");
                Environment.Exit(0);

            }
            else if ((player1Hand1 != "X" & player1Hand2 != "X" & player1Hand3 != "X") & (player2Hand1 == "X" || player2Hand2 == "X" || player2Hand3 == "X"))
            {
                Console.Write("X card drawn! Player two wins the match!");
                Environment.Exit(0);
            }

            //check hand score for the game
            if (player1GameHandScore > player2GameHandScore)
            {
                player1MatchGameHandScore = player1MatchGameHandScore + player1GameHandScore;
                gamesWonPlayer1++;
            }
            else if (player1GameHandScore < player2GameHandScore)
            {
                player2MatchGameHandScore = player2MatchGameHandScore + player2GameHandScore;
                gamesWonPlayer2++;
            }
        }

        // check which player is winning
        if (player1MatchGameHandScore > player2MatchGameHandScore)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", player1MatchGameHandScore);
            Console.WriteLine("Games won: {0}", gamesWonPlayer1);
        }
        else if (player1MatchGameHandScore < player2MatchGameHandScore)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", player2MatchGameHandScore);
            Console.WriteLine("Games won: {0}", gamesWonPlayer2);
        }
        else if (player1MatchGameHandScore == player2MatchGameHandScore)
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}",(player1MatchGameHandScore));
        }
    }
}