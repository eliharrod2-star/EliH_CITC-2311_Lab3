using System.Text;

namespace Translator_Eng_To_PL
{
    public partial class PigLatinTranslator : Form
    {
        public PigLatinTranslator()
        {
            InitializeComponent();

            //accept button setter
            this.AcceptButton = btnTranslate;
        }



        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTranslate_Click_1(object sender, EventArgs e)
        // Translate the input text to Pig latin and display the result in the output text box
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Please enter some text.");
                txtInput.Focus();
                return;
            }
            string[] words = txtInput.Text.Split(' ');
            StringBuilder result = new StringBuilder(); ;

            foreach (string word in words)
            {
                if (word == "")
                {
                    result.Append(" ");
                }
                else
                {
                    result.Append(TranslateWord(word));
                    result.Append(" ");
                }
            }
            txtOutput.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the input and output text boxes
            txtInput.Clear();
            txtOutput.Clear();
            txtInput.Focus();
        }

        private String TranslateWord(string word)
        {
            //remove punctuation from the word
            string punctuation = "";
            string letters = word;

            while (letters.Length > 0 &&
                   !char.IsLetter(letters[letters.Length - 1]))
            {
                punctuation = letters[letters.Length - 1] + punctuation;
                letters = letters.Substring(0, letters.Length - 1);
            }
            //if there are no letters return the orginal word
            if (letters.Length == 0)
            {
                return word;
            }
            //dont trnaslate words that have numbers or symbols
            foreach(char c in letters)
            {
                if (!char.IsLetter(c)) 
                {
                    return word;
                }
            }
            //check and see if word starts with a vowel
            if (IsVowel(letters[0], true))
            {
                return letters + "way" + punctuation;
            }

            // Find the first vowel
            int firstVowel = -1;

            for (int i = 1; i < letters.Length; i++)
            {
                if (IsVowel(letters[i], false))
                {
                    firstVowel = i;
                    break;
                }
            }

            // If there is no vowel, leave the word unchanged
            if (firstVowel == -1)
            {
                return word;
            }

            // Move the consonants to the end
            string translated =
                letters.Substring(firstVowel) +
                letters.Substring(0, firstVowel) +
                "ay";

            // Keep the original capitalization
            translated = MatchCase(letters, translated);

            return translated + punctuation;
        }

        private bool IsVowel(char letter, bool isFirstLetter)
        {
            letter = char.ToLower(letter);

            if (letter == 'a' ||
                letter == 'e' ||
                letter == 'i' ||
                letter == 'o' ||
                letter == 'u')
            {
                return true;
            }

            // Y is a consonant only when it is the first letter
            if (letter == 'y')
            {
                return !isFirstLetter;
            }

            return false;
        }

        private string MatchCase(string original, string translated)
        {
            // All uppercase
            if (original == original.ToUpper())
            {
                return translated.ToUpper();
            }

            // Title case
            if (char.IsUpper(original[0]))
            {
                translated = char.ToUpper(translated[0]) +
                             translated.Substring(1).ToLower();
            }
            else
            {
                // Lowercase
                translated = translated.ToLower();
            }

            return translated;
        }
    }
}
