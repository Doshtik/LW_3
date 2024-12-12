using System;
using System.ComponentModel;
using System.Windows.Forms;
using LW_3.Models;

namespace LW_3
{
    public partial class FormBinding : Form
    {
        // Ёкземпл€р контекста данных, который будет использоватьс€
        // дл€ загрузки и отслеживани€ изменений о пользовател€х
        private Models.ApplicationContext? _db;

        public FormBinding()
        {
            InitializeComponent();
        }

        // OnLoad - ѕри загрузки формы
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _db = new Models.ApplicationContext();

            _db.Users.Load();
            dataGridViewUsers.DataSource = _db.Users.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _db?.Dispose();
            _db = null;
        }
    }
}
