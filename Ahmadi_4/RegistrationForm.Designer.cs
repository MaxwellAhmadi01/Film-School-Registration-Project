namespace Ahmadi_4
{
    partial class RegistrationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.schoolNameLabel = new System.Windows.Forms.Label();
            this.registrationDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.registrantInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.totalRegistrationCostLabel = new System.Windows.Forms.Label();
            this.pricePerClassLabel = new System.Windows.Forms.Label();
            this.numberOfClassesSelectedLabel = new System.Windows.Forms.Label();
            this.maximumNumberOfClassesAllowedLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.availableClassesListBox = new System.Windows.Forms.ListBox();
            this.availableClassesLabel = new System.Windows.Forms.Label();
            this.classTypeLabel = new System.Windows.Forms.Label();
            this.animationRadioButton = new System.Windows.Forms.RadioButton();
            this.liveActionRadioButton = new System.Windows.Forms.RadioButton();
            this.registrationInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registrantStatusComboBox = new System.Windows.Forms.ComboBox();
            this.dobMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.checkRadioButton = new System.Windows.Forms.RadioButton();
            this.emailReceiptCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.registrantInformationGroupBox.SuspendLayout();
            this.registrationInformationGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(387, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // schoolNameLabel
            // 
            this.schoolNameLabel.AutoSize = true;
            this.schoolNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schoolNameLabel.Font = new System.Drawing.Font("Rockwell", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolNameLabel.Location = new System.Drawing.Point(426, 311);
            this.schoolNameLabel.Name = "schoolNameLabel";
            this.schoolNameLabel.Size = new System.Drawing.Size(292, 35);
            this.schoolNameLabel.TabIndex = 1;
            this.schoolNameLabel.Text = "Hopkins Film School";
            // 
            // registrationDateMaskedTextBox
            // 
            this.registrationDateMaskedTextBox.Location = new System.Drawing.Point(512, 364);
            this.registrationDateMaskedTextBox.Mask = "00/00/0000";
            this.registrationDateMaskedTextBox.Name = "registrationDateMaskedTextBox";
            this.registrationDateMaskedTextBox.Size = new System.Drawing.Size(123, 31);
            this.registrationDateMaskedTextBox.TabIndex = 1;
            this.registrationDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.registrationDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // registrantInformationGroupBox
            // 
            this.registrantInformationGroupBox.Controls.Add(this.totalRegistrationCostLabel);
            this.registrantInformationGroupBox.Controls.Add(this.pricePerClassLabel);
            this.registrantInformationGroupBox.Controls.Add(this.numberOfClassesSelectedLabel);
            this.registrantInformationGroupBox.Controls.Add(this.maximumNumberOfClassesAllowedLabel);
            this.registrantInformationGroupBox.Controls.Add(this.label5);
            this.registrantInformationGroupBox.Controls.Add(this.label4);
            this.registrantInformationGroupBox.Controls.Add(this.label3);
            this.registrantInformationGroupBox.Controls.Add(this.label2);
            this.registrantInformationGroupBox.Controls.Add(this.availableClassesListBox);
            this.registrantInformationGroupBox.Controls.Add(this.availableClassesLabel);
            this.registrantInformationGroupBox.Controls.Add(this.classTypeLabel);
            this.registrantInformationGroupBox.Controls.Add(this.animationRadioButton);
            this.registrantInformationGroupBox.Controls.Add(this.liveActionRadioButton);
            this.registrantInformationGroupBox.Location = new System.Drawing.Point(644, 411);
            this.registrantInformationGroupBox.Name = "registrantInformationGroupBox";
            this.registrantInformationGroupBox.Size = new System.Drawing.Size(475, 556);
            this.registrantInformationGroupBox.TabIndex = 3;
            this.registrantInformationGroupBox.TabStop = false;
            this.registrantInformationGroupBox.Text = "Registrant Information:";
            // 
            // totalRegistrationCostLabel
            // 
            this.totalRegistrationCostLabel.AutoSize = true;
            this.totalRegistrationCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalRegistrationCostLabel.Location = new System.Drawing.Point(354, 478);
            this.totalRegistrationCostLabel.Name = "totalRegistrationCostLabel";
            this.totalRegistrationCostLabel.Size = new System.Drawing.Size(77, 27);
            this.totalRegistrationCostLabel.TabIndex = 16;
            this.totalRegistrationCostLabel.Text = "PRICE";
            this.totalRegistrationCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pricePerClassLabel
            // 
            this.pricePerClassLabel.AutoSize = true;
            this.pricePerClassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricePerClassLabel.Location = new System.Drawing.Point(354, 437);
            this.pricePerClassLabel.Name = "pricePerClassLabel";
            this.pricePerClassLabel.Size = new System.Drawing.Size(77, 27);
            this.pricePerClassLabel.TabIndex = 15;
            this.pricePerClassLabel.Text = "PRICE";
            this.pricePerClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberOfClassesSelectedLabel
            // 
            this.numberOfClassesSelectedLabel.AutoSize = true;
            this.numberOfClassesSelectedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfClassesSelectedLabel.Location = new System.Drawing.Point(354, 397);
            this.numberOfClassesSelectedLabel.Name = "numberOfClassesSelectedLabel";
            this.numberOfClassesSelectedLabel.Size = new System.Drawing.Size(62, 27);
            this.numberOfClassesSelectedLabel.TabIndex = 14;
            this.numberOfClassesSelectedLabel.Text = "NUM";
            this.numberOfClassesSelectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maximumNumberOfClassesAllowedLabel
            // 
            this.maximumNumberOfClassesAllowedLabel.AutoSize = true;
            this.maximumNumberOfClassesAllowedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maximumNumberOfClassesAllowedLabel.Location = new System.Drawing.Point(354, 350);
            this.maximumNumberOfClassesAllowedLabel.Name = "maximumNumberOfClassesAllowedLabel";
            this.maximumNumberOfClassesAllowedLabel.Size = new System.Drawing.Size(62, 27);
            this.maximumNumberOfClassesAllowedLabel.TabIndex = 13;
            this.maximumNumberOfClassesAllowedLabel.Text = "NUM";
            this.maximumNumberOfClassesAllowedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Registration Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price Per Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "# of Classes Selected:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Maximum # of Classes Allowed:";
            // 
            // availableClassesListBox
            // 
            this.availableClassesListBox.FormattingEnabled = true;
            this.availableClassesListBox.ItemHeight = 25;
            this.availableClassesListBox.Location = new System.Drawing.Point(16, 161);
            this.availableClassesListBox.Name = "availableClassesListBox";
            this.availableClassesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.availableClassesListBox.Size = new System.Drawing.Size(349, 154);
            this.availableClassesListBox.TabIndex = 12;
            this.availableClassesListBox.SelectedIndexChanged += new System.EventHandler(this.availableClassesListBox_SelectedIndexChanged);
            // 
            // availableClassesLabel
            // 
            this.availableClassesLabel.AutoSize = true;
            this.availableClassesLabel.Location = new System.Drawing.Point(11, 120);
            this.availableClassesLabel.Name = "availableClassesLabel";
            this.availableClassesLabel.Size = new System.Drawing.Size(189, 25);
            this.availableClassesLabel.TabIndex = 3;
            this.availableClassesLabel.Text = "Available Classes:";
            // 
            // classTypeLabel
            // 
            this.classTypeLabel.AutoSize = true;
            this.classTypeLabel.Location = new System.Drawing.Point(11, 43);
            this.classTypeLabel.Name = "classTypeLabel";
            this.classTypeLabel.Size = new System.Drawing.Size(126, 25);
            this.classTypeLabel.TabIndex = 2;
            this.classTypeLabel.Text = "Class Type:";
            // 
            // animationRadioButton
            // 
            this.animationRadioButton.AutoSize = true;
            this.animationRadioButton.Location = new System.Drawing.Point(161, 78);
            this.animationRadioButton.Name = "animationRadioButton";
            this.animationRadioButton.Size = new System.Drawing.Size(138, 29);
            this.animationRadioButton.TabIndex = 11;
            this.animationRadioButton.TabStop = true;
            this.animationRadioButton.Text = "Animation";
            this.animationRadioButton.UseVisualStyleBackColor = true;
            this.animationRadioButton.CheckedChanged += new System.EventHandler(this.animationRadioButton_CheckedChanged);
            // 
            // liveActionRadioButton
            // 
            this.liveActionRadioButton.AutoSize = true;
            this.liveActionRadioButton.Location = new System.Drawing.Point(161, 43);
            this.liveActionRadioButton.Name = "liveActionRadioButton";
            this.liveActionRadioButton.Size = new System.Drawing.Size(149, 29);
            this.liveActionRadioButton.TabIndex = 10;
            this.liveActionRadioButton.TabStop = true;
            this.liveActionRadioButton.Text = "Live Action";
            this.liveActionRadioButton.UseVisualStyleBackColor = true;
            this.liveActionRadioButton.CheckedChanged += new System.EventHandler(this.liveActionRadioButton_CheckedChanged);
            // 
            // registrationInformationGroupBox
            // 
            this.registrationInformationGroupBox.Controls.Add(this.label1);
            this.registrationInformationGroupBox.Controls.Add(this.registrantStatusComboBox);
            this.registrationInformationGroupBox.Controls.Add(this.dobMaskedTextBox);
            this.registrationInformationGroupBox.Controls.Add(this.dobLabel);
            this.registrationInformationGroupBox.Controls.Add(this.emailTextBox);
            this.registrationInformationGroupBox.Controls.Add(this.lastNameTextBox);
            this.registrationInformationGroupBox.Controls.Add(this.firstNameTextBox);
            this.registrationInformationGroupBox.Controls.Add(this.emailLabel);
            this.registrationInformationGroupBox.Controls.Add(this.lastNameLabel);
            this.registrationInformationGroupBox.Controls.Add(this.firstNameLabel);
            this.registrationInformationGroupBox.Location = new System.Drawing.Point(12, 411);
            this.registrationInformationGroupBox.Name = "registrationInformationGroupBox";
            this.registrationInformationGroupBox.Size = new System.Drawing.Size(431, 394);
            this.registrationInformationGroupBox.TabIndex = 4;
            this.registrationInformationGroupBox.TabStop = false;
            this.registrationInformationGroupBox.Text = "Registration Information:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Registrant Status:";
            // 
            // registrantStatusComboBox
            // 
            this.registrantStatusComboBox.FormattingEnabled = true;
            this.registrantStatusComboBox.Location = new System.Drawing.Point(208, 282);
            this.registrantStatusComboBox.Name = "registrantStatusComboBox";
            this.registrantStatusComboBox.Size = new System.Drawing.Size(217, 33);
            this.registrantStatusComboBox.TabIndex = 6;
            // 
            // dobMaskedTextBox
            // 
            this.dobMaskedTextBox.Location = new System.Drawing.Point(152, 210);
            this.dobMaskedTextBox.Mask = "00/00/0000";
            this.dobMaskedTextBox.Name = "dobMaskedTextBox";
            this.dobMaskedTextBox.Size = new System.Drawing.Size(129, 31);
            this.dobMaskedTextBox.TabIndex = 5;
            this.dobMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dobMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(6, 216);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(137, 25);
            this.dobLabel.TabIndex = 6;
            this.dobLabel.Text = "Date of Birth:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(152, 150);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(220, 31);
            this.emailTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(152, 101);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(220, 31);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(152, 52);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(220, 31);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(6, 156);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(79, 25);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "E-Mail:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 101);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(121, 25);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 52);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(122, 25);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Location = new System.Drawing.Point(328, 820);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(156, 25);
            this.paymentTypeLabel.TabIndex = 5;
            this.paymentTypeLabel.Text = "Payment Type:";
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(512, 844);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(93, 29);
            this.cashRadioButton.TabIndex = 7;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkRadioButton
            // 
            this.checkRadioButton.AutoSize = true;
            this.checkRadioButton.Location = new System.Drawing.Point(512, 879);
            this.checkRadioButton.Name = "checkRadioButton";
            this.checkRadioButton.Size = new System.Drawing.Size(104, 29);
            this.checkRadioButton.TabIndex = 8;
            this.checkRadioButton.TabStop = true;
            this.checkRadioButton.Text = "Check";
            this.checkRadioButton.UseVisualStyleBackColor = true;
            // 
            // emailReceiptCheckBox
            // 
            this.emailReceiptCheckBox.AutoSize = true;
            this.emailReceiptCheckBox.Location = new System.Drawing.Point(333, 923);
            this.emailReceiptCheckBox.Name = "emailReceiptCheckBox";
            this.emailReceiptCheckBox.Size = new System.Drawing.Size(286, 29);
            this.emailReceiptCheckBox.TabIndex = 9;
            this.emailReceiptCheckBox.Text = "Email Receipt Requested";
            this.emailReceiptCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 40);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.fileToolStripMenuItem.Text = "F&ile";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(318, 44);
            this.saveToolStripMenuItem.Text = "S&ave";
            this.saveToolStripMenuItem.ToolTipText = "Using the Save menu item will display a summary of the registration information i" +
    "n a message box, and write the registration summary information to a text file.";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F10)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(318, 44);
            this.clearToolStripMenuItem.Text = "Cl&ear";
            this.clearToolStripMenuItem.ToolTipText = "Using the Clear menu item will clear the form of all of its entered contents, and" +
    " return the form to its original load state.";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(318, 44);
            this.exitToolStripMenuItem.Text = "Exi&t";
            this.exitToolStripMenuItem.ToolTipText = "Using the Exit menu item will close the program for the user.";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(84, 36);
            this.helpToolStripMenuItem.Text = "He&lp";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F19)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(309, 44);
            this.aboutToolStripMenuItem.Text = "Ab&out";
            this.aboutToolStripMenuItem.ToolTipText = "The About menu item will display the \'About Form\', which contains copyright infor" +
    "mation for the Hopkins Film School\'s user form creation.";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 999);
            this.Controls.Add(this.emailReceiptCheckBox);
            this.Controls.Add(this.checkRadioButton);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.registrationInformationGroupBox);
            this.Controls.Add(this.registrantInformationGroupBox);
            this.Controls.Add(this.registrationDateMaskedTextBox);
            this.Controls.Add(this.schoolNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hopkins Film School Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.registrantInformationGroupBox.ResumeLayout(false);
            this.registrantInformationGroupBox.PerformLayout();
            this.registrationInformationGroupBox.ResumeLayout(false);
            this.registrationInformationGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label schoolNameLabel;
        private System.Windows.Forms.MaskedTextBox registrationDateMaskedTextBox;
        private System.Windows.Forms.GroupBox registrantInformationGroupBox;
        private System.Windows.Forms.GroupBox registrationInformationGroupBox;
        private System.Windows.Forms.ComboBox registrantStatusComboBox;
        private System.Windows.Forms.MaskedTextBox dobMaskedTextBox;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label classTypeLabel;
        private System.Windows.Forms.RadioButton animationRadioButton;
        private System.Windows.Forms.RadioButton liveActionRadioButton;
        private System.Windows.Forms.ListBox availableClassesListBox;
        private System.Windows.Forms.Label availableClassesLabel;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton checkRadioButton;
        private System.Windows.Forms.CheckBox emailReceiptCheckBox;
        private System.Windows.Forms.Label totalRegistrationCostLabel;
        private System.Windows.Forms.Label pricePerClassLabel;
        private System.Windows.Forms.Label numberOfClassesSelectedLabel;
        private System.Windows.Forms.Label maximumNumberOfClassesAllowedLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

