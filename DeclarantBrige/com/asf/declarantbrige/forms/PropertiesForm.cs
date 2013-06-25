using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.asf.declarantbrige.configuration;

namespace com.asf.declarantbrige.forms {
    public partial class PropertiesForm : BaseForm
    {
        private AppConfiguration configuration;

        public PropertiesForm(AppConfiguration configuration) {
            InitializeComponent();
            this.configuration = configuration;
            fillControls();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            aceptProperties();
            Close();
        }

        private void fillControls()
        {
            fsDeclarant.Path = configuration.getDeclarantFolder();
            fsExchangeFolder.Path = configuration.getExchangePath();
        }

        private void aceptProperties()
        {
            configuration.setDeclarantFolder(fsDeclarant.Path);
            configuration.setExchangePath(fsExchangeFolder.Path);
        }

    }
}
