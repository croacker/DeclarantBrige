using System.Collections.Generic;
using System.Windows.Forms;
using NHibernate.Mapping;
using com.asf.declarantbrige.model;

namespace com.asf.declarantbrige.forms {
    public partial class DeclarationsJournal : DocumentsListForm
    {
        private List<DecHeader> data;

        public DeclarationsJournal() {
            InitializeComponent();
        }

        public DeclarationsJournal(AbstractContext context):base(context) {
            InitializeComponent();
        }

        protected override void init()
        {
            data = context.Hibernate.getDecHeaders();
            fillTable();
        }

        private void fillTable()
        {
            dgvDocuments.DataSource = data;
            foreach (DataGridViewColumn column in dgvDocuments.Columns)
            {
                column.Visible = false;
            }

            dgvDocuments.Columns[1].Visible = true;
            dgvDocuments.Columns[1].HeaderText = "Тип";
            dgvDocuments.Columns[1].Width = 50;
            dgvDocuments.Columns[2].Visible = true;
            dgvDocuments.Columns[2].HeaderText = "Период";
            dgvDocuments.Columns[2].Width = 50;
            dgvDocuments.Columns[4].Visible = true;
            dgvDocuments.Columns[4].HeaderText = "Год";
            dgvDocuments.Columns[4].Width = 50;
            dgvDocuments.Columns[8].Visible = true;
            dgvDocuments.Columns[8].HeaderText = "Представляется в";
            dgvDocuments.Columns[8].Width = 200;

        }
    }
}
