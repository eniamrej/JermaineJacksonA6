
using System.Text.Json.Serialization;

namespace JermaineJacksonA6.Model
{
    /// <summary>
    /// Stores the information from the file about the books
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        /// <value>
        /// The author.
        /// </value>
        [JsonPropertyName("Author")]
        public string Author { get; set; }
        /// <summary>
        /// Gets or sets the length of the page.
        /// </summary>
        /// <value>
        /// The length of the page.
        /// </value>
        [JsonPropertyName("Page Length")]
        public int PageLength { get; set; }
        /// <summary>
        /// Gets or sets the genre.
        /// </summary>
        /// <value>
        /// The genre.
        /// </value>
        [JsonPropertyName("Genre")]
        public string Genre { get; set; }
        /// <summary>
        /// Gets or sets the publishing year.
        /// </summary>
        /// <value>
        /// The publishing year.
        /// </value>
        [JsonPropertyName("Year Published")]
        public int PublishYear { get; set; }
        /// <summary>
        /// Gets or sets the MSRP.
        /// </summary>
        /// <value>
        /// The MSRP.
        /// </value>
        [JsonPropertyName("MSRP")]
        public double Msrp { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="author">The author.</param>
        /// <param name="pageLength">Length of the page.</param>
        /// <param name="genre">The genre.</param>
        /// <param name="publishYear">The publishing year.</param>
        /// <param name="msrp">The MSRP.</param>
        public Book(string title, string author, int pageLength, string genre, int publishYear, double msrp)
        {
            Title = title;
            Author = author;
            PageLength = pageLength;
            Genre = genre;
            PublishYear = publishYear;
            Msrp = msrp;
        }

        /// <summary>
        /// Converts book information to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author}\nPage Length: {PageLength}\nGenre: {Genre}\nPublish Year: {PublishYear}\nMSRP: ${Msrp:F2}";
        }
    }
}
