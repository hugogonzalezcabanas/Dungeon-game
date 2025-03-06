class FinalGame
{
    static int damage = 1;
    static bool hasKey = false;
   
    static bool fireSword = false;

    static void Main()
    {
        Console.WriteLine("You enter a dungeon, with three paths opening up to you. Choose which path you'd like to continue on.");
        Console.WriteLine();
        Console.WriteLine("1: Left path | 2: Center path | 3: Right path");
        var choice = Console.ReadKey().Key;
        if(choice == ConsoleKey.D1)
        {
            Main1();
        }
        if(choice == ConsoleKey.D2)
        {
            Main2();
        }
        if(choice == ConsoleKey.D3)
        {
            Main3();
        }

    }
    static void Main1()
    {
        Console.WriteLine("You enter Hugo's path...");
        FindSword();
    }

    static void FindSword() // Beginning of the game
    {
        Console.WriteLine("You found a sword! (+2 Damage)");
        Console.WriteLine("You see two paths: one continues the story, the other leads to a cliff.");
        Console.Write("Choose path (continue/cliff): ");
        string? choice = Console.ReadLine()?.ToLower();

        if (choice == "cliff")
        {
            Console.WriteLine("You fell off the cliff. Game Over.");
            return;
        }
        Console.WriteLine("You move forward into an open area...");
        EncounterEnzo();
    }

    static void EncounterEnzo() // First obstacle
    {
        Console.WriteLine("A giant monster named Enzo appears! (10 Health)");
        Console.Write("Do you fight or run? (fight/run): ");
        string? choice = Console.ReadLine()?.ToLower();

        if (choice == "fight")
        {
            Console.WriteLine("You are not strong enough... Enzo defeats you. Game Over.");
            return;
        }
        Console.WriteLine("You run away and find yourself in a trapped hallway...");
        TrappedHallway();
    }

    static void TrappedHallway() // Hallway
    {
        Console.WriteLine("There are three paths: Spikes, Unstable floor, or Jump over a large hole.");
        Console.Write("Choose (spikes/floor/jump): ");
        string? choice = Console.ReadLine()?.ToLower();

        if (choice == "spikes" || choice == "floor")
        {
            Console.WriteLine("You chose poorly... Game Over.");
            return;
        }
        Console.WriteLine("You successfully jump over the hole and find a sword upgrade and a dungeon key! (+4 Damage)");
        NextPath();
    }

    static void NextPath() // Second path 
    {
        Console.WriteLine("Two paths ahead: one leads back to Enzo, the other continues.");
        Console.Write("Choose (enzo/continue): ");
        string? choice = Console.ReadLine()?.ToLower();

        if (choice == "enzo")
        {
            Console.WriteLine("Enzo is still too strong... Game Over.");
            return;
        }
        Console.WriteLine("You find a body of water, a cramped hallway, and an easy path to a weapon upgrade.");
        ChooseNextObstacle();
    }

    static void ChooseNextObstacle() // Next obstacle 
    {
        Console.Write("Choose (water/hallway/easy): ");
        string? choice = Console.ReadLine()?.ToLower();

        if (choice == "water")
        {
            Console.WriteLine("A shark eats you. Game Over.");
            return;
        }
        if (choice == "hallway")
        {
            Console.WriteLine("The hallway crushes you. Game Over.");
            return;
        }
        Console.WriteLine("You found another weapon upgrade! (+4 Damage) (10 Total)");
        FinalPath();
    }

    static void FinalPath() // Finzalizing the game
    {
        Console.WriteLine("Two paths ahead: One goes back to Enzo, the other continues.");
        Console.Write("Choose (enzo/continue): ");
        string? choice = Console.ReadLine()?.ToLower();

        if (choice == "enzo")
        {
            Console.WriteLine("You are now strong enough! You defeat Enzo and reach the prison.");
        }
        else
        {
            Console.WriteLine("You continue forward into a huge area with a courtyard and a tennis court.");
            TennisOrCourtyard();
        }
    }

    static void TennisOrCourtyard() // tennis and the end of the game
    {
        Console.Write("Choose (courtyard/tennis): ");
        string? choice = Console.ReadLine()?.ToLower();

        if (choice == "courtyard")
        {
            Console.WriteLine("Monsters overwhelm you. Game Over.");
            return;
        }
        Console.WriteLine("You beat Will in a tennis match and reach your brother!");
        Console.WriteLine("You use the key, free your brother, and escape through the front door! YOU WIN!");
    }
    static void Main2()
    {
        Console.WriteLine("You enter a mysterious dungeon.");
        PathSelection();
    }

    static void PathSelection()
    {
        Console.WriteLine("You find an open room with a locked cage containing a Prison Key.");
        Console.WriteLine("There are three paths:");
        Console.WriteLine("1. A dark room");
        Console.WriteLine("2. A path guarded by dungeon knights");
        Console.WriteLine("3. A nice outdoor area");
        string choice = Console.ReadLine();

        if (choice == "1")
            DarkRoom();
        else if (choice == "2")
            GameOver("The knights kill you instantly.");
        else if (choice == "3")
            OutdoorArea(false);
        else
        {
            Console.WriteLine("Invalid choice. Try again.");
            PathSelection();
        }
    }

    static void DarkRoom()
    {
        Console.WriteLine("You enter a dark room filled with zombies. There is a huge damage upgrade (+6 Damage) here.");
        Console.WriteLine("Do you want to fight the zombies or run down the hallway? (fight/run)");
        string choice = Console.ReadLine();

        if (choice == "fight")
        {
            Console.WriteLine("You manage to kill the zombies but you are very weak now.");
            damage += 6;
            TrappedHallway();
        }
        else if (choice == "run")
            TrappedHallway();
        else
        {
            Console.WriteLine("Invalid choice. Try again.");
            DarkRoom();
        }
    }

    static void TrappedHallway()
    {
        Console.WriteLine("You reach a trapped area with spikes, an unstable floor, and a large hole.");
        Console.WriteLine("1. Walk through the spikes");
        Console.WriteLine("2. Step on the unstable floor");
        Console.WriteLine("3. Jump across the hole");
        string choice = Console.ReadLine();

        if (choice == "1" || choice == "2")
            GameOver("You die from the trap.");
        else if (choice == "3")
            OutdoorArea(true);
        else
        {
            Console.WriteLine("Invalid choice. Try again.");
            TrappedHallway();
        }
    }

    static void OutdoorArea(bool fromDarkRoom)
    {
        Console.WriteLine("You reach a nice outdoor area. You find a small damage upgrade (+3 Damage) and a key on a table.");
        damage += 3;
        hasKey = true;
        Console.WriteLine("You can take one of two paths:");
        Console.WriteLine("1. Back to the room with the Prison Key");
        Console.WriteLine("2. Towards a pack of angry guard dogs");
        string choice = Console.ReadLine();

        if (choice == "1")
            PrisonKeyRoom();
        else if (choice == "2")
            GameOver("The guard dogs kill you due to your weakness.");
        else
        {
            Console.WriteLine("Invalid choice. Try again.");
            OutdoorArea(fromDarkRoom);
        }
    }

    static void PrisonKeyRoom()
    {
        Console.WriteLine("You return to the room and use the key to unlock the cage, retrieving the Prison Key.");
        Console.WriteLine("A final boss battle awaits against the dragon Andres!");
        FinalBattle();
    }

    static void FinalBattle()
    {
        Console.WriteLine("You face the dragon Andres!");
        if (damage >= 7)
        {
            Console.WriteLine("You defeat the dragon and enter the prison to rescue your brother.");
            Console.WriteLine("Congratulations! You and your brother escape successfully!");
        }
        else
            GameOver("The dragon kills you. You were not strong enough.");
    }

    static void GameOver(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine("Game Over.");
        Environment.Exit(0);
    }
    static void Main()
    {
        Console.WriteLine("You enter a mysterious dungeon.");
        PathSelection();
    }

    static void PathSelection()
    {
        Console.WriteLine("You find an open room with a locked cage containing a Prison Key.");
        Console.WriteLine("There are three paths:");
        Console.WriteLine("1. A dark room");
        Console.WriteLine("2. A path guarded by dungeon knights");
        Console.WriteLine("3. A nice outdoor area");
        string choice = Console.ReadLine();

        if (choice == "1")
            DarkRoom();
        else if (choice == "2")
            GameOver("The knights kill you instantly.");
        else if (choice == "3")
            OutdoorArea(false);
        else
        {
            Console.WriteLine("Invalid choice. Try again.");
            PathSelection();
        }
    }

    static void DarkRoom()
    {
        Console.WriteLine("You enter a dark room filled with zombies. There is a huge damage upgrade (+6 Damage) here.");
        Console.WriteLine("Do you want to fight the zombies or run down the hallway? (fight/run)");
        string choice = Console.ReadLine();

        if (choice == "fight")
        {
            Console.WriteLine("You manage to kill the zombies but you are very weak now.");
            damage += 6;
            TrappedHallway();
        }
        else if (choice == "run")
            TrappedHallway();
        else
        {
            Console.WriteLine("Invalid choice. Try again.");
            DarkRoom();
        }
    }

    static void TrappedHallway()
    {
        Console.WriteLine("You reach a trapped area with spikes, an unstable floor, and a large hole.");
        Console.WriteLine("1. Walk through the spikes");
        Console.WriteLine("2. Step on the unstable floor");
        Console.WriteLine("3. Jump across the hole");
        string choice = Console.ReadLine();

        if (choice == "1" || choice == "2")
            GameOver("You die from the trap.");
        else if (choice == "3")
            OutdoorArea(true);
        else
        {
            Console.WriteLine("Invalid choice. Try again.");
            TrappedHallway();
        }
    }

    static void OutdoorArea(bool fromDarkRoom)
    {
        Console.WriteLine("You reach a nice outdoor area. You find a small damage upgrade (+3 Damage) and a key on a table.");
        damage += 3;
        hasKey = true;
        Console.WriteLine("You can take one of two paths:");
        Console.WriteLine("1. Back to the room with the Prison Key");
        Console.WriteLine("2. Towards a pack of angry guard dogs");
        string choice = Console.ReadLine();

        if (choice == "1")
            PrisonKeyRoom();
        else if (choice == "2")
            GameOver("The guard dogs kill you due to your weakness.");
        else
        {
            Console.WriteLine("Invalid choice. Try again.");
            OutdoorArea(fromDarkRoom);
        }
    }

    static void PrisonKeyRoom()
    {
        Console.WriteLine("You return to the room and use the key to unlock the cage, retrieving the Prison Key.");
        Console.WriteLine("A final boss battle awaits against the dragon Andres!");
        FinalBattle();
    }

    static void FinalBattle()
    {
        Console.WriteLine("You face the dragon Andres!");
        if (damage >= 7)
        {
            Console.WriteLine("You defeat the dragon and enter the prison to rescue your brother.");
            Console.WriteLine("Congratulations! You and your brother escape successfully!");
        }
        else
            GameOver("The dragon kills you. You were not strong enough.");
    }

    static void GameOver(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine("Game Over.");
        Environment.Exit(0);
    }
    static void Main3()
        {
            Console.WriteLine("You walk further into the dungeon, the damp air signaling your descent. You come across a fork in the road. Heat can be felt coming from the right, and an eerie silence from the left. Which path do you choose?");
            Console.WriteLine("1: Left path | 2: Right path");
            var choice = Console.ReadKey().Key;
            if (choice == ConsoleKey.D1)
            {
                LeftPath();
            }
            if(choice == ConsoleKey.D2)
            {
                RightPath();
            }
            

        }
        static void LeftPath()
        {
            Console.WriteLine();
            Console.WriteLine("As you walk down the path, the clatter of bones can be heard echoing throughout the chamber. A skeleton rises from the ground, ready to attack. Fight or flee?");
            Console.WriteLine("1: Fight the skeleton | 2: Attempt to flee");
            var choice = Console.ReadKey().Key;
            if(choice == ConsoleKey.D1)
            {
                FightSkeleton();
            }
            if(choice == ConsoleKey.D2)
            {
                RetreatSkeleton();
            }
        }
        static void FightSkeleton()
        {
            Console.WriteLine();
            Console.WriteLine("You swing first, and quickly take care of the skeleton.");
            Console.WriteLine();
            Console.WriteLine("You continue down the darkened path, and arrive in a large, open chamber.");
            ChamberTraps();
            
        }
        static void ChamberTraps()
        {
            Console.WriteLine();
            Console.WriteLine("The chamber is in a large circular design, and in the torchlight you are able to make out slots in the ground and in the ceiling. There is a lever in the middle of the room, and a ring of tiling surrounds the outermost path.");
            Console.WriteLine("From where you stand, a small pile of rocks lay scattered about. They are small enough to be thrown.");
            Console.WriteLine();
            Console.WriteLine("1: Walk to the lever | 2: Toss a rock at the ground | 3: Toss a rock at the lever");
            var choice = Console.ReadKey().Key;
            if(choice == ConsoleKey.D1)
            {
                Console.WriteLine();
                Console.WriteLine("As you walk to the lever, the tiles you stand on slightly shift, and spikes fall from the ceiling. You Died.");
                Main();
                
            }
            if(choice == ConsoleKey.D2)
            {
                Console.WriteLine();
                Console.WriteLine("The rock skips across the ground. As it hits one of the tiles, you see a slight, almost unnoticeable shift in the flooring.");
                Console.WriteLine("1: Walk to the lever | 2: Toss a rock at the lever");
                if(choice == ConsoleKey.D1)
                {
                    Console.WriteLine();
                    Console.WriteLine("As you walk to the lever, the tiles you stand on slightly shift, and spikes fall from the ceiling. You Died.");
                    Main();
                }
            }
            if(choice == ConsoleKey.D3)
            {
                Console.WriteLine();
                Console.WriteLine("Surprisingly, the rock finds its target and the lever falls to the other side. A rumbling sound echoes and the spikes in the ceiling lock into place, leaving you free to continue.");
                ThirdRoom();
            }
        }
      
        static void RetreatSkeleton()
        {
            Console.WriteLine();
            Console.WriteLine("You backtrack your way out of the chamber, in no mood to try to fight.");
            Main();
        }

        static void RightPath()
        {
            Console.WriteLine(); 
            Console.WriteLine("The heat grows more and more intense as you continue further down the path. Eventually, you reach an area filled with bubbling lava. There are some rocks that barely peek out of the lava, and you can see an exit on the other end.");
            Console.WriteLine("1: Jump across the rocks | 2: Search for another path | 3: Go back the way you came");
            var choice = Console.ReadKey().Key;
            if(choice == ConsoleKey.D1)
            {
                Console.WriteLine("You jump carefully from rock to rock, making it out on the other side successfully.");
                SwordRoom();
            }
            if(choice == ConsoleKey.D2)
            {
                Console.WriteLine("You look around for another way across. Unfortunately, it looks like the only way across is across the rocks.");
                Console.WriteLine("1: Jump across the rocks | 2: Go back the way you came");
                if(choice == ConsoleKey.D1)
                {
                    Console.WriteLine("You jump carefully from rock to rock, making it out on the other side successfully.");
                    SwordRoom();
                }
                if (choice == ConsoleKey.D2)
                {
                    Console.WriteLine("Deeming the situation too dangerous, you go back the way you came.");
                    Main();
                }
            }
             if (choice == ConsoleKey.D3)
            {
                Console.WriteLine("Deeming the situation too dangerous, you go back the way you came.");
                Main();
            }

        }
        static void SwordRoom()
        {
            Console.WriteLine("As you enter the next chamber, a sword lays discarded in the middle of the room. A warm heat emits from the blade, and it glows a dull red. Looks useful.");
            Console.WriteLine("Congratulations! You have obtained the flame sword!");
            fireSword = true;
            ThirdRoom();
        }
        static void ThirdRoom()
        {
            Console.WriteLine("You enter the next chamber, and are met with the sight of two heavily armored guards. Behind them lays the exit. They brandish their swords at you, clearly not in the mood for talking things through.");
            Console.WriteLine("1: Fight the guards | 2: Run past them");
            var choice = Console.ReadKey().Key;
            if(choice == ConsoleKey.D1)
            {
                if(fireSword == true)
                {
                    Console.WriteLine("Your new sword melts straight through their armor, and you make quick work of the guards, running into the next room.");
                    PreBossRoom();
                }
                if(fireSword == false)
                {
                    Console.WriteLine("Your sword bounces off of their armor, and you are quickly defeated. You Died.");
                    Main();
                }
            }
            if(choice == ConsoleKey.D2)
            {
                Console.WriteLine("The guards' heavy armor prevents them from being able to chase you as you sprint past them. You quickly outrun them, entering the next room");
                PreBossRoom();
            }
        }
        static void PreBossRoom()
        {
            Console.WriteLine("As you enter the room, you can see your brother's prison cell at the end of the next room. An ominous chill sets in as the temperature drops rapidly, no doubt foreshadowing the danger to come. Last chance to turn back.");
            Console.WriteLine("1: Turn back | 2: Press on");
            var choice = Console.ReadKey().Key;
            if(choice == ConsoleKey.D1)
            {
                Console.WriteLine("Your gut tells you something is wrong, and you fall back, deciding to regroup and figure out your next plan of attack.");
                Main();
            }
            if (choice == ConsoleKey.D2)
            {
                Console.WriteLine("Steeling yourself, you walk into the room. A roar echoes as an ice golem approaches.");
                if(fireSword == false)
                {
                    Console.WriteLine("You attempt to fight your way past the golem, but your sword simply deflects off of the ice coating it. In turn, it crushes you beneath its foot. You Died.");
                    Main();
                }
                if(fireSword == true)
                {
                    Console.WriteLine("The new sword you obtained glows bright, and melts straight through the protective ice surrounding the golem. You defeat it and break open the cage doors, freeing your brother.");
                    Console.WriteLine();
                    Console.WriteLine("Congratulations! You beat the game and rescued your brother!");
                    return;
                }
            }

        }
}