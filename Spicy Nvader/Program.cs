using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spicy_Nvader
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyPressed;
            Menu(0);
            void Menu(byte currentButton)
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 0);
                Console.Write("Spicy Nvader");
                ButtonUpdate();
                for (bool exitLoop = false; !exitLoop;)
                {
                    keyPressed = Console.ReadKey(true);
                    if (keyPressed.Key == ConsoleKey.UpArrow && currentButton > 0)
                    {
                        currentButton--;
                        ButtonUpdate();
                    }
                    else if (keyPressed.Key == ConsoleKey.DownArrow && currentButton <3)
                    {
                        currentButton++;
                        ButtonUpdate();
                    }
                    else if (keyPressed.Key == ConsoleKey.Enter)
                    {
                        switch (currentButton)
                        {
                            case 0:
                                Play();
                                break;
                            case 1:
                                Settings();
                                break;
                            case 2:
                                About();
                                break;
                            case 3:
                                Exit();
                                break;
                        }
                    }
                }

                void ButtonUpdate ()
                {
                    Console.SetCursorPosition(0, 2);
                    Console.Write("Play\nSettings\nAbout\nExit");
                    switch (currentButton)
                    {
                        case 0:
                        Console.SetCursorPosition(0, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Play");
                        Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 1:
                            Console.SetCursorPosition(0, 3);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Settings");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 2:
                            Console.SetCursorPosition(0, 4);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("About");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 3:
                            Console.SetCursorPosition(0, 5);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Exit");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                }
            }
            void Play()
            {
            }
            void Settings()
            {
            }
            void About()
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 0);
                Console.Write("Spicy Nvader\n\nSpicy Nvader is a school project of developement in C# inspired by the iconic game known as Space Invaders.\n\n");
                Console.SetCursorPosition(Console.WindowWidth)
            }
            void Exit()
            {
                Environment.Exit(0);
            }
        }

    }
}
