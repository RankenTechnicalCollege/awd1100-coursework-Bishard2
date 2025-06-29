using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Inventory_Search
{
    public partial class Form1 : Form
    {
        private readonly List<string> _names = new List<string>{
            "The Great Gatsby",
            "War and Peace",
            "Moby-Dick",
            "Hamlet",
            "Pride and Prejudice"
        };
        private readonly List<string> _keywords = new List<string>{
            "eccentric millionaire Jay Gatsby lost love",
            "1812 French invasion Russia",
            "sailor relentless hunt white whale",
            "Shakespearean tragedy young man murder his father",
            "comedic story love life Old England"
        };
        private readonly List<string> _authors = new List<string>{
            "F. Scott Fitzgerald",
            "Leo Tolstoy",
            "Herman Melville",
            "William Shakespeare",
            "Jane Austen"
        };
        private readonly List<string> _isbns = new List<string>{
            "978-1847496140",
            "978-1400079988",
            "978-1503280786",
            "978-1973844402",
            "978-0141439518"
        };
        public Form1()
        {
            InitializeComponent();
            ClearResult();
        }
        private void ClearResult()
        {
            lblName.Text = "Name: ";
            lblDesc.Text = "Description: ";
            lblAuthor.Text = "Author: ";
            lblISBN.Text = "ISBN-13: ";
        }
        private void ShowBook(int idx)
        {
            if (idx < 0 || idx >= _names.Count)
            {
                lblName.Text = "Name: Item not found";
                lblDesc.Text = "Description: Item not found";
                lblAuthor.Text = "Author: Item not found";
                lblISBN.Text = "ISBN-13: Item not found";
            }
            else
            {
                lblName.Text = "Name: " + _names[idx];
                lblDesc.Text = "Description: " + _keywords[idx];
                lblAuthor.Text = "Author: " + _authors[idx];
                lblISBN.Text = "ISBN-13: " + _isbns[idx];
            }
        }
        private int SearchByAuthor(string authorName)
        {
            authorName = authorName?.Trim().ToLower() ?? "";
            for (int i = 0; i < _authors.Count; i++)
                if (_authors[i].ToLower().Contains(authorName))
                    return i;
            return -1;
        }
        private int SearchByKeyword(string keyword)
        {
            keyword = keyword?.Trim().ToLower() ?? "";
            for (int i = 0; i < _names.Count; i++)
            {
                if (_names[i].ToLower().Contains(keyword)
                 || _keywords[i].ToLower().Contains(keyword))
                    return i;
            }
            return -1;
        }
        private int SearchByIsbn(string isbn)
        {
            isbn = isbn?.Trim() ?? "";
            for (int i = 0; i < _isbns.Count; i++)
                if (_isbns[i].Equals(isbn, StringComparison.OrdinalIgnoreCase))
                    return i;
            return -1;
        }
        private void btnAuthor_Click(object sender, EventArgs e)
             => ShowBook(SearchByAuthor(txtAuthor.Text));

        private void btnISBN_Click(object sender, EventArgs e)
             => ShowBook(SearchByIsbn(txtISBN.Text));

        private void btnKeyword_Click(object sender, EventArgs e)
             => ShowBook(SearchByKeyword(txtKeyword.Text));
    }
}
