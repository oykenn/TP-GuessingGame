using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        private Random rand;
        private string[] wordsToChoose = { "Computer", "Printer", "Mouse", "Keyboards", "Internet", "WiFi", "College" };
        private string word;
        private int word_order;

        public Form1()
        {
            InitializeComponent();
            rand = new Random(); // Initialize the Random object in the constructor
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh_words();
            load_word();
        }

        private void load_word()
        {
            if (word_order < wordsToChoose.Length) // Check against wordsToChoose length, not word length
            {
                word = wordsToChoose[word_order].ToUpper();
                int word_length = word.Length;

                // Create the masked word
                StringBuilder maskedWord = new StringBuilder(word_length);
                int masks = word_length / 2;
                ArrayList letter_masks = new ArrayList();

                for (int i = 0; i < masks; i++)
                {
                    bool can_loop = true;
                    do
                    {
                        int rand_num = rand.Next(word_length);
                        if (!letter_masks.Contains(rand_num))
                        {
                            letter_masks.Add(rand_num);
                            can_loop = false;
                        }
                    }
                    while (can_loop);
                }

                // Build the masked word with '?' for masked letters
                for (int i = 0; i < word_length; i++)
                {
                    if (letter_masks.Contains(i))
                    {
                        maskedWord.Append("?");
                    }
                    else
                    {
                        maskedWord.Append(word[i]);
                    }
                }

                lb_mask_word.Text = maskedWord.ToString(); // Display the masked word in the label
            }
            else
            {
                refresh_words(); // Shuffle the words again
                load_word();
            }
        }

        private void refresh_words()
        {
            wordsToChoose = wordsToChoose.OrderBy(x => rand.Next()).ToArray(); // Shuffle the words array
            word_order = 0; // Reset the word order index
        }

        private void tb_guess_Click(object sender, EventArgs e)
        {
            if (tb_guess.Text.Equals("Play Again"))
            {
                word_order++; // Move to the next word
                load_word();
                tb_guess.Text = "Guess"; // Reset the button text
                wrong_guessed_list.Items.Clear(); // Clear the wrong guesses list
            }
            else
            {
                wrong_guessed_list.Items.Add(tb_guess.Text); // Add the wrong guess to the list
                MessageBox.Show("Wrong Guess");
            }

            tb_answer.Text = ""; // Clear the answer textbox
        }
    }
}
