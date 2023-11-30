using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestTask_KleverensSoft
{
    public partial class FormTask1 : Form
    {
        public FormTask1()
        {
            InitializeComponent();
            textBoxOriginal.Text = string.Empty;
            textBoxCompressed.Text = string.Empty;
        }

        private void ProcessingCompress_Click(object sender, System.EventArgs e)
        {
            bool AreAllLettersSmallAndLatin = true;
            if (textBoxOriginal.Text != string.Empty)
            {             
                for (int i = 0; i < textBoxOriginal.Text.Length; i++)
                {
                    if (!Regex.IsMatch(textBoxOriginal.Text[i].ToString(), @"^[a-z]+$")) 
                        AreAllLettersSmallAndLatin = false;
                }

                if (AreAllLettersSmallAndLatin)
                    Compress();
                else MessageBoxError();
            }
        }

        private void CleanAll_Click(object sender, System.EventArgs e)
        {
            textBoxOriginal.Text = string.Empty;
            textBoxCompressed.Text = string.Empty;
        }

        private void ProcessingDeCompress_Click(object sender, System.EventArgs e)
        {
            bool AreAllLettersSmallAndLatin = true;
            if (textBoxOriginal.Text != string.Empty)
            {
                for (int i = 0; i < textBoxOriginal.Text.Length; i++)
                {
                    if (!Regex.IsMatch(textBoxOriginal.Text[i].ToString(), @"^[a-z0-9]+$") ||
                        char.IsDigit(textBoxOriginal.Text[0]))
                            AreAllLettersSmallAndLatin = false;
                }

                if (AreAllLettersSmallAndLatin)
                    Decompress();
                else MessageBoxError();
            }
        }









        private void Compress()
        {
            StringBuilder compressed = new StringBuilder();
            int count = 1;

            if (textBoxOriginal.Text.Length < 2)
                compressed.Append(textBoxOriginal.Text);
            else
                for (int i = 1; i <= textBoxOriginal.Text.Length; i++)
                {
                    if (i < textBoxOriginal.Text.Length && textBoxOriginal.Text[i] == textBoxOriginal.Text[i - 1])
                        count++;

                    else
                    {
                        compressed.Append(textBoxOriginal.Text[i - 1]);

                        if (count > 1)
                            compressed.Append(count);

                        count = 1;
                    }
                }

            textBoxCompressed.Text = compressed.ToString();
        }

        private void Decompress()
        {
            StringBuilder decompressed = new StringBuilder();
            int i = 0;

            if (textBoxOriginal.Text.Length < 2)
                decompressed.Append(textBoxOriginal.Text);
            else
            while (i < textBoxOriginal.Text.Length) 
            {
                char currentChar = textBoxOriginal.Text[i];
                decompressed.Append(currentChar);

                if (i + 1 < textBoxOriginal.Text.Length && char.IsDigit(textBoxOriginal.Text[i + 1])) 
                {
                    int count = int.Parse(textBoxOriginal.Text[i + 1].ToString());

                    for (int j = 0; j < count - 1; j++) 
                    {
                        decompressed.Append(currentChar);
                    }

                    i++;
                }

                i++;
            }

            textBoxCompressed.Text = decompressed.ToString();
        }

        private void MessageBoxError()
        {
            MessageBox.Show(
                "Неверные начальные данные!",
                "Внимание, ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }
       
    }
}
