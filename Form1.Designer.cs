namespace asm2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            addInvoiceToolStripMenuItem = new ToolStripMenuItem();
            manageInvoicesToolStripMenuItem = new ToolStripMenuItem();
            manageInvoices = new ManagerInvoices();
            addInvoiceForm = new AddInvoice();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addInvoiceToolStripMenuItem, manageInvoicesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(862, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addInvoiceToolStripMenuItem
            // 
            addInvoiceToolStripMenuItem.Name = "addInvoiceToolStripMenuItem";
            addInvoiceToolStripMenuItem.Size = new Size(102, 24);
            addInvoiceToolStripMenuItem.Text = "Add Invoice";
            addInvoiceToolStripMenuItem.Click += addInvoiceToolStripMenuItem_Click;
            // 
            // manageInvoicesToolStripMenuItem
            // 
            manageInvoicesToolStripMenuItem.Name = "manageInvoicesToolStripMenuItem";
            manageInvoicesToolStripMenuItem.Size = new Size(134, 24);
            manageInvoicesToolStripMenuItem.Text = "Manage Invoices";
            manageInvoicesToolStripMenuItem.Click += manageInvoicesToolStripMenuItem_Click;
            // 
            // manageInvoices
            // 
            manageInvoices.Location = new Point(0, 31);
            manageInvoices.Name = "manageInvoices";
            manageInvoices.Size = new Size(862, 508);
            manageInvoices.TabIndex = 1;
            // 
            // addInvoiceForm
            // 
            addInvoiceForm.InvoiceManager = null;
            addInvoiceForm.Location = new Point(0, 31);
            addInvoiceForm.Name = "addInvoiceForm";
            addInvoiceForm.Size = new Size(862, 508);
            addInvoiceForm.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 523);
            Controls.Add(addInvoiceForm);
            Controls.Add(manageInvoices);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Bill Water";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addInvoiceToolStripMenuItem;
        private ToolStripMenuItem manageInvoicesToolStripMenuItem;
        private ManagerInvoices manageInvoices;
        private AddInvoice addInvoiceForm;
    }
}
