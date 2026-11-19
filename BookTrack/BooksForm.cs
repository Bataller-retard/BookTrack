namespace BookTrack
{
    public partial class BooksForm : Form
    {
        private int nextBookNumber = 1;
        private DataGridViewRow selectedBook;

        public BooksForm()
        {
            InitializeComponent();

            
            btnAddBook.Click -= btnAddBook_Click;
            btnUpdateBook.Click -= btnUpdateBook_Click;
            btnClearBook.Click -= btnClearBook_Click;
            dgvBooks.CellContentClick -= dgvBooks_CellContentClick;

            btnAddBook.Click += btnAddBook_Click;
            btnUpdateBook.Click += btnUpdateBook_Click;
            btnClearBook.Click += btnClearBook_Click;
            dgvBooks.CellClick += dgvBooks_CellContentClick;

            btnDeleteBook.Click += DeleteBook;
            btnSearchBook.Click += (_, _) => FilterBooks(txtSearchBook.Text.Trim());
            btnShowAllBooks.Click += (_, _) =>
            {
                txtSearchBook.Clear();
                FilterBooks(string.Empty);
            };
            btnClose.Click += (_, _) => Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!TryReadDetails(out string title, out string author))
                return;

            string id = $"B{nextBookNumber++:D3}";
            dgvBooks.Rows.Add(id, title, author, cmbCategory.Text, (int)nudCopies.Value);

            txtSearchBook.Clear();
            FilterBooks(string.Empty);
            UpdateBookCount();
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvBooks.Rows[e.RowIndex].IsNewRow)
                return;

            selectedBook = dgvBooks.Rows[e.RowIndex];
            txtBookId.Text = Convert.ToString(selectedBook.Cells[0].Value);
            txtBookTitle.Text = Convert.ToString(selectedBook.Cells[1].Value);
            txtAuthor.Text = Convert.ToString(selectedBook.Cells[2].Value);
            cmbCategory.SelectedItem = selectedBook.Cells[3].Value;
            nudCopies.Value = Convert.ToDecimal(selectedBook.Cells[4].Value);
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (!HasSelectedBook() ||
                !TryReadDetails(out string title, out string author))
                return;

            selectedBook.Cells[1].Value = title;
            selectedBook.Cells[2].Value = author;
            selectedBook.Cells[3].Value = cmbCategory.Text;
            selectedBook.Cells[4].Value = (int)nudCopies.Value;

            FilterBooks(txtSearchBook.Text.Trim());
        }

        private void DeleteBook(object sender, EventArgs e)
        {
            if (!HasSelectedBook())
                return;

            DialogResult answer = MessageBox.Show(
                $"Delete \"{selectedBook.Cells[1].Value}\"?",
                "Delete Book",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (answer != DialogResult.Yes)
                return;

            dgvBooks.Rows.Remove(selectedBook);
            ClearDetails();
            UpdateBookCount();
        }

        private void btnClearBook_Click(object sender, EventArgs e)
        {
            ClearDetails();
        }

        private bool TryReadDetails(out string title, out string author)
        {
            title = txtBookTitle.Text.Trim();
            author = txtAuthor.Text.Trim();

            if (title.Length > 0 && author.Length > 0 &&
                cmbCategory.SelectedIndex >= 0)
                return true;

            MessageBox.Show("Enter a title and author, then select a category.");
            return false;
        }

        private bool HasSelectedBook()
        {
            if (selectedBook != null && selectedBook == dgvBooks.CurrentRow)
                return true;

            MessageBox.Show("Click a book in the table first.");
            return false;
        }

        private void FilterBooks(string search)
        {
            dgvBooks.CurrentCell = null;

            foreach (DataGridViewRow row in dgvBooks.Rows)
            {
                string title = Convert.ToString(row.Cells[1].Value);
                string author = Convert.ToString(row.Cells[2].Value);
                string category = Convert.ToString(row.Cells[3].Value);

                row.Visible = title.Contains(search, StringComparison.OrdinalIgnoreCase)
                    || author.Contains(search, StringComparison.OrdinalIgnoreCase)
                    || category.Contains(search, StringComparison.OrdinalIgnoreCase);
            }

            ClearDetails();
        }

        private void ClearDetails()
        {
            selectedBook = null;
            dgvBooks.ClearSelection();
            txtBookId.Clear();
            txtBookTitle.Clear();
            txtAuthor.Clear();
            cmbCategory.SelectedIndex = -1;
            nudCopies.Value = 0;
            txtBookTitle.Focus();
        }

        private void UpdateBookCount()
        {
            lblBookCount.Text = $"Total books: {dgvBooks.Rows.Count}";
        }

        private void grpBookDetails_Enter(object sender, EventArgs e)
        {
        }
    }
}