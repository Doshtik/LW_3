using System;
using System.ComponentModel;
using System.Windows.Forms;
using LW_3.Models;
using Microsoft.EntityFrameworkCore;

namespace LW_3
{
    public partial class FormBinding : Form
    {
        // ��������� ��������� ������, ������� ����� ��������������
        // ��� �������� � ������������ ��������� � �������������
        private Models.ApplicationContext? _db;

        public FormBinding()
        {
            InitializeComponent();
        }

        // OnLoad - ��� �������� �����
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _db = new Models.ApplicationContext();

            // ����� Load ���������� ������������ ��� ���� ������������� �� �� � DbContext ��.
            _db.Users.Load();
            dataGridViewUsers.DataSource = _db.Users.Local.ToBindingList();
        }

        // OnClosing - ��� �������� �����.
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _db?.Dispose();
            _db = null;
        }

        private void DataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (_db != null)
            {
                var currentRow = dataGridViewUsers.CurrentRow;

                if (currentRow == null) 
                    return;

                var user = (User)dataGridViewUsers.CurrentRow.DataBoundItem;

                if (user != null)
                {
                    _db.Entry(user).Collection(e => e.Posts).Load();
                    dataGridViewPosts.DataSource = user.Posts;
                }
            }
        }

        private void BttnSave_Click(object sender, EventArgs e)
        {
            // ���� ��� �������� ����� SaveChanges(),
            // ������� ��������� ��� ��������� � ��
            _db!.SaveChanges();


            dataGridViewUsers.Refresh();
            dataGridViewPosts.Refresh();
        }
    }
}
