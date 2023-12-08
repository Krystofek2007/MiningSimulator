namespace MiningSim
{
    internal class Mining
    {
        public void Run()
        {
            // youre in mines digging for worthy ores how much score can you get?
            int stone = 0;
            int coal = 1;
            int iron = 3;
            int copper = 5;
            int gold = 10;
            int diamond = 25;
            int esmerald = 50;
            int ruby = 100;
            //life necessories
            int breadCount = 3;
            int bread = 5;
            int bandageCount = 1;
            int bandage = 25;
            int Health = 100;
            int Hunger = 50;
            // spider. spider boss. batt. rat
            Random rand = new Random();
            Random random1 = new Random();
            bool proceed = true;
            // score
            int result = 0;
            //rounds                                                        Note to myself: Make random chance of trasure, mobs, and rest system. gn...
            int resultRounds = 0;
            while (proceed)
            {
                if ((Hunger <= 0) || (Health <= 0))
                {
                    proceed = false;
                }
                else
                {
                  int random2 = random1.Next(1, 50);
                    if (random2 == 1)
                    {
                        Console.WriteLine();
                    }
                    int random = rand.Next(1, 101);

                    if ((random == 1) || (random == 2) || (random == 3))
                    {
                        result = result + ruby;
                        Console.WriteLine("You found ruby!!!");
                    }
                    else if ((random == 4) || (random == 5) || (random == 6) || (random == 7) || (random == 8))
                    {
                        result = result + esmerald;
                        Console.WriteLine("You found esmerald!");
                    }
                    else if ((random == 9) || (random == 10) || (random == 11) || (random == 12) || (random == 13) || (random == 14) || (random == 15))
                    {
                        result = result + diamond;
                        Console.WriteLine("You found diamond!");
                    }
                    else if ((random == 16) || (random == 17) || (random == 18) || (random == 19) || (random == 20) || (random == 21) || (random == 22) || (random == 23) || (random == 24) || (random == 25) || (random == 26))
                    {
                        result = result + gold;
                        Console.WriteLine("You found gold.");
                    }
                    else if ((random == 27) || (random == 28) || (random == 29) || (random == 30) || (random == 31) || (random == 32) || (random == 33) || (random == 34) || (random == 35) || (random == 36) || (random == 37) || (random == 38) || (random == 39) || (random == 40))
                    {
                        result = result + copper;
                        Console.WriteLine("You found copper.");
                    }
                    else if ((random == 41) || (random == 42) || (random == 43) || (random == 44) || (random == 45) || (random == 46) || (random == 47) || (random == 48) || (random == 49) || (random == 50) || (random == 51) || (random == 52) || (random == 53) || (random == 54) || (random == 55) || (random == 56) || (random == 57) || (random == 58) || (random == 59) || (random == 60) || (random == 61))
                    {
                        result = result + iron;
                        Console.WriteLine("You found iron.");
                    }
                    else if (random == 0)
                    {
                        result = result + coal;
                        Console.WriteLine("You found coal.");
                    }
                    else
                    {
                        Console.WriteLine("You found nothing.");
                    }
                    Console.WriteLine("Your score: " + result);
                }
                Hunger--;
                resultRounds++;
            }
            Console.WriteLine("You've died! Either run out of hunger or health.");
            Console.WriteLine("Your final score is!: " + result);
            Console.WriteLine("You survived : " + resultRounds + " days.");
        }
    }
}
