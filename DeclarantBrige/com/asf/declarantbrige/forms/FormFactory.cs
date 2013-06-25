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
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowInTaskbar = false;
            aboutForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            aboutForm.ShowDialog(MainForm);
        }

        public UnitForm getUnitForm(Type type, AbstractContext context)
        {
            UnitForm form = (UnitForm) getForm(type, context);
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            return form;
        }

        public ReferenceListForm getReferenceListForm(Type type, AbstractContext context)
        {
            ReferenceListForm form = (ReferenceListForm) getForm(type, context);
            form.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            return form;
        }

        public DocumentsListForm getDocumentsListForm(Type type, AbstractContext context) {
            DocumentsListForm form = (DocumentsListForm)getForm(type, context);
            form.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            return form;
        }

        public void showUnitForm(Type type, AbstractContext context) {
            UnitForm form = (UnitForm)getForm(type, context);
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            form.ShowDialog(MainForm);
        }

        public void showReferenceListForm(Type type, AbstractContext context)
        {
            ReferenceListForm form = getReferenceListForm(type, context);
            form.ShowDialog(MainForm);
        }

        public void showDocumentsListForm(Type type, AbstractContext context) {
            DocumentsListForm form = getDocumentsListForm(type, context);
            form.ShowDialog(MainForm);
        }
    }
}
