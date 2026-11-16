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
            question.Question = "When did Nintendo start as a company?";
            question.Options = ["A) 1889", "B) 1918", "C) 1895", "D) 1950"];
            question.correctAnswer = 1;



        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Cyan);

            Text.Draw(question.Question, 50, 5);
            Text.Draw(question.Options[0], 50, 100);
            Text.Draw(question.Options[1], 50, 140);
            Text.Draw(question.Options[2], 50, 180);
            Text.Draw(question.Options[3], 50, 220);
            Text.Color = Color.Black;
            Text.Size = 30;
        }
    }
}