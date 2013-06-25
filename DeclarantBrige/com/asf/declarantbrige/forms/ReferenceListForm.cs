using System;

namespace com.asf.declarantbrige.forms {
    public partial class ReferenceListForm : BaseForm {

        protected AbstractContext context;

        public ReferenceListForm() {
            InitializeComponent();
        }

        public ReferenceListForm(AbstractContext context) {
            InitializeComponent();
            this.context = context;
        }

        private void ListForm_Shown(object sender, EventArgs e) {
            init();
        }

        protected virtual void init() {
            throw new NotImplementedException();
        }

        protected virtual void newUnit() {
            throw new NotImplementedException();
        }

        protected virtual void copyUnit() {
            throw new NotImplementedException();
        }

        protected virtual void editUnit() {
            throw new NotImplementedException();
        }

        protected virtual void deleteUnit() {
            throw new NotImplementedException();
        }

        private void tsbNew_Click(object sender, EventArgs e) {
            newUnit();
        }

        private void tsbCopy_Click(object sender, EventArgs e) {
            copyUnit();
        }

        private void tsbEdit_Click(object sender, EventArgs e) {
            editUnit();
        }

        private void tsbDelete_Click(object sender, EventArgs e) {
            deleteUnit();
        }

    }
}
