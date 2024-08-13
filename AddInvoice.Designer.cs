namespace asm2
{
    partial class AddInvoice
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customerCodeInput = new TextBox();
            lastmonthNumberInput = new TextBox();
            customerNameInput = new TextBox();
            NumberofpeopleInput = new TextBox();
            thisMonthNumberInput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label1 = new Label();
            label5 = new Label();
            customerTypeCombobox = new ComboBox();
            currentMonthCombobox = new ComboBox();
            label7 = new Label();
            calculateButton = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            totalLabel = new Label();
            consumptionLabel = new Label();
            priceLabel = new Label();
            VATLabel = new Label();
            envFeeLabel = new Label();
            label18 = new Label();
            subtotalLabel = new Label();
            SuspendLayout();
            // 
            // customerCodeInput
            // 
            customerCodeInput.Location = new Point(16, 41);
            customerCodeInput.Name = "customerCodeInput";
            customerCodeInput.Size = new Size(227, 27);
            customerCodeInput.TabIndex = 0;
            // 
            // lastmonthNumberInput
            // 
            lastmonthNumberInput.Location = new Point(8, 186);
            lastmonthNumberInput.Name = "lastmonthNumberInput";
            lastmonthNumberInput.Size = new Size(231, 27);
            lastmonthNumberInput.TabIndex = 0;
            // 
            // customerNameInput
            // 
            customerNameInput.Location = new Point(16, 117);
            customerNameInput.Name = "customerNameInput";
            customerNameInput.Size = new Size(227, 27);
            customerNameInput.TabIndex = 0;
            // 
            // NumberofpeopleInput
            // 
            NumberofpeopleInput.Location = new Point(313, 117);
            NumberofpeopleInput.Name = "NumberofpeopleInput";
            NumberofpeopleInput.Size = new Size(227, 27);
            NumberofpeopleInput.TabIndex = 0;
            // 
            // thisMonthNumberInput
            // 
            thisMonthNumberInput.Location = new Point(8, 267);
            thisMonthNumberInput.Name = "thisMonthNumberInput";
            thisMonthNumberInput.Size = new Size(231, 27);
            thisMonthNumberInput.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 80);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(227, 20);
            label3.TabIndex = 3;
            label3.Text = "Last month water meter readings";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 17);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 4;
            label4.Text = "Customer Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(363, 80);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 6;
            label6.Text = "Number of people";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 17);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 2;
            label1.Text = "Customer Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 230);
            label5.Name = "label5";
            label5.Size = new Size(227, 20);
            label5.TabIndex = 3;
            label5.Text = "This month water meter readings";
            label5.Click += label3_Click;
            // 
            // customerTypeCombobox
            // 
            customerTypeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerTypeCombobox.FormattingEnabled = true;
            customerTypeCombobox.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            customerTypeCombobox.Location = new Point(313, 40);
            customerTypeCombobox.Name = "customerTypeCombobox";
            customerTypeCombobox.Size = new Size(227, 28);
            customerTypeCombobox.TabIndex = 7;
            customerTypeCombobox.SelectedIndexChanged += customerTypeCombobox_SelectedIndexChanged;
            // 
            // currentMonthCombobox
            // 
            currentMonthCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            currentMonthCombobox.FormattingEnabled = true;
            currentMonthCombobox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            currentMonthCombobox.Location = new Point(313, 185);
            currentMonthCombobox.Name = "currentMonthCombobox";
            currentMonthCombobox.Size = new Size(227, 28);
            currentMonthCombobox.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(379, 155);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 6;
            label7.Text = "Current Month";
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.PapayaWhip;
            calculateButton.Font = new Font("Segoe UI", 15F);
            calculateButton.ForeColor = Color.Black;
            calculateButton.Location = new Point(16, 341);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(172, 106);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += CalculateButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(313, 299);
            label8.Name = "label8";
            label8.Size = new Size(173, 20);
            label8.TabIndex = 2;
            label8.Text = "Amount of consumption:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(313, 329);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 2;
            label9.Text = "Price:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(313, 387);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 2;
            label10.Text = "Enviroment Fees:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(313, 414);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 2;
            label11.Text = "Subtotal:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label12.Location = new Point(313, 444);
            label12.Name = "label12";
            label12.Size = new Size(80, 35);
            label12.TabIndex = 2;
            label12.Text = "Total:";
            // 
            // totalLabel
            // 
            totalLabel.Anchor = AnchorStyles.Left;
            totalLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            totalLabel.ImageAlign = ContentAlignment.MiddleRight;
            totalLabel.Location = new Point(492, 441);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(236, 38);
            totalLabel.TabIndex = 2;
            totalLabel.Text = "0";
            totalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // consumptionLabel
            // 
            consumptionLabel.Anchor = AnchorStyles.Left;
            consumptionLabel.ImageAlign = ContentAlignment.MiddleRight;
            consumptionLabel.Location = new Point(492, 299);
            consumptionLabel.Name = "consumptionLabel";
            consumptionLabel.Size = new Size(236, 20);
            consumptionLabel.TabIndex = 2;
            consumptionLabel.Text = "0";
            consumptionLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.Left;
            priceLabel.ImageAlign = ContentAlignment.MiddleRight;
            priceLabel.Location = new Point(492, 329);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(236, 20);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "0";
            priceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // VATLabel
            // 
            VATLabel.Anchor = AnchorStyles.Left;
            VATLabel.ImageAlign = ContentAlignment.MiddleRight;
            VATLabel.Location = new Point(492, 357);
            VATLabel.Name = "VATLabel";
            VATLabel.Size = new Size(236, 23);
            VATLabel.TabIndex = 2;
            VATLabel.Text = "0";
            VATLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // envFeeLabel
            // 
            envFeeLabel.Anchor = AnchorStyles.Left;
            envFeeLabel.ImageAlign = ContentAlignment.MiddleRight;
            envFeeLabel.Location = new Point(492, 387);
            envFeeLabel.Name = "envFeeLabel";
            envFeeLabel.Size = new Size(236, 24);
            envFeeLabel.TabIndex = 2;
            envFeeLabel.Text = "0";
            envFeeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(313, 360);
            label18.Name = "label18";
            label18.Size = new Size(37, 20);
            label18.TabIndex = 2;
            label18.Text = "VAT:";
            // 
            // subtotalLabel
            // 
            subtotalLabel.Anchor = AnchorStyles.Left;
            subtotalLabel.ImageAlign = ContentAlignment.MiddleRight;
            subtotalLabel.Location = new Point(492, 411);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(236, 23);
            subtotalLabel.TabIndex = 2;
            subtotalLabel.Text = "0";
            subtotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AddInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(currentMonthCombobox);
            Controls.Add(customerTypeCombobox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(totalLabel);
            Controls.Add(label12);
            Controls.Add(subtotalLabel);
            Controls.Add(envFeeLabel);
            Controls.Add(VATLabel);
            Controls.Add(priceLabel);
            Controls.Add(consumptionLabel);
            Controls.Add(label18);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(calculateButton);
            Controls.Add(thisMonthNumberInput);
            Controls.Add(customerNameInput);
            Controls.Add(customerCodeInput);
            Controls.Add(NumberofpeopleInput);
            Controls.Add(lastmonthNumberInput);
            Name = "AddInvoice";
            Size = new Size(857, 505);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox customerCodeInput;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label1;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label7;
        private Button calculateButton;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label totalLabel;
        private Label label16;
        private Label label14;
        private Label VATLabel;
        private Label label17;
        private TextBox lastmonthNumberInput;
        private TextBox customerNameInput;
        private TextBox NumberofpeopleInput;
        private TextBox thisMonthNumberInput;
        private ComboBox customerTypeCombobox;
        private ComboBox currentMonthCombobox;
        private Label consumptionLabel;
        private Label priceLabel;
        private Label envFeeLabel;
        private Label label18;
        private Label subtotalLabel;
    }
}
