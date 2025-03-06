// using System;

// class AlfredDungeon
// {
//     static void Main()
//     {
//         Console.WriteLine("You enter Hugo's path...");
//         FindSword();
//     }

//     static void FindSword() // Beginning of the game
//     {
//         Console.WriteLine("You found a sword! (+2 Damage)");
//         Console.WriteLine("You see two paths: one continues the story, the other leads to a cliff.");
//         Console.Write("Choose path (continue/cliff): ");
//         string? choice = Console.ReadLine()?.ToLower();

//         if (choice == "cliff")
//         {
//             Console.WriteLine("You fell off the cliff. Game Over.");
//             return;
//         }
//         Console.WriteLine("You move forward into an open area...");
//         EncounterEnzo();
//     }

//     static void EncounterEnzo() // First obstacle
//     {
//         Console.WriteLine("A giant monster named Enzo appears! (10 Health)");
//         Console.Write("Do you fight or run? (fight/run): ");
//         string? choice = Console.ReadLine()?.ToLower();

//         if (choice == "fight")
//         {
//             Console.WriteLine("You are not strong enough... Enzo defeats you. Game Over.");
//             return;
//         }
//         Console.WriteLine("You run away and find yourself in a trapped hallway...");
//         TrappedHallway();
//     }

//     static void TrappedHallway() // Hallway
//     {
//         Console.WriteLine("There are three paths: Spikes, Unstable floor, or Jump over a large hole.");
//         Console.Write("Choose (spikes/floor/jump): ");
//         string? choice = Console.ReadLine()?.ToLower();

//         if (choice == "spikes" || choice == "floor")
//         {
//             Console.WriteLine("You chose poorly... Game Over.");
//             return;
//         }
//         Console.WriteLine("You successfully jump over the hole and find a sword upgrade and a dungeon key! (+4 Damage)");
//         NextPath();
//     }

//     static void NextPath() // Second path 
//     {
//         Console.WriteLine("Two paths ahead: one leads back to Enzo, the other continues.");
//         Console.Write("Choose (enzo/continue): ");
//         string? choice = Console.ReadLine()?.ToLower();

//         if (choice == "enzo")
//         {
//             Console.WriteLine("Enzo is still too strong... Game Over.");
//             return;
//         }
//         Console.WriteLine("You find a body of water, a cramped hallway, and an easy path to a weapon upgrade.");
//         ChooseNextObstacle();
//     }

//     static void ChooseNextObstacle() // Next obstacle 
//     {
//         Console.Write("Choose (water/hallway/easy): ");
//         string? choice = Console.ReadLine()?.ToLower();

//         if (choice == "water")
//         {
//             Console.WriteLine("A shark eats you. Game Over.");
//             return;
//         }
//         if (choice == "hallway")
//         {
//             Console.WriteLine("The hallway crushes you. Game Over.");
//             return;
//         }
//         Console.WriteLine("You found another weapon upgrade! (+4 Damage) (10 Total)");
//         FinalPath();
//     }

//     static void FinalPath() // Finzalizing the game
//     {
//         Console.WriteLine("Two paths ahead: One goes back to Enzo, the other continues.");
//         Console.Write("Choose (enzo/continue): ");
//         string? choice = Console.ReadLine()?.ToLower();

//         if (choice == "enzo")
//         {
//             Console.WriteLine("You are now strong enough! You defeat Enzo and reach the prison.");
//         }
//         else
//         {
//             Console.WriteLine("You continue forward into a huge area with a courtyard and a tennis court.");
//             TennisOrCourtyard();
//         }
//     }

//     static void TennisOrCourtyard() // tennis and the end of the game
//     {
//         Console.Write("Choose (courtyard/tennis): ");
//         string? choice = Console.ReadLine()?.ToLower();

//         if (choice == "courtyard")
//         {
//             Console.WriteLine("Monsters overwhelm you. Game Over.");
//             return;
//         }
//         Console.WriteLine("You beat Will in a tennis match and reach your brother!");
//         Console.WriteLine("You use the key, free your brother, and escape through the front door! YOU WIN!");
//     }
// }

