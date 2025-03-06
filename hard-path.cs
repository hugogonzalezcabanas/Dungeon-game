// using System.Diagnostics;
// using System.Security.AccessControl;
// using System.Security.Cryptography;
// using Microsoft.VisualBasic;


// namespace hardpath

// {

//     class Program
//     {
//         static int attack = 1;
//         static bool fireSword = false;
        
//          static void Main()
//         {
//             Console.WriteLine("You walk further into the dungeon, the damp air signaling your descent. You come across a fork in the road. Heat can be felt coming from the right, and an eerie silence from the left. Which path do you choose?");
//             Console.WriteLine("1: Left path | 2: Right path");
//             var choice = Console.ReadKey().Key;
//             if (choice == ConsoleKey.D1)
//             {
//                 LeftPath();
//             }
//             if(choice == ConsoleKey.D2)
//             {
//                 RightPath();
//             }
            

//         }
//         static void LeftPath()
//         {
//             Console.WriteLine();
//             Console.WriteLine("As you walk down the path, the clatter of bones can be heard echoing throughout the chamber. A skeleton rises from the ground, ready to attack. Fight or flee?");
//             Console.WriteLine("1: Fight the skeleton | 2: Attempt to flee");
//             var choice = Console.ReadKey().Key;
//             if(choice == ConsoleKey.D1)
//             {
//                 FightSkeleton();
//             }
//             if(choice == ConsoleKey.D2)
//             {
//                 RetreatSkeleton();
//             }
//         }
//         static void FightSkeleton()
//         {
//             Console.WriteLine();
//             Console.WriteLine("You swing first, and quickly take care of the skeleton.");
//             Console.WriteLine();
//             Console.WriteLine("You continue down the darkened path, and arrive in a large, open chamber.");
//             ChamberTraps();
            
//         }
//         static void ChamberTraps()
//         {
//             Console.WriteLine();
//             Console.WriteLine("The chamber is in a large circular design, and in the torchlight you are able to make out slots in the ground and in the ceiling. There is a lever in the middle of the room, and a ring of tiling surrounds the outermost path.");
//             Console.WriteLine("From where you stand, a small pile of rocks lay scattered about. They are small enough to be thrown.");
//             Console.WriteLine();
//             Console.WriteLine("1: Walk to the lever | 2: Toss a rock at the ground | 3: Toss a rock at the lever");
//             var choice = Console.ReadKey().Key;
//             if(choice == ConsoleKey.D1)
//             {
//                 Console.WriteLine();
//                 Console.WriteLine("As you walk to the lever, the tiles you stand on slightly shift, and spikes fall from the ceiling. You Died.");
//                 Main();
                
//             }
//             if(choice == ConsoleKey.D2)
//             {
//                 Console.WriteLine();
//                 Console.WriteLine("The rock skips across the ground. As it hits one of the tiles, you see a slight, almost unnoticeable shift in the flooring.");
//                 Console.WriteLine("1: Walk to the lever | 2: Toss a rock at the lever");
//                 if(choice == ConsoleKey.D1)
//                 {
//                     Console.WriteLine();
//                     Console.WriteLine("As you walk to the lever, the tiles you stand on slightly shift, and spikes fall from the ceiling. You Died.");
//                     Main();
//                 }
//             }
//             if(choice == ConsoleKey.D3)
//             {
//                 Console.WriteLine();
//                 Console.WriteLine("Surprisingly, the rock finds its target and the lever falls to the other side. A rumbling sound echoes and the spikes in the ceiling lock into place, leaving you free to continue.");
//                 ThirdRoom();
//             }
//         }
      
//         static void RetreatSkeleton()
//         {
//             Console.WriteLine();
//             Console.WriteLine("You backtrack your way out of the chamber, in no mood to try to fight.");
//             Main();
//         }

//         static void RightPath()
//         {
//             Console.WriteLine(); 
//             Console.WriteLine("The heat grows more and more intense as you continue further down the path. Eventually, you reach an area filled with bubbling lava. There are some rocks that barely peek out of the lava, and you can see an exit on the other end.");
//             Console.WriteLine("1: Jump across the rocks | 2: Search for another path | 3: Go back the way you came");
//             var choice = Console.ReadKey().Key;
//             if(choice == ConsoleKey.D1)
//             {
//                 Console.WriteLine("You jump carefully from rock to rock, making it out on the other side successfully.");
//                 SwordRoom();
//             }
//             if(choice == ConsoleKey.D2)
//             {
//                 Console.WriteLine("You look around for another way across. Unfortunately, it looks like the only way across is across the rocks.");
//                 Console.WriteLine("1: Jump across the rocks | 2: Go back the way you came");
//                 if(choice == ConsoleKey.D1)
//                 {
//                     Console.WriteLine("You jump carefully from rock to rock, making it out on the other side successfully.");
//                     SwordRoom();
//                 }
//                 if (choice == ConsoleKey.D2)
//                 {
//                     Console.WriteLine("Deeming the situation too dangerous, you go back the way you came.");
//                     Main();
//                 }
//             }
//              if (choice == ConsoleKey.D3)
//             {
//                 Console.WriteLine("Deeming the situation too dangerous, you go back the way you came.");
//                 Main();
//             }

//         }
//         static void SwordRoom()
//         {
//             Console.WriteLine("As you enter the next chamber, a sword lays discarded in the middle of the room. A warm heat emits from the blade, and it glows a dull red. Looks useful.");
//             Console.WriteLine("Congratulations! You have obtained the flame sword!");
//             fireSword = true;
//             ThirdRoom();
//         }
//         static void ThirdRoom()
//         {
//             Console.WriteLine("You enter the next chamber, and are met with the sight of two heavily armored guards. Behind them lays the exit. They brandish their swords at you, clearly not in the mood for talking things through.");
//             Console.WriteLine("1: Fight the guards | 2: Run past them");
//             var choice = Console.ReadKey().Key;
//             if(choice == ConsoleKey.D1)
//             {
//                 if(fireSword == true)
//                 {
//                     Console.WriteLine("Your new sword melts straight through their armor, and you make quick work of the guards, running into the next room.");
//                     PreBossRoom();
//                 }
//                 if(fireSword == false)
//                 {
//                     Console.WriteLine("Your sword bounces off of their armor, and you are quickly defeated. You Died.");
//                     Main();
//                 }
//             }
//             if(choice == ConsoleKey.D2)
//             {
//                 Console.WriteLine("The guards' heavy armor prevents them from being able to chase you as you sprint past them. You quickly outrun them, entering the next room");
//                 PreBossRoom();
//             }
//         }
//         static void PreBossRoom()
//         {
//             Console.WriteLine("As you enter the room, you can see your brother's prison cell at the end of the next room. An ominous chill sets in as the temperature drops rapidly, no doubt foreshadowing the danger to come. Last chance to turn back.");
//             Console.WriteLine("1: Turn back | 2: Press on");
//             var choice = Console.ReadKey().Key;
//             if(choice == ConsoleKey.D1)
//             {
//                 Console.WriteLine("Your gut tells you something is wrong, and you fall back, deciding to regroup and figure out your next plan of attack.");
//                 Main();
//             }
//             if (choice == ConsoleKey.D2)
//             {
//                 Console.WriteLine("Steeling yourself, you walk into the room. A roar echoes as an ice golem approaches.");
//                 if(fireSword == false)
//                 {
//                     Console.WriteLine("You attempt to fight your way past the golem, but your sword simply deflects off of the ice coating it. In turn, it crushes you beneath its foot. You Died.");
//                     Main();
//                 }
//                 if(fireSword == true)
//                 {
//                     Console.WriteLine("The new sword you obtained glows bright, and melts straight through the protective ice surrounding the golem. You defeat it and break open the cage doors, freeing your brother.");
//                     Console.WriteLine();
//                     Console.WriteLine("Congratulations! You beat the game and rescued your brother!");
//                     return;
//                 }
//             }

//         }
        
//     }
  
// }