namespace SLVP_Aflevering2
{
    partial class Form1
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
            tbName = new TextBox();
            tbCategory = new TextBox();
            tbAgriculture = new TextBox();
            tbILUC = new TextBox();
            tbProduction = new TextBox();
            tbPackaging = new TextBox();
            tbTransport = new TextBox();
            tbStore = new TextBox();
            lblName = new Label();
            lblCategory = new Label();
            lblAgriculture = new Label();
            lblILUC = new Label();
            lblProduction = new Label();
            lblPackaging = new Label();
            lblTransport = new Label();
            lblStore = new Label();
            btnCalc = new Button();
            tbResult = new TextBox();
            lblResult = new Label();
            dgvInput = new DataGridView();
            lblDgv = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInput).BeginInit();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(125, 28);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 0;
            // 
            // tbCategory
            // 
            tbCategory.Location = new Point(125, 57);
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new Size(100, 23);
            tbCategory.TabIndex = 1;
            // 
            // tbAgriculture
            // 
            tbAgriculture.Location = new Point(125, 86);
            tbAgriculture.Name = "tbAgriculture";
            tbAgriculture.Size = new Size(100, 23);
            tbAgriculture.TabIndex = 2;
            // 
            // tbILUC
            // 
            tbILUC.Location = new Point(125, 115);
            tbILUC.Name = "tbILUC";
            tbILUC.Size = new Size(100, 23);
            tbILUC.TabIndex = 3;
            // 
            // tbProduction
            // 
            tbProduction.Location = new Point(125, 144);
            tbProduction.Name = "tbProduction";
            tbProduction.Size = new Size(100, 23);
            tbProduction.TabIndex = 4;
            // 
            // tbPackaging
            // 
            tbPackaging.Location = new Point(125, 173);
            tbPackaging.Name = "tbPackaging";
            tbPackaging.Size = new Size(100, 23);
            tbPackaging.TabIndex = 5;
            // 
            // tbTransport
            // 
            tbTransport.Location = new Point(125, 202);
            tbTransport.Name = "tbTransport";
            tbTransport.Size = new Size(100, 23);
            tbTransport.TabIndex = 6;
            // 
            // tbStore
            // 
            tbStore.Location = new Point(125, 231);
            tbStore.Name = "tbStore";
            tbStore.Size = new Size(100, 23);
            tbStore.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(84, 15);
            lblName.TabIndex = 8;
            lblName.Text = "Name of food:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 57);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Category:";
            // 
            // lblAgriculture
            // 
            lblAgriculture.AutoSize = true;
            lblAgriculture.Location = new Point(12, 86);
            lblAgriculture.Name = "lblAgriculture";
            lblAgriculture.Size = new Size(95, 15);
            lblAgriculture.TabIndex = 10;
            lblAgriculture.Text = "Agriculture CO2:";
            // 
            // lblILUC
            // 
            lblILUC.AutoSize = true;
            lblILUC.Location = new Point(12, 115);
            lblILUC.Name = "lblILUC";
            lblILUC.Size = new Size(61, 15);
            lblILUC.TabIndex = 11;
            lblILUC.Text = "ILUC CO2:";
            // 
            // lblProduction
            // 
            lblProduction.AutoSize = true;
            lblProduction.Location = new Point(12, 144);
            lblProduction.Name = "lblProduction";
            lblProduction.Size = new Size(95, 15);
            lblProduction.TabIndex = 12;
            lblProduction.Text = "Production CO2:";
            // 
            // lblPackaging
            // 
            lblPackaging.AutoSize = true;
            lblPackaging.Location = new Point(12, 173);
            lblPackaging.Name = "lblPackaging";
            lblPackaging.Size = new Size(91, 15);
            lblPackaging.TabIndex = 13;
            lblPackaging.Text = "Packaging CO2:";
            // 
            // lblTransport
            // 
            lblTransport.AutoSize = true;
            lblTransport.Location = new Point(12, 202);
            lblTransport.Name = "lblTransport";
            lblTransport.Size = new Size(85, 15);
            lblTransport.TabIndex = 14;
            lblTransport.Text = "Transport CO2:";
            // 
            // lblStore
            // 
            lblStore.AutoSize = true;
            lblStore.Location = new Point(12, 231);
            lblStore.Name = "lblStore";
            lblStore.Size = new Size(63, 15);
            lblStore.TabIndex = 15;
            lblStore.Text = "Store CO2:";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(135, 260);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 16;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(315, 112);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(100, 23);
            tbResult.TabIndex = 17;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(267, 115);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(42, 15);
            lblResult.TabIndex = 18;
            lblResult.Text = "Result:";
            // 
            // dgvInput
            // 
            dgvInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInput.Location = new Point(446, 50);
            dgvInput.MultiSelect = false;
            dgvInput.Name = "dgvInput";
            dgvInput.ReadOnly = true;
            dgvInput.RowHeadersVisible = false;
            dgvInput.RowTemplate.Height = 25;
            dgvInput.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvInput.Size = new Size(934, 446);
            dgvInput.TabIndex = 19;
            dgvInput.CellMouseClick += dgvInput_CellMouseClick;
            dgvInput.MouseClick += dgvInput_MouseClick;
            // 
            // lblDgv
            // 
            lblDgv.AutoSize = true;
            lblDgv.Location = new Point(903, 31);
            lblDgv.Name = "lblDgv";
            lblDgv.Size = new Size(38, 15);
            lblDgv.TabIndex = 20;
            lblDgv.Text = "Input:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(886, 502);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 27);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear input";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 563);
            Controls.Add(btnClear);
            Controls.Add(lblDgv);
            Controls.Add(dgvInput);
            Controls.Add(lblResult);
            Controls.Add(tbResult);
            Controls.Add(btnCalc);
            Controls.Add(lblStore);
            Controls.Add(lblTransport);
            Controls.Add(lblPackaging);
            Controls.Add(lblProduction);
            Controls.Add(lblILUC);
            Controls.Add(lblAgriculture);
            Controls.Add(lblCategory);
            Controls.Add(lblName);
            Controls.Add(tbStore);
            Controls.Add(tbTransport);
            Controls.Add(tbPackaging);
            Controls.Add(tbProduction);
            Controls.Add(tbILUC);
            Controls.Add(tbAgriculture);
            Controls.Add(tbCategory);
            Controls.Add(tbName);
            Name = "Form1";
            Text = "Afleveringsopgave 2";
            ((System.ComponentModel.ISupportInitialize)dgvInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private TextBox tbCategory;
        private TextBox tbAgriculture;
        private TextBox tbILUC;
        private TextBox tbProduction;
        private TextBox tbPackaging;
        private TextBox tbTransport;
        private TextBox tbStore;
        private Label lblName;
        private Label lblCategory;
        private Label lblAgriculture;
        private Label lblILUC;
        private Label lblProduction;
        private Label lblPackaging;
        private Label lblTransport;
        private Label lblStore;
        private Button btnCalc;
        private TextBox tbResult;
        private Label lblResult;
        private DataGridView dgvInput;
        private Label lblDgv;
        private Button btnClear;
    }
}