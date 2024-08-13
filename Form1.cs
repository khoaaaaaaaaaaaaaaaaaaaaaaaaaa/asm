namespace asm2
{
    public partial class MainForm : Form
    {
        public Invoice invoiceManager;
        public MainForm()
        {
            InitializeComponent();
            invoiceManager = new Invoice();

            addInvoiceForm.InvoiceManager = invoiceManager;
            manageInvoices.InvoiceManager = invoiceManager;
             addInvoiceForm.Show();
            manageInvoices.Hide();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addInvoice1_Load(object sender, EventArgs e)
        {
           
        }

        private void manageInvoices1_Load(object sender, EventArgs e)
        {

        }

        private void manageInvoices1_Load_1(object sender, EventArgs e)
        {

        }

        private void addInvoice2_Load(object sender, EventArgs e)
        {

        }

        private void manageInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageInvoices.Show();
            addInvoiceForm.Hide();
            manageInvoices.RefreshInvoiceList();
        }

        private void addInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageInvoices.Hide();
            addInvoiceForm.Show();
        }
    }
}
