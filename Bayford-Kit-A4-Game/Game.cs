// Include the namespaces (code libraries) you need below.
using MohawkGame2D;
using System;
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
            question.Options = ["A) 1889", "B) 1918", "C) 1895", "D) 1950", "Alola/Galar, Hoenn/Johto, Kalos/Paldea, Sinnoh/Unova", "Rhea Ripley, Becky Lynch, Bayley, Alexa Bliss", "All of us are Dead, Sweet Home, Celebrity, Squid Game", "Haunted House, Alien, Bioshock, Resident Evil"];
            question.correctAnswers = [1, 1, 3, 4, 4];



        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Cyan);

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

                        Text.Draw(question.Questions[0], 50, 5);
            Text.Draw(question.Options[0], 50, 100);
            Text.Draw(question.Options[1], 50, 140);
            Text.Draw(question.Options[2], 50, 180);
            Text.Draw(question.Options[3], 50, 220);
            Text.Color = Color.Black;
            Text.Size = 30;

                       
                       


                    }
    }
}