using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.asf.declarantbrige.forms;
using com.asf.declarantbrige.model;

namespace com.asf.declarantbrige.forms {
    public partial class OrganizationForm : UnitForm
    {
        private WrkOrg organization;
        private IList<WrkOrg> departmetns;

        protected static class DescriptionDictionary
        {
            
        }

        public OrganizationForm(AbstractContext context)
            : base(context)
        {
            InitializeComponent();
        }

        protected override void init()
        {
            IList<WrkOrg> tmpList = context.Hibernate.getHeadOrganization();
            if(tmpList.Count != 0)
            {
                organization = tmpList[0];
                Text += string.Format(" : {0}", organization.OrgName);
            }
            departmetns = context.Hibernate.getSubstituteDepartments();

            fillHeader();
            fillTable();
        }

        private void fillHeader()
        {
            txtInn.DataBindings.Add(new Binding("Text", organization, "Inn"));
            txtKpp.DataBindings.Add(new Binding("Text", organization, "Kpp"));
            txtOrgName.DataBindings.Add(new Binding("Text", organization, "OrgName"));
            txtPhone.DataBindings.Add(new Binding("Text", organization, "Phone"));
            txtEmail.DataBindings.Add(new Binding("Text", organization, "Email"));
            txtIndex.DataBindings.Add(new Binding("Text", organization, "Index"));
            txtCountryCode.DataBindings.Add(new Binding("Text", organization, "CCode"));
            txtRegionCode.DataBindings.Add(new Binding("Text", organization, "RCode"));
        }

        private void fillTable()
        {
            dgwDepartments.DataSource = departmetns;
            dgwDepartments.Columns[0].Visible = false;
            dgwDepartments.Columns[1].HeaderText = "ИНН";
            dgwDepartments.Columns[1].Width = 70;
            dgwDepartments.Columns[2].HeaderText = "КПП";
            dgwDepartments.Columns[2].Width = 70;
            dgwDepartments.Columns[3].HeaderText = "Наименование";
            dgwDepartments.Columns[3].Width = 200;
            dgwDepartments.Columns[4].HeaderText = "Телефон";
            dgwDepartments.Columns[4].Width = 70;
            dgwDepartments.Columns[5].HeaderText = "e-mail";
            dgwDepartments.Columns[5].Width = 70;
            foreach (DataGridViewColumn column in dgwDepartments.Columns)
            {
                //addLogLine(column.Index);
                if (column.Index > 5)
                {
                    column.Visible = false;
                }
            }
        }

        protected override void save()
        {
            throw new NotImplementedException();
        }

        protected override void cancel()
        {
            throw new NotImplementedException();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            save();
        }
    }
}
