// Include the namespaces (code libraries) you need below.
using MohawkGame2D;
using System;
using System.Diagnostics;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        QAndA question = new QAndA();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Pixel Quiz");
            Window.SetSize(800, 600);

            //     Setup QAndA
            question.Questions = ["When did Nintendo start as a company?", "In what two regions are slowpoke tails considered delicacies?", "Who is the current longest reigning women's champion?", "What is the most watched Kdrama in North America?", "What was the first popular Horror game?"];
            question.Options = ["1) 1889", "2) 1918", "3) 1895", "4) 1950", "1) Alola/Galar", "2) Hoenn/Johto", "3) Kalos/Paldea", "4)Sinnoh/Unova", "1) Rhea Ripley", "2) Becky Lynch", "3) Bayley", "4) Alexa Bliss", "1)All of us are Dead", "2) Sweet Home", "3) Celebrity", "4) Squid Game", "1) Haunted House", "2) Alien", "3) Bioshock", "4) Resident Evil"];
            question.correctAnswers = [1, 1, 3, 4, 4];



        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Cyan);

            Text.Color = Color.Black;
            Text.Size = 30;
            Text.Draw(question.Questions[0], 50, 5);
            Text.Draw(question.Options[0], 50, 100);
            Text.Draw(question.Options[1], 50, 140);
            Text.Draw(question.Options[2], 50, 180);
            Text.Draw(question.Options[3], 50, 220);
            
           


            if (Input.IsMouseButtonPressed(MouseButton.Left))
            {
                Vector2 mousePos = Input.GetMousePosition();
                if (mousePos.X >= 50 && mousePos.X <= 750)
                {
                    if (mousePos.Y >= 100 && mousePos.Y <= 140)
                    {
                        Console.WriteLine("Option A clicked");
                    }
                    else if (mousePos.Y >= 140 && mousePos.Y <= 180)
                    {
                        Console.WriteLine("Option B clicked");
                    }
                    else if (mousePos.Y >= 180 && mousePos.Y <= 220)
                    {
                        Console.WriteLine("Option C clicked");
                    }
                    else if (mousePos.Y >= 220 && mousePos.Y <= 260)
                    {
                        Console.WriteLine("Option D clicked");

                        if(question.correctAnswers[0] == 1)
                        {
                            Console.WriteLine("Correct answer!");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect answer");
                        }
                        

                        


                     



                    }
                }
            }
        }
    }
}