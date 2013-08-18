using System;
using System.Windows.Forms;

namespace com.asf.declarantbrige.forms {
    internal class FormFactory: AbstractFactory
    {
        public Form MainForm { get; set; }

        private static FormFactory instance;

        public static FormFactory getInstance()
        {
            if (instance == null)
            {
                instance = new FormFactory();
            }
            return instance;
        }

        private FormFactory()
        {
        }

        private Form getForm(Type type, AbstractContext context)
        {
            return (Form) Activator.CreateInstance(type, context);
        }

        public void showAboutForm()
        {
            new AboutForm().ShowDialog();
        }

        public UnitForm getUnitForm(Type type, AbstractContext context)
        {
            return (UnitForm) getForm(type, context);
        }

        public ReferenceListForm getReferenceList(Type type, AbstractContext context)
        {
            return (ReferenceListForm) getForm(type, context);
        }

        public DocumentsListForm getDocumentsList(Type type, AbstractContext context) {
            return (DocumentsListForm)getForm(type, context);
        }

        //public void showDocumentsListForm(Type type, AbstractContext context) {
        //    DocumentsListForm form = getDocumentsList(type, context);
        //    form.ShowDialog(MainForm);
        //}
    }
}
