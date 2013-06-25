using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.asf.declarantbrige.model.proxy;

namespace com.asf.declarantbrige.forms {
    public partial class UnitForm : BaseForm
    {
        protected AbstractContext context;

        /// <summary>
        /// Имя свойства Id
        /// </summary>
        public string IdPropertyName { get; set; }

        /// <summary>
        /// Имя свойства Наименование
        /// </summary>
        public string NamePropertyName { get; set; }

        public UnitForm() {
            InitializeComponent();
        }

        public UnitForm(AbstractContext context) {
            InitializeComponent();
            this.context = context;
        }

        private void UnitForm_Shown(object sender, EventArgs e) {
            init();
        }

        protected virtual void init() {
            throw new NotImplementedException();
        }

        protected virtual void save()
        {
            throw new NotImplementedException();
        }

        protected virtual void cancel()
        {
            throw new NotImplementedException();
        }

        protected void setText(IHibernateModelProxy modelProxy)
        {
            if(modelProxy != null)
            {
                Text = modelProxy.ModelDescription;
            }
        }

    }
}
