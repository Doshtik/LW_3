namespace LW_3
{
    partial class FormBinding
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
            dataGridViewUsers = new DataGridView();
            bttnSave = new Button();
            panel1 = new Panel();
            panelLeft = new Panel();
            panelFill = new Panel();
            dataGridViewPosts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            panel1.SuspendLayout();
            panelLeft.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPosts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.Location = new Point(10, 10);
            dataGridViewUsers.Margin = new Padding(4);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(526, 540);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.SelectionChanged += DataGridViewUsers_SelectionChanged;
            // 
            // bttnSave
            // 
            bttnSave.Dock = DockStyle.Left;
            bttnSave.Location = new Point(10, 10);
            bttnSave.Margin = new Padding(4);
            bttnSave.Name = "bttnSave";
            bttnSave.Size = new Size(100, 50);
            bttnSave.TabIndex = 1;
            bttnSave.Text = "Сохранить";
            bttnSave.UseVisualStyleBackColor = true;
            bttnSave.Click += BttnSave_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(bttnSave);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1029, 70);
            panel1.TabIndex = 2;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(dataGridViewUsers);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 70);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(10);
            panelLeft.Size = new Size(546, 560);
            panelLeft.TabIndex = 3;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewPosts);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(546, 70);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(483, 560);
            panelFill.TabIndex = 4;
            // 
            // dataGridViewPosts
            // 
            dataGridViewPosts.BackgroundColor = Color.White;
            dataGridViewPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPosts.Dock = DockStyle.Fill;
            dataGridViewPosts.Location = new Point(10, 10);
            dataGridViewPosts.Name = "dataGridViewPosts";
            dataGridViewPosts.Size = new Size(463, 540);
            dataGridViewPosts.TabIndex = 0;
            // 
            // FormBinding
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 630);
            Controls.Add(panelFill);
            Controls.Add(panelLeft);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormBinding";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            panel1.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPosts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Button bttnSave;
        private Panel panel1;
        private Panel panelLeft;
        private Panel panelFill;
        private DataGridView dataGridViewPosts;
    }
}
