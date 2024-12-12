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
            panelFill = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            panel1.SuspendLayout();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.Location = new Point(10, 10);
            dataGridViewUsers.Margin = new Padding(4, 4, 4, 4);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(1009, 540);
            dataGridViewUsers.TabIndex = 0;
            // 
            // bttnSave
            // 
            bttnSave.Dock = DockStyle.Left;
            bttnSave.Location = new Point(10, 10);
            bttnSave.Margin = new Padding(4, 4, 4, 4);
            bttnSave.Name = "bttnSave";
            bttnSave.Size = new Size(100, 50);
            bttnSave.TabIndex = 1;
            bttnSave.Text = "Сохранить";
            bttnSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(bttnSave);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1029, 70);
            panel1.TabIndex = 2;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewUsers);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 70);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(1029, 560);
            panelFill.TabIndex = 3;
            // 
            // FormBinding
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 630);
            Controls.Add(panelFill);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormBinding";
            Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            panel1.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Button bttnSave;
        private Panel panel1;
        private Panel panelFill;
    }
}
