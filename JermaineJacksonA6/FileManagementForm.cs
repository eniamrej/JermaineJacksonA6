
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

        /// <summary>
        /// Handles all the events of my file management form
        /// </summary>
        public FileManagementForm()
        {
            InitializeComponent();
            Books = [];

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

                    MessageBox.Show(@"Data loaded successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error loading file: " + ex.Message);
                }
            }
        }

        private void ExportCsvBtn_Click(object sender, EventArgs e)
        {

            if (Books.Count == 0)
            {
                MessageBox.Show(@"No data loaded.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = @"CSV files (*.csv)|*.csv",
                Title = @"Save as CSV"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    using (StreamWriter writer = File.CreateText(filePath))
                    {
                        writer.WriteLine("Title,Author,Page Length,Genre,Year Published,MSRP");
                        foreach (var book in Books)
                        {
                            writer.WriteLine($"{book.Title},{book.Author},{book.PageLength},{book.Genre},{book.PublishYear},{book.Msrp}");
                        }
                    }
                    MessageBox.Show(@"Data exported successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error exporting data: " + ex.Message);
                }
            }
        }

        private void ExportJsonBtn_Click(object sender, EventArgs e)
        {
            if (Books.Count == 0)
            {
                MessageBox.Show(@"No data loaded.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = @"JSON files (*.json)|*.json",
                Title = @"Save as JSON"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    string json = JsonSerializer.Serialize(Books, options);
                    File.WriteAllText(filePath, json);
                    MessageBox.Show(@"Data exported successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error exporting data: " + ex.Message);
                }
            }
        }

        private void ObjectsCountBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"Loaded {Books.Count} books.");
        }
    }
}
