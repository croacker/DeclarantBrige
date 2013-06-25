using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.asf.declarantbrige.model;

namespace com.asf.declarantbrige.forms {
    public partial class ContragentsReference : ReferenceListForm {
        
        IList<WrkContragent> data = new List<WrkContragent>();
        
        public ContragentsReference(AbstractContext context)
            : base(context)
        {
            InitializeComponent();
        }

        protected override void init()
        {
            data = context.Hibernate.getContragents();
            fillDataTable();
        }

        private void fillDataTable()
        {
            dgvReference.DataSource = data;
            foreach (DataGridViewColumn column in dgvReference.Columns) {
                column.Visible = false;
            }

            dgvReference.Columns[1].Visible = true;
            dgvReference.Columns[1].HeaderText = "ИНН";
            dgvReference.Columns[1].Width = 50;
            dgvReference.Columns[2].Visible = true;
            dgvReference.Columns[2].HeaderText = "КПП";
            dgvReference.Columns[2].Width = 50;
            dgvReference.Columns[3].Visible = true;
            dgvReference.Columns[3].HeaderText = "Наименование";
            dgvReference.Columns[3].Width = 200;
            dgvReference.Columns[20].Visible = true;
            dgvReference.Columns[20].HeaderText = "Тип";
            dgvReference.Columns[20].Width = 50;
        }
    }
}
