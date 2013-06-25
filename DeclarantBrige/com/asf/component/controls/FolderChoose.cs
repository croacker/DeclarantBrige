using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.asf.util;

namespace com.asf.component {

    /// <summary>
    /// Контрол для выбора каталога
    /// </summary>
    public partial class FolderSelect : UserControl {
        
        public string Path
        {
            get { return txtPath.Text; }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    txtPath.Text = FsUtil.includeTrailingBackslash(value.Trim());
                }
                else
                {
                    txtPath.Text = value;
                }
                
            }
        }

        public FolderSelect() {
            InitializeComponent();
        }

        private void selectFolder()
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = txtPath.Text;
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Path = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            selectFolder();
        }
    }
}
