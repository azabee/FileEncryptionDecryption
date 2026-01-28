namespace FileEncryptionDecryption
{
    public partial class FileEncryptionForm : Form
    {
        // Dictionary used by BOTH programs (copy/paste same dictionary into Decryptor)
        Dictionary<char, char> codes = new Dictionary<char, char>()
        {
            { 'A', '%' }, { 'a', '9' },
            { 'B', '@' }, { 'b', '#' },
            { 'C', '&' }, { 'c', '1' },
            { 'D', '$' }, { 'd', '2' },
            { 'E', '!' }, { 'e', '3' },
            { 'F', '*' }, { 'f', '4' },
            { 'G', '^' }, { 'g', '5' },
            { 'H', '(' }, { 'h', '6' },
            { 'I', ')' }, { 'i', '7' },
            { 'J', '-' }, { 'j', '8' },
            { 'K', '+' }, { 'k', '0' },
            { 'L', '=' }, { 'l', '~' },
            { 'M', '{' }, { 'm', '[' },
            { 'N', '}' }, { 'n', ']' },
            { 'O', ':' }, { 'o', ';' },
            { 'P', '<' }, { 'p', '>' },
            { 'Q', '/' }, { 'q', '?' },
            { 'R', '|' }, { 'r', ',' },
            { 'S', '.' }, { 's', '`' },
            { 'T', '_' }, { 't', '!' },
            { 'U', '"' }, { 'u', '\'' },
            { 'V', 'A' }, { 'v', 'B' },
            { 'W', 'C' }, { 'w', 'D' },
            { 'X', 'E' }, { 'x', 'F' },
            { 'Y', 'G' }, { 'y', 'H' },
            { 'Z', 'I' }, { 'z', 'J' }
        };

        public FileEncryptionForm()
        {
            InitializeComponent();
        }
        // Load event: build codes dictionary
        private void EncryptorForm_Load(object sender, EventArgs e)
        {
            // Build codes dictionary

            // Set default output path

            // Set initial status

        }
        
        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            // Show open file dialog to select input file            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    txtInputPath.Text = sr.ReadToEnd();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Get input and output file paths

            // Validate input file path

            // Perform encryption
            // Update status and notify user
          try
          { 
            StreamWriter outputFile;
            outputFile = File.CreateText("ZombieIpsum.txt");

            outputFile.WriteLine(txtOutputPath.Text);

            outputFile.Close();
          }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void EncryptFile(string inputPath, string outputPath, Dictionary<char, char> codes)
        {
            // Read input file, write encrypted output file
            using (StreamReader reader = new StreamReader(inputPath))
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                while (!reader.EndOfStream)
                {
                    char c = (char)reader.Read();
                    if (codes.ContainsKey(c))
                        writer.Write(codes[c]); //encrypt
                    else
                        writer.Write(c);        //leave unchanged
                }
            }

        }
    }
}
