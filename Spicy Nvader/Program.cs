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
            bool soundMode = true;
            byte gameMode = 0;
            /*  0 = easy
             *  1 = hard
             */
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
                byte currentButton = 0;
                Console.Clear();
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 0);
                Console.Write("Settings");
                ButtonUpdate();
                for (bool exitLoop = false; !exitLoop;)
                {
                    keyPressed = Console.ReadKey(true);
                    if (keyPressed.Key == ConsoleKey.UpArrow && currentButton > 0)
                    {
                        currentButton--;
                        ButtonUpdate();
                    }
                    else if (keyPressed.Key == ConsoleKey.DownArrow && currentButton < 3)
                    {
                        currentButton++;
                        ButtonUpdate();
                    }
                    else if (keyPressed.Key == ConsoleKey.Enter)
                    {
                        switch (currentButton)
                        {
                            case 0:
                                if (soundMode)
                                {
                                    soundMode = false;
                                }
                                else
                                {
                                    soundMode = true;
                                }
                                break;
                            case 1:
                                if (gameMode == 0)
                                {
                                    gameMode = 1;
                                }
                                else
                                {
                                    gameMode = 0;
                                }
                                break;
                            case 2:
                                Menu(1);
                                break;
                        }
                        ButtonUpdate();
                    }
                }

                void ButtonUpdate()
                {
                    Console.SetCursorPosition(0, 2);
                    Console.Write("Sound: ");
                    if (soundMode)
                    {
                        Console.Write("ON ");
                    }
                    else
                    {
                        Console.Write("OFF");
                    }
                    Console.Write("\nDifficulty: ");
                    switch (gameMode)
                    {
                        case 0:
                            Console.Write("PADAWAN");
                            break;
                        case 1:
                            Console.Write("JEDI   ");
                            break;
                    }
                    Console.Write("\nReturn to menu");
                    switch (currentButton)
                    {
                        case 0:
                            Console.SetCursorPosition(0, 2);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Sound: ");
                            if (soundMode)
                            {
                                Console.Write("ON ");
                            }
                            else
                            {
                                Console.Write("OFF");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 1:
                            Console.SetCursorPosition(0, 3);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Difficulty: ");
                            switch (gameMode)
                            {
                                case 0:
                                    Console.Write("PADAWAN");
                                    break;
                                case 1:
                                    Console.Write("JEDI   ");
                                    break;
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 2:
                            Console.SetCursorPosition(0, 4);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Return to menu");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                }
            }
            void About()
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 0);
                Console.Write("About\n\nSpicy Nvader is a school project of developement in C# inspired by the iconic game known as Space Invaders.\n\n");
                Console.SetCursorPosition(Console.WindowWidth - 5, Console.CursorTop);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Menu");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, 0);
                for (bool exitLoop = false; !exitLoop;)
                {
                    keyPressed = Console.ReadKey(true);
                    if (keyPressed.Key == ConsoleKey.Enter)
                    {
                        Menu(2);
                    }
                }
            }
            void Exit()
            {
                Environment.Exit(0);
            }
        }

    }
}
