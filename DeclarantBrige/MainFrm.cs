using System;
using System.Collections.Generic;
using System.Windows.Forms;
using com.asf.declarantbrige;
using com.asf.declarantbrige.forms;
using com.asf.declarantbrige.model.database;
using com.asf.declarantbrige.model;
using com.asf.util;

namespace DeclarantBrige {
    public partial class MainFrm : Form
    {
        private IDictionary<string, string> startParameters;

        private AbstractContext context;

        public MainFrm() {
            InitializeComponent();
        }

        public MainFrm(IDictionary<string, string> startParameters) {
            InitializeComponent();
            this.startParameters = startParameters;
        }

        private void init()
        {
            ServiceFactory.getInstance().CtrlLogger = logList;
            FormFactory.getInstance().MainForm = this;
            FormFactory.getInstance().CtrlLogger = logList;
            context = new FormContext(ServiceFactory.getInstance().HibernateService);
            processStartupParameters();
            fillDeclarantDbList();
            setToolTips();
            setControlsEnabled(false);
        }

        /// <summary>
        /// Обработать аргументы командной строки
        /// </summary>
        private void processStartupParameters()
        {
            if(startParameters.Count != 0)
            {
                if(startParameters.ContainsKey(ShellArgumentsProcessor.Arguments.LOAD_FOLDER))
                {
                    ServiceFactory.getInstance().ConfigurationService.
                        getAppConfiguration().setExchangePath(startParameters[ShellArgumentsProcessor.Arguments.LOAD_FOLDER]);
                }
            }
        }

        private void setToolTips()
        {
            ttMainForm.SetToolTip(btnConnect, "Подключиться к БД");
            ttMainForm.SetToolTip(btnErase, "Очистить");
            ttMainForm.SetToolTip(btnCheckOrganization, "Проверить и исправить");
            ttMainForm.SetToolTip(btnCheckDeclaration, "Проверить и исправить");
            ttMainForm.SetToolTip(btnShowContragents, "Просмотр");
            ttMainForm.SetToolTip(btnShowOrganization, "Просмотр");
            ttMainForm.SetToolTip(btnShowDeclaration, "Просмотр");
            ttMainForm.SetToolTip(btnRefreshOrganization, "Обновить");
            ttMainForm.SetToolTip(btnRefreshDeclaration, "Обновить");
        }

        private void showProperties()
        {
            var propertiesForm = new PropertiesForm(ServiceFactory.getInstance().ConfigurationService.getAppConfiguration());
            propertiesForm.ShowDialog(this);//Переделать ShowDialog на событие
            fillDeclarantDbList();
        }

        private void closeDeclarantConnection()
        {
            btnConnect.Image = Properties.Resources.database;
            context.Hibernate.closeConnection();
            setControlsEnabled(false);
        }

        private void openDeclaranConnection()
        {
            var database = (DeclarantDatabaseModel) cmbDatabases.SelectedValue;
            ServiceFactory.getInstance().BackUpService.createBackUp(database);
            context.Hibernate.HibernateConnectionString = database.ConnectionString;
            btnConnect.Image = Properties.Resources.database_conn;
            fillDecHeaderList();
            fillOrganizationsList();
            setControlsEnabled(true);
        }

        private void setControlsEnabled(bool enabled)
        {
            btnLoadContragents.Enabled = enabled;
            btnErase.Enabled = enabled;
            btnShowContragents.Enabled = enabled;
            cmbOrganizations.Enabled = enabled;
            if (!cmbOrganizations.Enabled)
            {
                cmbOrganizations.DataSource = null;
            }
            btnShowOrganization.Enabled = enabled;
            btnRefreshOrganization.Enabled = enabled;
            cmbDeclarations.Enabled = enabled;
            if (!cmbDeclarations.Enabled) {
                cmbDeclarations.DataSource = null;
            }
            btnCheckDeclaration.Enabled = enabled;
            btnShowDeclaration.Enabled = enabled;
            btnRefreshDeclaration.Enabled = enabled;
            cbClearDeclaration.Enabled = enabled;
            btnLoadDeclaration.Enabled = enabled;

            cmbDatabases.Enabled = !enabled;
            ttMainForm.SetToolTip(btnConnect, enabled ? "Отключиться от БД" : "Подключиться к БД");
            tsmiProperties.Enabled = !enabled;
        }
        
        /// <summary>
        /// Заполнить список БД Декларант
        /// </summary>
        private void fillDeclarantDbList()
        {
            var declarantConfiguration =
              ServiceFactory.getInstance().ConfigurationService.getDeclarantConfiguration();
            declarantConfiguration.DeclarantFolder =
                ServiceFactory.getInstance().ConfigurationService.getAppConfiguration().getDeclarantFolder();
            declarantConfiguration.init();

            cmbDatabases.DataSource = declarantConfiguration.DeclarantDatabases;
            cmbDatabases.DisplayMember = "Description";

            cmbDatabases.Enabled = cmbDatabases.Items.Count != 0;
            btnConnect.Enabled = cmbDatabases.Items.Count != 0;
            if(cmbDatabases.Items.Count == 0)
            {
                cmbDatabases.DataSource = null;
            }
        }

        /// <summary>
        /// Получить список деклараций
        /// </summary>
        private void fillDecHeaderList() {
            ServiceFactory.getInstance().ProcessingService.fillDeclarationHeadersList(cmbDeclarations, context);
        }

        /// <summary>
        /// Получить список организаций
        /// </summary>
        private void fillOrganizationsList() {
            ServiceFactory.getInstance().ProcessingService.fillOrganizationsList(cmbOrganizations, context);
        }


        private void MainFrm_Shown(object sender, EventArgs e) {
            init();
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e) {
            ServiceFactory.getInstance().ConfigurationService.callSave();
        }

        private void loadContragents()
        {
            ServiceFactory.getInstance().ProcessingService.processReferences();
        }

        #region DECLARATION
        private void loadDeclaration()
        {
            var decHeader = (DecHeader)cmbDeclarations.SelectedValue;
            if (decHeader == null) {
                ApplicationUtil.showMessage("Не выбрана декларация для импорта!");
                return;
            }

            var organization = (WrkOrg)cmbOrganizations.SelectedValue;
            if (organization == null) {
                ApplicationUtil.showMessage("Не выбрана организация для импорта!");
                return;
            }

            ServiceFactory.getInstance().ProcessingService.processDeclaration(decHeader, organization,
                  cbClearDeclaration.Checked);
        }

        private void checkDeclaration()
        {
            var decHeader = (DecHeader)cmbDeclarations.SelectedValue;
            if (decHeader == null)
            {
                return;
            }

            ServiceFactory.getInstance().CheckService.checkDeclaration(decHeader);
            
        }

        #endregion

        private void openOrganizationReference()
        {
            Form form = FormFactory.getInstance().getUnitForm(typeof(OrganizationForm), context);
            form.Show(FormFactory.getInstance().MainForm);
        }

        private void openContragentsReference() {
            Form form = FormFactory.getInstance().getReferenceList(typeof(ContragentsReference), context);
            form.Show(FormFactory.getInstance().MainForm);
        }

        private void openDeclarationJournal() {
            Form form = FormFactory.getInstance().getDocumentsList(typeof(DeclarationsJournal), context);
            form.Show(FormFactory.getInstance().MainForm);
        }

        private void btnLoadContragents_Click(object sender, EventArgs e) {
            loadContragents();
        }
        
        private void btnConnect_Click(object sender, EventArgs e) {
            if (!context.Hibernate.Connected)
            {
                openDeclaranConnection();
            }
            else
            {
                closeDeclarantConnection();
            }
            
        }

        private void btnErase_Click(object sender, EventArgs e) {
            if (ApplicationUtil.showQuestion("Очистить справочник контрагентов и журнал деклараций?"))
            {
                context.Hibernate.deleteAllContragents();
                //context.Hibernate.executeNoQuery("DELETE FROM wrk_contr_licenses");
                context.Hibernate.executeNoQuery("DELETE FROM DecF11");
                context.Hibernate.executeNoQuery("DELETE FROM DecF12");
                context.Hibernate.executeNoQuery("DELETE FROM DecHeader");
                ApplicationUtil.showMessage("Данные удалены!");
            }
        }

        private void btnLoadDeclaration11_Click(object sender, EventArgs e)
        {
            loadDeclaration();
            ApplicationUtil.showMessage("Загрузка завершена!");
        }

        private void btnRefreshOrganization_Click(object sender, EventArgs e) {
            fillOrganizationsList();
        }

        private void btnRefreshDeclaration_Click(object sender, EventArgs e) {
            fillDecHeaderList();
        }

        private void btnShowOrganization_Click(object sender, EventArgs e)
        {
            openOrganizationReference();
        }

        private void btnShowDeclaration_Click(object sender, EventArgs e)
        {
            openDeclarationJournal();
        }

        private void tsmiProperties_Click(object sender, EventArgs e) {
            showProperties();
        }

        private void tsmiExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void обToolStripMenuItem_Click(object sender, EventArgs e) {
            FormFactory.getInstance().showAboutForm();
        }

        private void btnShowContragents_Click(object sender, EventArgs e)
        {
            openContragentsReference();
        }

        private void btnCheckDeclaration_Click(object sender, EventArgs e)
        {
            checkDeclaration();
        }
    }
}
