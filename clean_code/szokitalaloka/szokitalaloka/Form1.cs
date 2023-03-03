using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szokitalaloka
{
    public partial class Form1 : Form
    {
        static readonly List<string> words = FileIO.ReadFile("szavak.txt");
        static string randomWord;
        static int guessNumber;

        public Form1()
        {
            InitializeComponent();

            NewGame();
        }

        private void userInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guessNumber++;
                if (userInput.Text.Length != 8)
                {
                    MessageBox.Show("Please type an 8 character long word");
                    return;
                }

                guessLbox.Items.Add($"Guess {guessNumber}:");

                CompareGuess();
            }
        }

        private void CompareGuess()
        {
            string guess = userInput.Text;
            wordLbl.Text = "";

            for (int i = 0; i < guess.Length; i++)
            {
                if (randomWord.Contains(guess[i]))
                {
                    if (guess[i] == randomWord[i])
                    {
                        guessLbox.Items.Add($"{guess[i]}: Correct character, correct place");
                        wordLbl.Text += guess[i];
                    }
                    else
                    {
                        guessLbox.Items.Add($"{guess[i]}: Correct character, wrong place");
                        wordLbl.Text += '?';
                    }
                }
                else
                {
                    guessLbox.Items.Add($"{guess[i]}: The word does not contain this letter");
                    wordLbl.Text += '?';
                }
            }

            // scroll to bottom of listbox
            guessLbox.TopIndex = guessLbox.Items.Count - 1;

            if (wordLbl.Text == randomWord)
            {
                DialogResult result = MessageBox.Show($"You guessed the word in {guessNumber} guesses! Would you like to start a new game?", "Victory", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    NewGame();
                }
                else
                {
                    Application.Exit();
                }
            }

            
        }

        // Gets a new word from the words list and resets the labels, clears the listbox
        private void NewGame()
        {
            randomWord = words[new Random().Next(0, words.Count)];
            wordLbl.Text = "????????";
            label1.Text = randomWord;
            userInput.Text = "";
            guessNumber = 0;
            guessLbox.Items.Clear();
        }

        private void newWord_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
