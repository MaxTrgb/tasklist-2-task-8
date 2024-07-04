namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            int vowels = await getVowelsAsync(text);
            int consonants = await getConsonantsAsync(text);
            int symbols = await getSymbolsAsync(text);

            label2.Text = "Vowels number: " + vowels.ToString();
            label3.Text = "Consonants number: " + consonants.ToString();
            label4.Text = "Symbols number: " + symbols.ToString();
        }

        private Task<int> getVowelsAsync(string text)
        {
            return Task.Run(() => getVowels(text));

        }
        private int getVowels(string text)
        {
            string vowels = "aeiouAEIOU";
            int result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (text[i] == vowels[j])
                    {
                        result ++;
                    }
                }
            }
            return result;
        }
        private Task<int> getConsonantsAsync(string text)
        {
            return Task.Run(() => getConsonants(text));
        }
        private int getConsonants(string text)
        {
            string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
            int result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < consonants.Length; j++)
                {
                    if (text[i] == consonants[j])
                    {
                        result++;
                    }
                }
            }
            return result;
        }

        private Task<int> getSymbolsAsync(string text)
        {
            return Task.Run(() => getSymbols(text));
        }

        private int getSymbols(string text)
        {
            string symbols = "!@#$%^&*()_+{}|:<>?-=[];',./";
            int result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < symbols.Length; j++)
                {
                    if (text[i] == symbols[j])
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
