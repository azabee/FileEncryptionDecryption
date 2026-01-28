namespace FileDecryption
{
    public partial class FileDecryptionForm : Form
    {
        // Dictionary used by BOTH programs (copy/paste same dictionary into Encryptor)
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

        // Reverse dictionary for decryption
                
            
    public FileDecryptionForm()
        {
            InitializeComponent();
        }


        private void DecryptorForm_Load(object sender, EventArgs e)
        {
            // Build codes dictionary
            // Build reverse dictionary for decryption
            Dictionary<char, char> reverse = new Dictionary<char, char>();
            foreach (KeyValuePair<char, char> element in codes)
            {
                reverse[element.Value] = element.Key;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Show open file dialog to select encrypted file
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // Get input file path

            // Validate input file path

            // Perform decryption
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all fields
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }

        // Must match Encryptor EXACTLY
        // method to build codes dictionary
        private Dictionary<char, char> BuildCodesDictionary()
        {

        }

        private Dictionary<char, char> BuildReverseDictionary(Dictionary<char, char> codes)
        {
            // Build reverse dictionary for decryption

            // loop through original codes dictionary
                // If duplicates exist, this will overwrite and break decryption.

            // return reverse dictionary
        }

        private string DecryptFileToString(string inputPath, Dictionary<char, char> reverseCodes)
        {
            // Read input file, return decrypted string
            // set up StringBuilder for output

            // read each character, decrypt, and append to StringBuilder

            // return decrypted string
        }
    }
}
