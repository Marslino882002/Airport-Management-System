namespace Airport
{
    partial class Form3
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            staffToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            errorLabel = new Label();
            DeleteBtn = new Button();
            CreateBtn = new Button();
            button4 = new Button();
            Display_button = new Button();
            button6 = new Button();
            button7 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, studentsToolStripMenuItem, staffToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(601, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, copyToolStripMenuItem, deleteToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(40, 20);
            fileToolStripMenuItem.Text = "File ";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = Properties.Resources.newFileIcon;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(107, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = Properties.Resources.copyIcon;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(107, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.removeIcon;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.exittIcon;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(107, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, viewToolStripMenuItem, searchToolStripMenuItem });
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(70, 20);
            studentsToolStripMenuItem.Text = " Travellers";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Image = Properties.Resources.addIcon;
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(109, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Image = Properties.Resources.openIcon;
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(109, 22);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Image = Properties.Resources.search25;
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(109, 22);
            searchToolStripMenuItem.Text = "Search";
            // 
            // staffToolStripMenuItem
            // 
            staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            staffToolStripMenuItem.Size = new Size(43, 20);
            staffToolStripMenuItem.Text = "Staff";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(367, 94);
            label1.Name = "label1";
            label1.Size = new Size(91, 22);
            label1.TabIndex = 2;
            label1.Text = "File Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 22.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(166, 34);
            label2.Name = "label2";
            label2.Size = new Size(226, 37);
            label2.TabIndex = 3;
            label2.Text = "Data of travellers";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(12, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 205);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Bold | FontStyle.Italic);
            errorLabel.ForeColor = SystemColors.HotTrack;
            errorLabel.Location = new Point(492, 168);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(97, 22);
            errorLabel.TabIndex = 5;
            errorLabel.Text = "File Exists";
            errorLabel.Visible = false;
            errorLabel.Click += errorLabel_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.PowderBlue;
            DeleteBtn.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Bold | FontStyle.Italic);
            DeleteBtn.Location = new Point(424, 208);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 44);
            DeleteBtn.TabIndex = 7;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.PowderBlue;
            CreateBtn.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Bold | FontStyle.Italic);
            CreateBtn.Location = new Point(298, 208);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(75, 44);
            CreateBtn.TabIndex = 8;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PowderBlue;
            button4.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(298, 270);
            button4.Name = "button4";
            button4.Size = new Size(75, 44);
            button4.TabIndex = 9;
            button4.Text = "Insert";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Display_button
            // 
            Display_button.BackColor = Color.PowderBlue;
            Display_button.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Bold | FontStyle.Italic);
            Display_button.Location = new Point(424, 270);
            Display_button.Name = "Display_button";
            Display_button.Size = new Size(75, 44);
            Display_button.TabIndex = 10;
            Display_button.Tag = "";
            Display_button.Text = "display";
            Display_button.UseVisualStyleBackColor = false;
            Display_button.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.PowderBlue;
            button6.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button6.Location = new Point(298, 324);
            button6.Name = "button6";
            button6.Size = new Size(75, 44);
            button6.TabIndex = 11;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.PowderBlue;
            button7.Font = new Font("Monotype Corsiva", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button7.Location = new Point(424, 324);
            button7.Name = "button7";
            button7.Size = new Size(75, 44);
            button7.TabIndex = 12;
            button7.Text = "Modify";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(601, 401);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(Display_button);
            Controls.Add(button4);
            Controls.Add(CreateBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(errorLabel);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            Text = "Delete";
            Load += Form3_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem staffToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label errorLabel;
        private Button DeleteBtn;
        private Button CreateBtn;
        private Button button4;
        private Button Display_button;
        private Button button6;
        private Button button7;
    }
}