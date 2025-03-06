// using System;

// class Program
// {
//     static int damage = 1;
//     static bool hasKey = false;

//     static void Main()
//     {
//         Console.WriteLine("You enter a mysterious dungeon.");
//         PathSelection();
//     }

//     static void PathSelection()
//     {
//         Console.WriteLine("You find an open room with a locked cage containing a Prison Key.");
//         Console.WriteLine("There are three paths:");
//         Console.WriteLine("1. A dark room");
//         Console.WriteLine("2. A path guarded by dungeon knights");
//         Console.WriteLine("3. A nice outdoor area");
//         string choice = Console.ReadLine();

//         if (choice == "1")
//             DarkRoom();
//         else if (choice == "2")
//             GameOver("The knights kill you instantly.");
//         else if (choice == "3")
//             OutdoorArea(false);
//         else
//         {
//             Console.WriteLine("Invalid choice. Try again.");
//             PathSelection();
//         }
//     }

//     static void DarkRoom()
//     {
//         Console.WriteLine("You enter a dark room filled with zombies. There is a huge damage upgrade (+6 Damage) here.");
//         Console.WriteLine("Do you want to fight the zombies or run down the hallway? (fight/run)");
//         string choice = Console.ReadLine();

//         if (choice == "fight")
//         {
//             Console.WriteLine("You manage to kill the zombies but you are very weak now.");
//             damage += 6;
//             TrappedHallway();
//         }
//         else if (choice == "run")
//             TrappedHallway();
//         else
//         {
//             Console.WriteLine("Invalid choice. Try again.");
//             DarkRoom();
//         }
//     }

//     static void TrappedHallway()
//     {
//         Console.WriteLine("You reach a trapped area with spikes, an unstable floor, and a large hole.");
//         Console.WriteLine("1. Walk through the spikes");
//         Console.WriteLine("2. Step on the unstable floor");
//         Console.WriteLine("3. Jump across the hole");
//         string choice = Console.ReadLine();

//         if (choice == "1" || choice == "2")
//             GameOver("You die from the trap.");
//         else if (choice == "3")
//             OutdoorArea(true);
//         else
//         {
//             Console.WriteLine("Invalid choice. Try again.");
//             TrappedHallway();
//         }
//     }

//     static void OutdoorArea(bool fromDarkRoom)
//     {
//         Console.WriteLine("You reach a nice outdoor area. You find a small damage upgrade (+3 Damage) and a key on a table.");
//         damage += 3;
//         hasKey = true;
//         Console.WriteLine("You can take one of two paths:");
//         Console.WriteLine("1. Back to the room with the Prison Key");
//         Console.WriteLine("2. Towards a pack of angry guard dogs");
//         string choice = Console.ReadLine();

//         if (choice == "1")
//             PrisonKeyRoom();
//         else if (choice == "2")
//             GameOver("The guard dogs kill you due to your weakness.");
//         else
//         {
//             Console.WriteLine("Invalid choice. Try again.");
//             OutdoorArea(fromDarkRoom);
//         }
//     }

//     static void PrisonKeyRoom()
//     {
//         Console.WriteLine("You return to the room and use the key to unlock the cage, retrieving the Prison Key.");
//         Console.WriteLine("A final boss battle awaits against the dragon Andres!");
//         FinalBattle();
//     }

//     static void FinalBattle()
//     {
//         Console.WriteLine("You face the dragon Andres!");
//         if (damage >= 7)
//         {
//             Console.WriteLine("You defeat the dragon and enter the prison to rescue your brother.");
//             Console.WriteLine("Congratulations! You and your brother escape successfully!");
//         }
//         else
//             GameOver("The dragon kills you. You were not strong enough.");
//     }

//     static void GameOver(string message)
//     {
//         Console.WriteLine(message);
//         Console.WriteLine("Game Over.");
//         Environment.Exit(0);
//     }
// }