using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4
{


    public partial class WebForm1 : System.Web.UI.Page
    {

        protected string Answer
        {
            get
            {
                if (Session["Answer"] == null)
                    Session["Answer"] = GetRandomAnswer();
                return (string)Session["Answer"];
                string input = String.Empty;
                char letter;
                char[] letters = Answer.ToCharArray();
                char[] display = letters;
                int i = 0;
                bool hasRun = false;

                if (hasRun == false)
                {
                    foreach (char l in letters)
                    {
                        display[i] = '_';
                        i++;
                    }
                    hasRun = true;
                }
                answerLb.Text = display.ToString();
            }

        }



        protected int Guesses
        {
            get
            {

                if
                    (Session["Guesses"] == null)
                    Session["Guesses"] = 0;
                return (int)Session["Guesses"];
            }
            set
            {
                Session["Guesses"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            string input = String.Empty;
            char letter;
            char[] letters = Answer.ToCharArray();
            char[] display = letters;
            int i = 0;
            bool hasRun = false;

            if (hasRun == false)
            {
                foreach (char l in letters)
                {
                    display[i] = '_';
                    i++;
                }
                hasRun = true;
            }
            Console.WriteLine("The answer is: " + Answer);
            answerLb.Text = Answer;
            
        }



        protected void fullGuessBtn_Click(object sender, EventArgs e)
        {

            guessLb.Text = "You guessed..." + guessTb.Text;
            if (guessTb.Text.Length > 1)
            {
                if (guessTb.Text == Answer)
                {
                    validLb.Text = ("You got the answer right!! Congratulations!");
                }
                else
                {
                    if (difficultyRB.SelectedValue == "easyBtn")
                    {
                        int lives = 6;
                        Guesses = Guesses + 1;

                        if (Guesses == 6)
                        {
                            validLb.Text = "Game Over!";
                            guessNum.Text = "6/6";
                        }
                        else
                        {
                            hangmanImg.ImageUrl = "~/Images/hangman" + Guesses.ToString() + ".png";

                            guessNum.Text = Guesses.ToString() + "/" + "6";

                            validLb.Text = ("You guessed wrong!");
                        }
                    }
                    if (difficultyRB.SelectedValue == "medBtn")
                    {
                        int lives = 4;
                        Guesses = Guesses + 1;

                        if (Guesses == 4)
                        {
                            validLb.Text = "Game Over!";
                            guessNum.Text = "4/4";
                        }
                        else
                        {
                            hangmanImg.ImageUrl = "~/Images/hangman" + "M" + Guesses.ToString() + ".png";

                            guessNum.Text = Guesses.ToString() + "/" + "4";

                            validLb.Text = ("You guessed wrong!");
                        }
                    }

                    else if (difficultyRB.SelectedValue == "hardBtn")
                    {
                        int lives = 2;

                        Guesses = Guesses + 1;
                        if (Guesses == 2)
                        {
                            validLb.Text = "Game Over!";
                            guessNum.Text = "2/2";
                        }
                        else
                        {
                            hangmanImg.ImageUrl = "~/Images/hangman" + "H" + Guesses.ToString() + ".png";

                            guessNum.Text = Guesses.ToString() + "/" + "2";
                        }
                    }
                    

                }
            }
        }

        protected void letterGuessBtn_Click(object sender, EventArgs e)
        {
            string input = String.Empty;
            char letter;
            char[] letters = Answer.ToCharArray();
            char[] display = letters;
            int i = 0;
            bool hasRun = false;

            if (hasRun == false)
            {
                foreach (char l in letters)
                {
                    display[i] = '_';
                    i++;
                }
                hasRun = true;
            }


         

            input = letterGuess.Text;
            letter = input[0];

            guessLb.Text = ("You guessed..." + letterGuess.Text);
            if (letters.Contains(letter))
            {
                validLb.Text = ("You guessed correctly!");

            }
            else
            { 
                if (difficultyRB.SelectedValue == "easyBtn")
                {
                    int lives = 6;
                    Guesses = Guesses + 1;

                    if (Guesses == 6)
                    {
                        validLb.Text = "Game Over!";
                        guessNum.Text = "6/6";
                    }
                    else
                    {
                        hangmanImg.ImageUrl = "~/Images/hangman" + Guesses.ToString() + ".png";

                        guessNum.Text = Guesses.ToString() + "/" + "6";

                        validLb.Text = ("You guessed wrong!");
                    }
                }
                if (difficultyRB.SelectedValue == "medBtn")
                {
                    int lives = 4;

                    Guesses = Guesses + 1;
                    if (Guesses == 4)
                    {
                        validLb.Text = "Game Over!";
                        guessNum.Text = "4/4";
                    }
                    else
                    {
                        hangmanImg.ImageUrl = "~/Images/hangman" + "M" + Guesses.ToString() + ".png";

                        guessNum.Text = Guesses.ToString() + "/" + "4";

                        validLb.Text = ("You guessed wrong!");
                    }
                }

                else if (difficultyRB.SelectedValue == "hardBtn")
                {
                    int lives = 2;
                    Guesses = Guesses + 1;

                    if (Guesses == 6)
                    {
                        validLb.Text = "Game Over!";
                        guessNum.Text = "4/4";
                    }
                    else
                    {
                        hangmanImg.ImageUrl = "~/Images/hangman" + "H" + Guesses.ToString() + ".png";

                        guessNum.Text = Guesses.ToString() + "/" + "2";
                    }
                }


            }
        }
                    
                
                    
        
               
            
        

        

        private string GetRandomAnswer()
        {
            string[] answers = {"chocolate", "vanilla", "strawberry", "mango", "pecan","mint","caramel","orange","cherry",
                        "melon","grape", "coffee", "oreo","peach","raspberry","cinnamon","banana", "pistachio","lemon","cheesecake"};
            Random rand = new Random();
            return answers[rand.Next(0, answers.Length)];
        }

 




        

        }
    }



