
using JermaineJacksonA6.Model;
using System.Text.Json;

namespace JermaineJacksonA6
{
    /// <summary>
    /// Form the has buttons to choose file and export the file
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FileManagementForm : Form
    {
        private List<Book> Books { get; set; }

        public FileManagementForm()
        {
            InitializeComponent();
            Books = new List<Book>();
   
        }

        private void ChooseFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    string json = File.ReadAllText(filePath);
                    Books = JsonSerializer.Deserialize<List<Book>>(json) ?? throw new InvalidOperationException();

                    foreach (var book in Books)
                    {
                        richTextBox1.AppendText(book + "\n\n");
                    }

                    MessageBox.Show($@"Data loaded successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error loading file: " + ex.Message);
                }
            }
        }
    }
}
