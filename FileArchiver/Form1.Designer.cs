namespace FileArchiver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdBrowseSourcePath = new System.Windows.Forms.Button();
            this.chkDateFilter = new System.Windows.Forms.CheckBox();
            this.cmbDateAttribute = new System.Windows.Forms.ComboBox();
            this.cmbDateDirection = new System.Windows.Forms.ComboBox();
            this.dtpDateFilterStart = new System.Windows.Forms.DateTimePicker();
            this.chkTypeFilter = new System.Windows.Forms.CheckBox();
            this.dtpDateFilterEnd = new System.Windows.Forms.DateTimePicker();
            this.lblDateAnd = new System.Windows.Forms.Label();
            this.chklstFileTypes = new System.Windows.Forms.CheckedListBox();
            this.cmdSelectAllTypes = new System.Windows.Forms.Button();
            this.cmdSelectNoTypes = new System.Windows.Forms.Button();
            this.cmdSelectCommonTypes = new System.Windows.Forms.Button();
            this.cmdScanSource = new System.Windows.Forms.Button();
            this.chkFileSizeFilter = new System.Windows.Forms.CheckBox();
            this.cmbSizeMode = new System.Windows.Forms.ComboBox();
            this.nudSizeStart = new System.Windows.Forms.NumericUpDown();
            this.cmbSizeStartUnit = new System.Windows.Forms.ComboBox();
            this.cmbSizeEndUnit = new System.Windows.Forms.ComboBox();
            this.nudSizeEnd = new System.Windows.Forms.NumericUpDown();
            this.lblSizeAnd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAttributeFilter = new System.Windows.Forms.CheckBox();
            this.chkFilterReadonly = new System.Windows.Forms.CheckBox();
            this.cmbFilterReadonly = new System.Windows.Forms.ComboBox();
            this.chkFilterHidden = new System.Windows.Forms.CheckBox();
            this.chkFilterArchived = new System.Windows.Forms.CheckBox();
            this.cmbFilterHidden = new System.Windows.Forms.ComboBox();
            this.cmbFilterArchived = new System.Windows.Forms.ComboBox();
            this.cmbFilterSystem = new System.Windows.Forms.ComboBox();
            this.chkFilterSystem = new System.Windows.Forms.CheckBox();
            this.cmbActionType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbActionSystem = new System.Windows.Forms.ComboBox();
            this.chkActionSystem = new System.Windows.Forms.CheckBox();
            this.cmbActionArchived = new System.Windows.Forms.ComboBox();
            this.cmbActionHidden = new System.Windows.Forms.ComboBox();
            this.chkActionArchived = new System.Windows.Forms.CheckBox();
            this.chkActionHidden = new System.Windows.Forms.CheckBox();
            this.cmbActionReadonly = new System.Windows.Forms.ComboBox();
            this.chkActionReadonly = new System.Windows.Forms.CheckBox();
            this.txtPreviewFilters = new System.Windows.Forms.TextBox();
            this.cmdPreviewFilters = new System.Windows.Forms.Button();
            this.lblTotalFiles = new System.Windows.Forms.Label();
            this.lblTotalFileSize = new System.Windows.Forms.Label();
            this.lblSelectedSize = new System.Windows.Forms.Label();
            this.lblSelectedFiles = new System.Windows.Forms.Label();
            this.lblOutputDirectory = new System.Windows.Forms.Label();
            this.cmdBrowserOutput = new System.Windows.Forms.Button();
            this.txtOutputDirectory = new System.Windows.Forms.TextBox();
            this.lblDeleteWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceDirectory.Location = new System.Drawing.Point(13, 26);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(587, 20);
            this.txtSourceDirectory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Directory";
            // 
            // cmdBrowseSourcePath
            // 
            this.cmdBrowseSourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBrowseSourcePath.Location = new System.Drawing.Point(606, 24);
            this.cmdBrowseSourcePath.Name = "cmdBrowseSourcePath";
            this.cmdBrowseSourcePath.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowseSourcePath.TabIndex = 2;
            this.cmdBrowseSourcePath.Text = "Browse...";
            this.cmdBrowseSourcePath.UseVisualStyleBackColor = true;
            this.cmdBrowseSourcePath.Click += new System.EventHandler(this.cmdBrowseSourcePath_Click);
            // 
            // chkDateFilter
            // 
            this.chkDateFilter.AutoSize = true;
            this.chkDateFilter.Location = new System.Drawing.Point(14, 69);
            this.chkDateFilter.Name = "chkDateFilter";
            this.chkDateFilter.Size = new System.Drawing.Size(77, 17);
            this.chkDateFilter.TabIndex = 3;
            this.chkDateFilter.Text = "Date Filter:";
            this.chkDateFilter.UseVisualStyleBackColor = true;
            this.chkDateFilter.CheckedChanged += new System.EventHandler(this.chkDateFilter_CheckedChanged);
            // 
            // cmbDateAttribute
            // 
            this.cmbDateAttribute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateAttribute.Enabled = false;
            this.cmbDateAttribute.FormattingEnabled = true;
            this.cmbDateAttribute.Items.AddRange(new object[] {
            "Created",
            "Modified",
            "Last Accessed"});
            this.cmbDateAttribute.Location = new System.Drawing.Point(97, 67);
            this.cmbDateAttribute.Name = "cmbDateAttribute";
            this.cmbDateAttribute.Size = new System.Drawing.Size(121, 21);
            this.cmbDateAttribute.TabIndex = 4;
            // 
            // cmbDateDirection
            // 
            this.cmbDateDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateDirection.Enabled = false;
            this.cmbDateDirection.FormattingEnabled = true;
            this.cmbDateDirection.Items.AddRange(new object[] {
            "before",
            "after",
            "between"});
            this.cmbDateDirection.Location = new System.Drawing.Point(224, 67);
            this.cmbDateDirection.Name = "cmbDateDirection";
            this.cmbDateDirection.Size = new System.Drawing.Size(121, 21);
            this.cmbDateDirection.TabIndex = 5;
            this.cmbDateDirection.SelectedIndexChanged += new System.EventHandler(this.cmbDateDirection_SelectedIndexChanged);
            // 
            // dtpDateFilterStart
            // 
            this.dtpDateFilterStart.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dtpDateFilterStart.Enabled = false;
            this.dtpDateFilterStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFilterStart.Location = new System.Drawing.Point(351, 67);
            this.dtpDateFilterStart.Name = "dtpDateFilterStart";
            this.dtpDateFilterStart.Size = new System.Drawing.Size(165, 20);
            this.dtpDateFilterStart.TabIndex = 6;
            // 
            // chkTypeFilter
            // 
            this.chkTypeFilter.AutoSize = true;
            this.chkTypeFilter.Location = new System.Drawing.Point(14, 95);
            this.chkTypeFilter.Name = "chkTypeFilter";
            this.chkTypeFilter.Size = new System.Drawing.Size(97, 17);
            this.chkTypeFilter.TabIndex = 7;
            this.chkTypeFilter.Text = "File Type Filter:";
            this.chkTypeFilter.UseVisualStyleBackColor = true;
            this.chkTypeFilter.CheckedChanged += new System.EventHandler(this.chkTypeFilter_CheckedChanged);
            // 
            // dtpDateFilterEnd
            // 
            this.dtpDateFilterEnd.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dtpDateFilterEnd.Enabled = false;
            this.dtpDateFilterEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFilterEnd.Location = new System.Drawing.Point(553, 67);
            this.dtpDateFilterEnd.Name = "dtpDateFilterEnd";
            this.dtpDateFilterEnd.Size = new System.Drawing.Size(165, 20);
            this.dtpDateFilterEnd.TabIndex = 8;
            // 
            // lblDateAnd
            // 
            this.lblDateAnd.AutoSize = true;
            this.lblDateAnd.Enabled = false;
            this.lblDateAnd.Location = new System.Drawing.Point(522, 70);
            this.lblDateAnd.Name = "lblDateAnd";
            this.lblDateAnd.Size = new System.Drawing.Size(25, 13);
            this.lblDateAnd.TabIndex = 9;
            this.lblDateAnd.Text = "and";
            // 
            // chklstFileTypes
            // 
            this.chklstFileTypes.Enabled = false;
            this.chklstFileTypes.FormattingEnabled = true;
            this.chklstFileTypes.IntegralHeight = false;
            this.chklstFileTypes.Location = new System.Drawing.Point(117, 97);
            this.chklstFileTypes.Name = "chklstFileTypes";
            this.chklstFileTypes.Size = new System.Drawing.Size(122, 109);
            this.chklstFileTypes.TabIndex = 10;
            // 
            // cmdSelectAllTypes
            // 
            this.cmdSelectAllTypes.Enabled = false;
            this.cmdSelectAllTypes.Location = new System.Drawing.Point(245, 97);
            this.cmdSelectAllTypes.Name = "cmdSelectAllTypes";
            this.cmdSelectAllTypes.Size = new System.Drawing.Size(100, 23);
            this.cmdSelectAllTypes.TabIndex = 11;
            this.cmdSelectAllTypes.Text = "Select All";
            this.cmdSelectAllTypes.UseVisualStyleBackColor = true;
            this.cmdSelectAllTypes.Click += new System.EventHandler(this.cmdSelectAllTypes_Click);
            // 
            // cmdSelectNoTypes
            // 
            this.cmdSelectNoTypes.Enabled = false;
            this.cmdSelectNoTypes.Location = new System.Drawing.Point(245, 155);
            this.cmdSelectNoTypes.Name = "cmdSelectNoTypes";
            this.cmdSelectNoTypes.Size = new System.Drawing.Size(100, 23);
            this.cmdSelectNoTypes.TabIndex = 12;
            this.cmdSelectNoTypes.Text = "Select None";
            this.cmdSelectNoTypes.UseVisualStyleBackColor = true;
            this.cmdSelectNoTypes.Click += new System.EventHandler(this.cmdSelectNoTypes_Click);
            // 
            // cmdSelectCommonTypes
            // 
            this.cmdSelectCommonTypes.Enabled = false;
            this.cmdSelectCommonTypes.Location = new System.Drawing.Point(245, 126);
            this.cmdSelectCommonTypes.Name = "cmdSelectCommonTypes";
            this.cmdSelectCommonTypes.Size = new System.Drawing.Size(100, 23);
            this.cmdSelectCommonTypes.TabIndex = 13;
            this.cmdSelectCommonTypes.Text = "Select Common";
            this.cmdSelectCommonTypes.UseVisualStyleBackColor = true;
            this.cmdSelectCommonTypes.Click += new System.EventHandler(this.cmdSelectCommonTypes_Click);
            // 
            // cmdScanSource
            // 
            this.cmdScanSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdScanSource.Location = new System.Drawing.Point(687, 24);
            this.cmdScanSource.Name = "cmdScanSource";
            this.cmdScanSource.Size = new System.Drawing.Size(85, 23);
            this.cmdScanSource.TabIndex = 14;
            this.cmdScanSource.Text = "Scan Source";
            this.cmdScanSource.UseVisualStyleBackColor = true;
            this.cmdScanSource.Click += new System.EventHandler(this.cmdScanSource_Click);
            // 
            // chkFileSizeFilter
            // 
            this.chkFileSizeFilter.AutoSize = true;
            this.chkFileSizeFilter.Location = new System.Drawing.Point(351, 95);
            this.chkFileSizeFilter.Name = "chkFileSizeFilter";
            this.chkFileSizeFilter.Size = new System.Drawing.Size(93, 17);
            this.chkFileSizeFilter.TabIndex = 15;
            this.chkFileSizeFilter.Text = "File Size Filter:";
            this.chkFileSizeFilter.UseVisualStyleBackColor = true;
            this.chkFileSizeFilter.CheckedChanged += new System.EventHandler(this.chkFileSizeFilter_CheckedChanged);
            // 
            // cmbSizeMode
            // 
            this.cmbSizeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeMode.Enabled = false;
            this.cmbSizeMode.FormattingEnabled = true;
            this.cmbSizeMode.Items.AddRange(new object[] {
            "Larger than",
            "Smaller than",
            "Between"});
            this.cmbSizeMode.Location = new System.Drawing.Point(450, 93);
            this.cmbSizeMode.Name = "cmbSizeMode";
            this.cmbSizeMode.Size = new System.Drawing.Size(121, 21);
            this.cmbSizeMode.TabIndex = 16;
            this.cmbSizeMode.SelectedIndexChanged += new System.EventHandler(this.cmbSizeMode_SelectedIndexChanged);
            // 
            // nudSizeStart
            // 
            this.nudSizeStart.Enabled = false;
            this.nudSizeStart.Location = new System.Drawing.Point(577, 94);
            this.nudSizeStart.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudSizeStart.Name = "nudSizeStart";
            this.nudSizeStart.Size = new System.Drawing.Size(122, 20);
            this.nudSizeStart.TabIndex = 17;
            // 
            // cmbSizeStartUnit
            // 
            this.cmbSizeStartUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeStartUnit.Enabled = false;
            this.cmbSizeStartUnit.FormattingEnabled = true;
            this.cmbSizeStartUnit.Items.AddRange(new object[] {
            "Bytes",
            "KiB",
            "MiB",
            "GiB",
            "TiB",
            "PiB",
            "EiB"});
            this.cmbSizeStartUnit.Location = new System.Drawing.Point(705, 93);
            this.cmbSizeStartUnit.Name = "cmbSizeStartUnit";
            this.cmbSizeStartUnit.Size = new System.Drawing.Size(58, 21);
            this.cmbSizeStartUnit.TabIndex = 18;
            // 
            // cmbSizeEndUnit
            // 
            this.cmbSizeEndUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeEndUnit.Enabled = false;
            this.cmbSizeEndUnit.FormattingEnabled = true;
            this.cmbSizeEndUnit.Items.AddRange(new object[] {
            "Bytes",
            "KiB",
            "MiB",
            "GiB",
            "TiB",
            "PiB",
            "EiB"});
            this.cmbSizeEndUnit.Location = new System.Drawing.Point(705, 119);
            this.cmbSizeEndUnit.Name = "cmbSizeEndUnit";
            this.cmbSizeEndUnit.Size = new System.Drawing.Size(58, 21);
            this.cmbSizeEndUnit.TabIndex = 20;
            this.cmbSizeEndUnit.Visible = false;
            // 
            // nudSizeEnd
            // 
            this.nudSizeEnd.Enabled = false;
            this.nudSizeEnd.Location = new System.Drawing.Point(577, 120);
            this.nudSizeEnd.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudSizeEnd.Name = "nudSizeEnd";
            this.nudSizeEnd.Size = new System.Drawing.Size(122, 20);
            this.nudSizeEnd.TabIndex = 19;
            this.nudSizeEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSizeEnd.Visible = false;
            // 
            // lblSizeAnd
            // 
            this.lblSizeAnd.AutoSize = true;
            this.lblSizeAnd.Enabled = false;
            this.lblSizeAnd.Location = new System.Drawing.Point(546, 123);
            this.lblSizeAnd.Name = "lblSizeAnd";
            this.lblSizeAnd.Size = new System.Drawing.Size(25, 13);
            this.lblSizeAnd.TabIndex = 21;
            this.lblSizeAnd.Text = "and";
            this.lblSizeAnd.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Selected File Operation:";
            // 
            // chkAttributeFilter
            // 
            this.chkAttributeFilter.AutoSize = true;
            this.chkAttributeFilter.Location = new System.Drawing.Point(351, 152);
            this.chkAttributeFilter.Name = "chkAttributeFilter";
            this.chkAttributeFilter.Size = new System.Drawing.Size(93, 17);
            this.chkAttributeFilter.TabIndex = 23;
            this.chkAttributeFilter.Text = "Attribute Filter:";
            this.chkAttributeFilter.UseVisualStyleBackColor = true;
            this.chkAttributeFilter.CheckedChanged += new System.EventHandler(this.chkAttributeFilter_CheckedChanged);
            // 
            // chkFilterReadonly
            // 
            this.chkFilterReadonly.AutoSize = true;
            this.chkFilterReadonly.Enabled = false;
            this.chkFilterReadonly.Location = new System.Drawing.Point(450, 152);
            this.chkFilterReadonly.Name = "chkFilterReadonly";
            this.chkFilterReadonly.Size = new System.Drawing.Size(74, 17);
            this.chkFilterReadonly.TabIndex = 24;
            this.chkFilterReadonly.Text = "Readonly:";
            this.chkFilterReadonly.UseVisualStyleBackColor = true;
            this.chkFilterReadonly.CheckedChanged += new System.EventHandler(this.chkFilterReadonly_CheckedChanged);
            // 
            // cmbFilterReadonly
            // 
            this.cmbFilterReadonly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterReadonly.Enabled = false;
            this.cmbFilterReadonly.FormattingEnabled = true;
            this.cmbFilterReadonly.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbFilterReadonly.Location = new System.Drawing.Point(530, 150);
            this.cmbFilterReadonly.Name = "cmbFilterReadonly";
            this.cmbFilterReadonly.Size = new System.Drawing.Size(69, 21);
            this.cmbFilterReadonly.TabIndex = 25;
            // 
            // chkFilterHidden
            // 
            this.chkFilterHidden.AutoSize = true;
            this.chkFilterHidden.Enabled = false;
            this.chkFilterHidden.Location = new System.Drawing.Point(620, 152);
            this.chkFilterHidden.Name = "chkFilterHidden";
            this.chkFilterHidden.Size = new System.Drawing.Size(63, 17);
            this.chkFilterHidden.TabIndex = 26;
            this.chkFilterHidden.Text = "Hidden:";
            this.chkFilterHidden.UseVisualStyleBackColor = true;
            this.chkFilterHidden.CheckedChanged += new System.EventHandler(this.chkFilterHidden_CheckedChanged);
            // 
            // chkFilterArchived
            // 
            this.chkFilterArchived.AutoSize = true;
            this.chkFilterArchived.Enabled = false;
            this.chkFilterArchived.Location = new System.Drawing.Point(450, 179);
            this.chkFilterArchived.Name = "chkFilterArchived";
            this.chkFilterArchived.Size = new System.Drawing.Size(71, 17);
            this.chkFilterArchived.TabIndex = 28;
            this.chkFilterArchived.Text = "Archived:";
            this.chkFilterArchived.UseVisualStyleBackColor = true;
            this.chkFilterArchived.CheckedChanged += new System.EventHandler(this.chkFilterArchived_CheckedChanged);
            // 
            // cmbFilterHidden
            // 
            this.cmbFilterHidden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterHidden.Enabled = false;
            this.cmbFilterHidden.FormattingEnabled = true;
            this.cmbFilterHidden.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbFilterHidden.Location = new System.Drawing.Point(689, 150);
            this.cmbFilterHidden.Name = "cmbFilterHidden";
            this.cmbFilterHidden.Size = new System.Drawing.Size(69, 21);
            this.cmbFilterHidden.TabIndex = 31;
            // 
            // cmbFilterArchived
            // 
            this.cmbFilterArchived.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterArchived.Enabled = false;
            this.cmbFilterArchived.FormattingEnabled = true;
            this.cmbFilterArchived.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbFilterArchived.Location = new System.Drawing.Point(530, 177);
            this.cmbFilterArchived.Name = "cmbFilterArchived";
            this.cmbFilterArchived.Size = new System.Drawing.Size(69, 21);
            this.cmbFilterArchived.TabIndex = 32;
            // 
            // cmbFilterSystem
            // 
            this.cmbFilterSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterSystem.Enabled = false;
            this.cmbFilterSystem.FormattingEnabled = true;
            this.cmbFilterSystem.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbFilterSystem.Location = new System.Drawing.Point(689, 177);
            this.cmbFilterSystem.Name = "cmbFilterSystem";
            this.cmbFilterSystem.Size = new System.Drawing.Size(69, 21);
            this.cmbFilterSystem.TabIndex = 34;
            // 
            // chkFilterSystem
            // 
            this.chkFilterSystem.AutoSize = true;
            this.chkFilterSystem.Enabled = false;
            this.chkFilterSystem.Location = new System.Drawing.Point(620, 179);
            this.chkFilterSystem.Name = "chkFilterSystem";
            this.chkFilterSystem.Size = new System.Drawing.Size(63, 17);
            this.chkFilterSystem.TabIndex = 33;
            this.chkFilterSystem.Text = "System:";
            this.chkFilterSystem.UseVisualStyleBackColor = true;
            this.chkFilterSystem.CheckedChanged += new System.EventHandler(this.chkFilterSystem_CheckedChanged);
            // 
            // cmbActionType
            // 
            this.cmbActionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionType.FormattingEnabled = true;
            this.cmbActionType.Items.AddRange(new object[] {
            "Set Attribute",
            "Copy",
            "Move",
            "Delete"});
            this.cmbActionType.Location = new System.Drawing.Point(138, 355);
            this.cmbActionType.Name = "cmbActionType";
            this.cmbActionType.Size = new System.Drawing.Size(102, 21);
            this.cmbActionType.TabIndex = 35;
            this.cmbActionType.SelectedIndexChanged += new System.EventHandler(this.cmbActionType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Only process files which match all of these selected filters:";
            // 
            // cmbActionSystem
            // 
            this.cmbActionSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbActionSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionSystem.Enabled = false;
            this.cmbActionSystem.FormattingEnabled = true;
            this.cmbActionSystem.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbActionSystem.Location = new System.Drawing.Point(494, 382);
            this.cmbActionSystem.Name = "cmbActionSystem";
            this.cmbActionSystem.Size = new System.Drawing.Size(69, 21);
            this.cmbActionSystem.TabIndex = 44;
            this.cmbActionSystem.Visible = false;
            // 
            // chkActionSystem
            // 
            this.chkActionSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkActionSystem.AutoSize = true;
            this.chkActionSystem.Location = new System.Drawing.Point(425, 384);
            this.chkActionSystem.Name = "chkActionSystem";
            this.chkActionSystem.Size = new System.Drawing.Size(63, 17);
            this.chkActionSystem.TabIndex = 43;
            this.chkActionSystem.Text = "System:";
            this.chkActionSystem.UseVisualStyleBackColor = true;
            this.chkActionSystem.Visible = false;
            this.chkActionSystem.CheckedChanged += new System.EventHandler(this.chkActionSystem_CheckedChanged);
            // 
            // cmbActionArchived
            // 
            this.cmbActionArchived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbActionArchived.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionArchived.Enabled = false;
            this.cmbActionArchived.FormattingEnabled = true;
            this.cmbActionArchived.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbActionArchived.Location = new System.Drawing.Point(335, 382);
            this.cmbActionArchived.Name = "cmbActionArchived";
            this.cmbActionArchived.Size = new System.Drawing.Size(69, 21);
            this.cmbActionArchived.TabIndex = 42;
            this.cmbActionArchived.Visible = false;
            // 
            // cmbActionHidden
            // 
            this.cmbActionHidden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbActionHidden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionHidden.Enabled = false;
            this.cmbActionHidden.FormattingEnabled = true;
            this.cmbActionHidden.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbActionHidden.Location = new System.Drawing.Point(494, 355);
            this.cmbActionHidden.Name = "cmbActionHidden";
            this.cmbActionHidden.Size = new System.Drawing.Size(69, 21);
            this.cmbActionHidden.TabIndex = 41;
            this.cmbActionHidden.Visible = false;
            // 
            // chkActionArchived
            // 
            this.chkActionArchived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkActionArchived.AutoSize = true;
            this.chkActionArchived.Location = new System.Drawing.Point(255, 384);
            this.chkActionArchived.Name = "chkActionArchived";
            this.chkActionArchived.Size = new System.Drawing.Size(71, 17);
            this.chkActionArchived.TabIndex = 40;
            this.chkActionArchived.Text = "Archived:";
            this.chkActionArchived.UseVisualStyleBackColor = true;
            this.chkActionArchived.Visible = false;
            this.chkActionArchived.CheckedChanged += new System.EventHandler(this.chkActionArchived_CheckedChanged);
            // 
            // chkActionHidden
            // 
            this.chkActionHidden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkActionHidden.AutoSize = true;
            this.chkActionHidden.Location = new System.Drawing.Point(425, 357);
            this.chkActionHidden.Name = "chkActionHidden";
            this.chkActionHidden.Size = new System.Drawing.Size(63, 17);
            this.chkActionHidden.TabIndex = 39;
            this.chkActionHidden.Text = "Hidden:";
            this.chkActionHidden.UseVisualStyleBackColor = true;
            this.chkActionHidden.Visible = false;
            this.chkActionHidden.CheckedChanged += new System.EventHandler(this.chkActionHidden_CheckedChanged);
            // 
            // cmbActionReadonly
            // 
            this.cmbActionReadonly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbActionReadonly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionReadonly.Enabled = false;
            this.cmbActionReadonly.FormattingEnabled = true;
            this.cmbActionReadonly.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbActionReadonly.Location = new System.Drawing.Point(335, 355);
            this.cmbActionReadonly.Name = "cmbActionReadonly";
            this.cmbActionReadonly.Size = new System.Drawing.Size(69, 21);
            this.cmbActionReadonly.TabIndex = 38;
            this.cmbActionReadonly.Visible = false;
            // 
            // chkActionReadonly
            // 
            this.chkActionReadonly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkActionReadonly.AutoSize = true;
            this.chkActionReadonly.Location = new System.Drawing.Point(255, 357);
            this.chkActionReadonly.Name = "chkActionReadonly";
            this.chkActionReadonly.Size = new System.Drawing.Size(74, 17);
            this.chkActionReadonly.TabIndex = 37;
            this.chkActionReadonly.Text = "Readonly:";
            this.chkActionReadonly.UseVisualStyleBackColor = true;
            this.chkActionReadonly.Visible = false;
            this.chkActionReadonly.CheckedChanged += new System.EventHandler(this.chkActionReadonly_CheckedChanged);
            // 
            // txtPreviewFilters
            // 
            this.txtPreviewFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreviewFilters.Location = new System.Drawing.Point(14, 241);
            this.txtPreviewFilters.Multiline = true;
            this.txtPreviewFilters.Name = "txtPreviewFilters";
            this.txtPreviewFilters.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPreviewFilters.Size = new System.Drawing.Size(759, 108);
            this.txtPreviewFilters.TabIndex = 46;
            // 
            // cmdPreviewFilters
            // 
            this.cmdPreviewFilters.Location = new System.Drawing.Point(15, 212);
            this.cmdPreviewFilters.Name = "cmdPreviewFilters";
            this.cmdPreviewFilters.Size = new System.Drawing.Size(134, 23);
            this.cmdPreviewFilters.TabIndex = 47;
            this.cmdPreviewFilters.Text = "Preview filter results:";
            this.cmdPreviewFilters.UseVisualStyleBackColor = true;
            this.cmdPreviewFilters.Click += new System.EventHandler(this.cmdPreviewFilters_Click);
            // 
            // lblTotalFiles
            // 
            this.lblTotalFiles.AutoSize = true;
            this.lblTotalFiles.Location = new System.Drawing.Point(155, 217);
            this.lblTotalFiles.Name = "lblTotalFiles";
            this.lblTotalFiles.Size = new System.Drawing.Size(61, 13);
            this.lblTotalFiles.TabIndex = 48;
            this.lblTotalFiles.Text = "Total Files: ";
            // 
            // lblTotalFileSize
            // 
            this.lblTotalFileSize.AutoSize = true;
            this.lblTotalFileSize.Location = new System.Drawing.Point(294, 217);
            this.lblTotalFileSize.Name = "lblTotalFileSize";
            this.lblTotalFileSize.Size = new System.Drawing.Size(79, 13);
            this.lblTotalFileSize.TabIndex = 49;
            this.lblTotalFileSize.Text = "Total File Size: ";
            // 
            // lblSelectedSize
            // 
            this.lblSelectedSize.AutoSize = true;
            this.lblSelectedSize.Location = new System.Drawing.Point(604, 217);
            this.lblSelectedSize.Name = "lblSelectedSize";
            this.lblSelectedSize.Size = new System.Drawing.Size(97, 13);
            this.lblSelectedSize.TabIndex = 51;
            this.lblSelectedSize.Text = "Selected File Size: ";
            // 
            // lblSelectedFiles
            // 
            this.lblSelectedFiles.AutoSize = true;
            this.lblSelectedFiles.Location = new System.Drawing.Point(447, 217);
            this.lblSelectedFiles.Name = "lblSelectedFiles";
            this.lblSelectedFiles.Size = new System.Drawing.Size(79, 13);
            this.lblSelectedFiles.TabIndex = 50;
            this.lblSelectedFiles.Text = "Selected Files: ";
            // 
            // lblOutputDirectory
            // 
            this.lblOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOutputDirectory.AutoSize = true;
            this.lblOutputDirectory.Location = new System.Drawing.Point(12, 391);
            this.lblOutputDirectory.Name = "lblOutputDirectory";
            this.lblOutputDirectory.Size = new System.Drawing.Size(87, 13);
            this.lblOutputDirectory.TabIndex = 52;
            this.lblOutputDirectory.Text = "Output Directory:";
            this.lblOutputDirectory.Visible = false;
            // 
            // cmdBrowserOutput
            // 
            this.cmdBrowserOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBrowserOutput.Location = new System.Drawing.Point(697, 405);
            this.cmdBrowserOutput.Name = "cmdBrowserOutput";
            this.cmdBrowserOutput.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowserOutput.TabIndex = 54;
            this.cmdBrowserOutput.Text = "Browse...";
            this.cmdBrowserOutput.UseVisualStyleBackColor = true;
            this.cmdBrowserOutput.Visible = false;
            this.cmdBrowserOutput.Click += new System.EventHandler(this.cmdBrowserOutput_Click);
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputDirectory.Location = new System.Drawing.Point(15, 407);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.Size = new System.Drawing.Size(676, 20);
            this.txtOutputDirectory.TabIndex = 53;
            this.txtOutputDirectory.Visible = false;
            // 
            // lblDeleteWarning
            // 
            this.lblDeleteWarning.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDeleteWarning.AutoSize = true;
            this.lblDeleteWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteWarning.ForeColor = System.Drawing.Color.Red;
            this.lblDeleteWarning.Location = new System.Drawing.Point(138, 377);
            this.lblDeleteWarning.Name = "lblDeleteWarning";
            this.lblDeleteWarning.Size = new System.Drawing.Size(508, 40);
            this.lblDeleteWarning.TabIndex = 55;
            this.lblDeleteWarning.Text = "WARNING! This will permanently delete all files that match the filters.\r\nUse the " +
    "Preview Filter Results button to see all files that will be deleted.";
            this.lblDeleteWarning.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.cmdBrowserOutput);
            this.Controls.Add(this.txtOutputDirectory);
            this.Controls.Add(this.lblOutputDirectory);
            this.Controls.Add(this.lblSelectedSize);
            this.Controls.Add(this.lblSelectedFiles);
            this.Controls.Add(this.lblTotalFileSize);
            this.Controls.Add(this.lblTotalFiles);
            this.Controls.Add(this.cmdPreviewFilters);
            this.Controls.Add(this.txtPreviewFilters);
            this.Controls.Add(this.cmbActionSystem);
            this.Controls.Add(this.chkActionSystem);
            this.Controls.Add(this.cmbActionArchived);
            this.Controls.Add(this.cmbActionHidden);
            this.Controls.Add(this.chkActionArchived);
            this.Controls.Add(this.chkActionHidden);
            this.Controls.Add(this.cmbActionReadonly);
            this.Controls.Add(this.chkActionReadonly);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbActionType);
            this.Controls.Add(this.cmbFilterSystem);
            this.Controls.Add(this.chkFilterSystem);
            this.Controls.Add(this.cmbFilterArchived);
            this.Controls.Add(this.cmbFilterHidden);
            this.Controls.Add(this.chkFilterArchived);
            this.Controls.Add(this.chkFilterHidden);
            this.Controls.Add(this.cmbFilterReadonly);
            this.Controls.Add(this.chkFilterReadonly);
            this.Controls.Add(this.chkAttributeFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSizeAnd);
            this.Controls.Add(this.cmbSizeEndUnit);
            this.Controls.Add(this.nudSizeEnd);
            this.Controls.Add(this.cmbSizeStartUnit);
            this.Controls.Add(this.nudSizeStart);
            this.Controls.Add(this.cmbSizeMode);
            this.Controls.Add(this.chkFileSizeFilter);
            this.Controls.Add(this.cmdScanSource);
            this.Controls.Add(this.cmdSelectCommonTypes);
            this.Controls.Add(this.cmdSelectNoTypes);
            this.Controls.Add(this.cmdSelectAllTypes);
            this.Controls.Add(this.chklstFileTypes);
            this.Controls.Add(this.lblDateAnd);
            this.Controls.Add(this.dtpDateFilterEnd);
            this.Controls.Add(this.chkTypeFilter);
            this.Controls.Add(this.dtpDateFilterStart);
            this.Controls.Add(this.cmbDateDirection);
            this.Controls.Add(this.cmbDateAttribute);
            this.Controls.Add(this.chkDateFilter);
            this.Controls.Add(this.cmdBrowseSourcePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSourceDirectory);
            this.Controls.Add(this.lblDeleteWarning);
            this.MinimumSize = new System.Drawing.Size(800, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Archiver";
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdBrowseSourcePath;
        private System.Windows.Forms.CheckBox chkDateFilter;
        private System.Windows.Forms.ComboBox cmbDateAttribute;
        private System.Windows.Forms.ComboBox cmbDateDirection;
        private System.Windows.Forms.DateTimePicker dtpDateFilterStart;
        private System.Windows.Forms.CheckBox chkTypeFilter;
        private System.Windows.Forms.DateTimePicker dtpDateFilterEnd;
        private System.Windows.Forms.Label lblDateAnd;
        private System.Windows.Forms.CheckedListBox chklstFileTypes;
        private System.Windows.Forms.Button cmdSelectAllTypes;
        private System.Windows.Forms.Button cmdSelectNoTypes;
        private System.Windows.Forms.Button cmdSelectCommonTypes;
        private System.Windows.Forms.Button cmdScanSource;
        private System.Windows.Forms.CheckBox chkFileSizeFilter;
        private System.Windows.Forms.ComboBox cmbSizeMode;
        private System.Windows.Forms.NumericUpDown nudSizeStart;
        private System.Windows.Forms.ComboBox cmbSizeStartUnit;
        private System.Windows.Forms.ComboBox cmbSizeEndUnit;
        private System.Windows.Forms.NumericUpDown nudSizeEnd;
        private System.Windows.Forms.Label lblSizeAnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAttributeFilter;
        private System.Windows.Forms.CheckBox chkFilterReadonly;
        private System.Windows.Forms.ComboBox cmbFilterReadonly;
        private System.Windows.Forms.CheckBox chkFilterHidden;
        private System.Windows.Forms.CheckBox chkFilterArchived;
        private System.Windows.Forms.ComboBox cmbFilterHidden;
        private System.Windows.Forms.ComboBox cmbFilterArchived;
        private System.Windows.Forms.ComboBox cmbFilterSystem;
        private System.Windows.Forms.CheckBox chkFilterSystem;
        private System.Windows.Forms.ComboBox cmbActionType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbActionSystem;
        private System.Windows.Forms.CheckBox chkActionSystem;
        private System.Windows.Forms.ComboBox cmbActionArchived;
        private System.Windows.Forms.ComboBox cmbActionHidden;
        private System.Windows.Forms.CheckBox chkActionArchived;
        private System.Windows.Forms.CheckBox chkActionHidden;
        private System.Windows.Forms.ComboBox cmbActionReadonly;
        private System.Windows.Forms.CheckBox chkActionReadonly;
        private System.Windows.Forms.TextBox txtPreviewFilters;
        private System.Windows.Forms.Button cmdPreviewFilters;
        private System.Windows.Forms.Label lblTotalFiles;
        private System.Windows.Forms.Label lblTotalFileSize;
        private System.Windows.Forms.Label lblSelectedSize;
        private System.Windows.Forms.Label lblSelectedFiles;
        private System.Windows.Forms.Label lblOutputDirectory;
        private System.Windows.Forms.Button cmdBrowserOutput;
        private System.Windows.Forms.TextBox txtOutputDirectory;
        private System.Windows.Forms.Label lblDeleteWarning;
    }
}

