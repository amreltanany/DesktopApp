namespace WinFormsApp1
{
    partial class Econtact
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
            pictureBox1Logo = new PictureBox();
            lblContactID = new Label();
            txtboxContactID = new TextBox();
            txtboxFirstName = new TextBox();
            lblFirstName = new Label();
            txtboxLastName = new TextBox();
            lblLastName = new Label();
            txtboxContactNumber = new TextBox();
            lblContactNumber = new Label();
            txtboxAddress = new TextBox();
            lblAddress = new Label();
            lblGender = new Label();
            cmbGender = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            dgvContactList = new DataGridView();
            label1 = new Label();
            txtboxSearch = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1Logo
            // 
            pictureBox1Logo.BackColor = Color.Transparent;
            pictureBox1Logo.Image = Properties.Resources.logo_transparent;
            pictureBox1Logo.Location = new Point(466, 12);
            pictureBox1Logo.Name = "pictureBox1Logo";
            pictureBox1Logo.Size = new Size(194, 105);
            pictureBox1Logo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1Logo.TabIndex = 0;
            pictureBox1Logo.TabStop = false;
            // 
            // lblContactID
            // 
            lblContactID.AutoSize = true;
            lblContactID.BackColor = Color.Transparent;
            lblContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactID.Location = new Point(65, 123);
            lblContactID.Name = "lblContactID";
            lblContactID.Size = new Size(82, 21);
            lblContactID.TabIndex = 1;
            lblContactID.Text = "Contact ID";
            // 
            // txtboxContactID
            // 
            txtboxContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxContactID.Location = new Point(199, 123);
            txtboxContactID.Name = "txtboxContactID";
            txtboxContactID.ReadOnly = true;
            txtboxContactID.Size = new Size(271, 29);
            txtboxContactID.TabIndex = 2;
            txtboxContactID.TextChanged += textBox1_TextChanged;
            // 
            // txtboxFirstName
            // 
            txtboxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxFirstName.Location = new Point(199, 158);
            txtboxFirstName.Name = "txtboxFirstName";
            txtboxFirstName.Size = new Size(271, 29);
            txtboxFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(65, 160);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(86, 21);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name";
            // 
            // txtboxLastName
            // 
            txtboxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxLastName.Location = new Point(199, 193);
            txtboxLastName.Name = "txtboxLastName";
            txtboxLastName.Size = new Size(271, 29);
            txtboxLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(65, 195);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(84, 21);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // txtboxContactNumber
            // 
            txtboxContactNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxContactNumber.Location = new Point(199, 228);
            txtboxContactNumber.Name = "txtboxContactNumber";
            txtboxContactNumber.Size = new Size(271, 29);
            txtboxContactNumber.TabIndex = 8;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.BackColor = Color.Transparent;
            lblContactNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactNumber.Location = new Point(65, 230);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(91, 21);
            lblContactNumber.TabIndex = 7;
            lblContactNumber.Text = "Contact No.";
            // 
            // txtboxAddress
            // 
            txtboxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxAddress.Location = new Point(199, 263);
            txtboxAddress.Multiline = true;
            txtboxAddress.Name = "txtboxAddress";
            txtboxAddress.Size = new Size(271, 74);
            txtboxAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(65, 286);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(66, 21);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(65, 351);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(61, 21);
            lblGender.TabIndex = 11;
            lblGender.Text = "Gender";
            lblGender.Click += label2_Click;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(199, 349);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(271, 29);
            cmbGender.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkGreen;
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.FlatAppearance.BorderColor = Color.DarkGreen;
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(255, 400);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 40);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(381, 400);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkOrange;
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(633, 400);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 40);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(507, 400);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvContactList
            // 
            dgvContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactList.Location = new Point(493, 164);
            dgvContactList.Name = "dgvContactList";
            dgvContactList.Size = new Size(408, 214);
            dgvContactList.TabIndex = 18;
            dgvContactList.CellContentClick += dgvContactList_CellContentClick;
            dgvContactList.RowHeaderMouseClick += dgvContactList_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(493, 131);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 19;
            label1.Text = "Search";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtboxSearch
            // 
            txtboxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxSearch.Location = new Point(556, 129);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.Size = new Size(345, 29);
            txtboxSearch.TabIndex = 20;
            txtboxSearch.TextChanged += txtboxSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_exit_96;
            pictureBox1.Location = new Point(852, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Econtact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(916, 539);
            Controls.Add(pictureBox1);
            Controls.Add(txtboxSearch);
            Controls.Add(label1);
            Controls.Add(dgvContactList);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(txtboxAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtboxContactNumber);
            Controls.Add(lblContactNumber);
            Controls.Add(txtboxLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtboxFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtboxContactID);
            Controls.Add(lblContactID);
            Controls.Add(pictureBox1Logo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Econtact";
            Text = "Econtact";
            Load += Econtact_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1Logo;
        private Label lblContactID;
        private TextBox txtboxContactID;
        private TextBox txtboxFirstName;
        private Label lblFirstName;
        private TextBox txtboxLastName;
        private Label lblLastName;
        private TextBox txtboxContactNumber;
        private Label lblContactNumber;
        private TextBox txtboxAddress;
        private Label lblAddress;
        private Label lblGender;
        private ComboBox cmbGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private DataGridView dgvContactList;
        private Label label1;
        private TextBox txtboxSearch;
        private PictureBox pictureBox1;
    }
}
