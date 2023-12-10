namespace MiningSim
{
    internal class Mining
    {
        public void Run()
        {
            Console.WriteLine("You're in the mines digging for ores. Each day you can mine once. Eating or healing doesnt take time.");
            Console.WriteLine("You can find tresures with food and such. Beware the monsters in the way.");
            Console.WriteLine("How much score can you get?");
            Console.WriteLine();
            // youre in mines digging for worthy ores how much score can you get?
            int stone = 0;
            int coal = 1;
            int iron = 3;
            int copper = 5;
            int gold = 10;
            int diamond = 25;
            int esmerald = 50;
            int ruby = 100;
            int treasure = 150;
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
            bool life = true;
            // score
            int result = 0;
            //rounds                                                        Note to myself: Make random chance of trasure, mobs, and rest system. gn...
            int resultRounds = 0;
            int skip = 0;
            bool EndingScript = true;
            while (life)
            {
                if ((Hunger <= 0) || (Health <= 0))
                {
                    life = false;
                    
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("You've died! Either run out of hunger or health.");
                    Console.WriteLine("Your final score is!: " + result);
                    Console.WriteLine("You survived : " + resultRounds + " days.");
                    Console.WriteLine("Curent hightscore: 1015");
                }
                else
                {
                    Console.WriteLine("Hunger: " + Hunger);
                    Console.WriteLine("Health: " + Health);
                    Console.WriteLine("(Bread/Bandage/Mine)"); // Idea to make a pickaxe that is breakable and branch this idea up a million. exp = crafting, materials
                    Console.Write("Use: "); string Cr = Console.ReadLine();
                    if (Cr == "help")
                    {
                        Console.WriteLine("Bread gives: " + bread + " Hunger");
                        Console.WriteLine("You have: " + breadCount + " Bread");
                        Console.WriteLine("Bandage gives: " + bandage + " Health");
                        Console.WriteLine("You have: " + bandageCount + " Bandage/s");
                        skip++;
                    }

                    if (Cr == "Bread")
                    {
                        if (breadCount == 0)
                        {
                            Console.WriteLine("You don't have any bread left.");
                        }
                        else
                        {
                            Hunger = Hunger + bread;
                            skip++;
                            breadCount--;
                            Console.WriteLine("You have " + breadCount + " Bread left.");
                        }
                    }
                    if (Cr == "Bandage")
                    {
                        if (bandageCount == 0)
                        {
                            
                        }
                        else
                        {
                            Health = Health + bandage;
                            skip++;
                            bandageCount--;
                            Console.WriteLine("You have " + bandageCount + " Bandage/s left.");
                        }
                    }
                    if (Health >= 100)
                    {
                        Health = 100;
                    }
                    if (Hunger >= 50)
                    {
                        Hunger = 50;
                    }
                    if (skip == 1)
                    {
                        Console.WriteLine();
                        skip--;
                    }
                    else
                    {


                        int random2 = random1.Next(1, 61);
                        if (random2 == 1)
                        {
                            Console.WriteLine("You found a treasure!");
                            breadCount++; breadCount++; breadCount++;
                            bandageCount++;
                            result = result + treasure;
                        }
                        int random = rand.Next(1, 165);

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
                        else if ((random == 62) || (random == 63) || (random == 64) || (random == 65) || (random == 66) || (random == 67) || (random == 68) || (random == 69) || (random == 70) || (random == 71) || (random == 72) || (random == 73) ||
                            (random == 74) || (random == 75) || (random == 76) || (random == 77) || (random == 78) || (random == 79) || (random == 80) || (random == 81) || (random == 82) || (random == 83) || (random == 84) || (random == 84) || (random == 85) || (random == 86) || (random == 87) || (random == 88))
                        {
                            result = result + coal;
                            Console.WriteLine("You found coal.");
                        }
                        else
                        {
                            Console.WriteLine("You found nothing.");
                        }




                        Console.WriteLine("Your score: " + result);


                        Hunger--;
                        resultRounds++;
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}