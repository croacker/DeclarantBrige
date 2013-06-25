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
    public partial class ChooseList : BaseForm {
        public ChooseList(List<DecHeader> list, string nameProperty) {
            InitializeComponent();
            lbObjects.DataSource = list;
            lbObjects.DisplayMember = nameProperty;
        }
    }
}
