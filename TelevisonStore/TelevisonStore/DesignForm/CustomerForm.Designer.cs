﻿namespace TelevisonStore.DesignForm
{
    partial class CustomerForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxPageSize = new System.Windows.Forms.ComboBox();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelFuntion = new System.Windows.Forms.Panel();
            this.labelCountRecord = new System.Windows.Forms.Label();
            this.textBoxPageNumber = new System.Windows.Forms.TextBox();
            this.pagePrev = new FontAwesome.Sharp.IconButton();
            this.pageNext = new FontAwesome.Sharp.IconButton();
            this.panelUpdateData = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.notAcitve = new System.Windows.Forms.RadioButton();
            this.active = new System.Windows.Forms.RadioButton();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelFormInput = new System.Windows.Forms.Label();
            this.panelAddress = new System.Windows.Forms.Panel();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.panelName = new System.Windows.Forms.Panel();
            this.panelPhone = new System.Windows.Forms.Panel();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelFuntion.SuspendLayout();
            this.panelUpdateData.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPageSize
            // 
            this.comboBoxPageSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPageSize.FormattingEnabled = true;
            this.comboBoxPageSize.ItemHeight = 23;
            this.comboBoxPageSize.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "50",
            "100"});
            this.comboBoxPageSize.Location = new System.Drawing.Point(3, 36);
            this.comboBoxPageSize.Name = "comboBoxPageSize";
            this.comboBoxPageSize.Size = new System.Drawing.Size(99, 31);
            this.comboBoxPageSize.TabIndex = 16;
            this.comboBoxPageSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxPageSize_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 48;
            this.btnCancel.Location = new System.Drawing.Point(372, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(133, 42);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Hủy Chọn";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 48;
            this.btnDelete.Location = new System.Drawing.Point(181, 508);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Rotation = 0D;
            this.btnDelete.Size = new System.Drawing.Size(133, 42);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(129)))), ((int)(((byte)(25)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 48;
            this.btnEdit.Location = new System.Drawing.Point(12, 508);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Rotation = 0D;
            this.btnEdit.Size = new System.Drawing.Size(133, 42);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(119)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 48;
            this.btnSearch.Location = new System.Drawing.Point(939, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(133, 35);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(119)))));
            this.panelSearch.Location = new System.Drawing.Point(686, 60);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(255, 5);
            this.panelSearch.TabIndex = 11;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxSearch.Location = new System.Drawing.Point(686, 30);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(252, 33);
            this.textBoxSearch.TabIndex = 10;
            this.textBoxSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSearch_MouseClick);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.dataGridView);
            this.panelLeft.Controls.Add(this.panelFuntion);
            this.panelLeft.Location = new System.Drawing.Point(3, 73);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(677, 400);
            this.panelLeft.TabIndex = 9;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.ColumnHeadersHeight = 60;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(677, 360);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
            // 
            // panelFuntion
            // 
            this.panelFuntion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.panelFuntion.Controls.Add(this.labelCountRecord);
            this.panelFuntion.Controls.Add(this.textBoxPageNumber);
            this.panelFuntion.Controls.Add(this.pagePrev);
            this.panelFuntion.Controls.Add(this.pageNext);
            this.panelFuntion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFuntion.Location = new System.Drawing.Point(0, 360);
            this.panelFuntion.Name = "panelFuntion";
            this.panelFuntion.Size = new System.Drawing.Size(677, 40);
            this.panelFuntion.TabIndex = 4;
            // 
            // labelCountRecord
            // 
            this.labelCountRecord.AutoSize = true;
            this.labelCountRecord.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCountRecord.Location = new System.Drawing.Point(3, 9);
            this.labelCountRecord.Name = "labelCountRecord";
            this.labelCountRecord.Size = new System.Drawing.Size(158, 23);
            this.labelCountRecord.TabIndex = 9;
            this.labelCountRecord.Text = "Số lượng bản ghi : ";
            // 
            // textBoxPageNumber
            // 
            this.textBoxPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPageNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.textBoxPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPageNumber.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPageNumber.ForeColor = System.Drawing.Color.White;
            this.textBoxPageNumber.Location = new System.Drawing.Point(604, 4);
            this.textBoxPageNumber.Name = "textBoxPageNumber";
            this.textBoxPageNumber.ReadOnly = true;
            this.textBoxPageNumber.Size = new System.Drawing.Size(32, 31);
            this.textBoxPageNumber.TabIndex = 8;
            this.textBoxPageNumber.Text = "1";
            this.textBoxPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pagePrev
            // 
            this.pagePrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pagePrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.pagePrev.FlatAppearance.BorderSize = 0;
            this.pagePrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagePrev.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.pagePrev.ForeColor = System.Drawing.Color.White;
            this.pagePrev.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.pagePrev.IconColor = System.Drawing.Color.White;
            this.pagePrev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pagePrev.IconSize = 25;
            this.pagePrev.Location = new System.Drawing.Point(575, 3);
            this.pagePrev.Name = "pagePrev";
            this.pagePrev.Rotation = 0D;
            this.pagePrev.Size = new System.Drawing.Size(23, 34);
            this.pagePrev.TabIndex = 6;
            this.pagePrev.UseVisualStyleBackColor = false;
            this.pagePrev.Click += new System.EventHandler(this.pagePrev_Click);
            // 
            // pageNext
            // 
            this.pageNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pageNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.pageNext.FlatAppearance.BorderSize = 0;
            this.pageNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageNext.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.pageNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pageNext.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.pageNext.IconColor = System.Drawing.Color.White;
            this.pageNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pageNext.IconSize = 25;
            this.pageNext.Location = new System.Drawing.Point(642, 3);
            this.pageNext.Name = "pageNext";
            this.pageNext.Rotation = 0D;
            this.pageNext.Size = new System.Drawing.Size(28, 34);
            this.pageNext.TabIndex = 7;
            this.pageNext.UseVisualStyleBackColor = false;
            this.pageNext.Click += new System.EventHandler(this.pageNext_Click);
            // 
            // panelUpdateData
            // 
            this.panelUpdateData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUpdateData.BackColor = System.Drawing.Color.White;
            this.panelUpdateData.Controls.Add(this.buttonRefresh);
            this.panelUpdateData.Controls.Add(this.buttonAdd);
            this.panelUpdateData.Controls.Add(this.notAcitve);
            this.panelUpdateData.Controls.Add(this.active);
            this.panelUpdateData.Controls.Add(this.textBoxId);
            this.panelUpdateData.Controls.Add(this.panelHeader);
            this.panelUpdateData.Controls.Add(this.panelAddress);
            this.panelUpdateData.Controls.Add(this.panelEmail);
            this.panelUpdateData.Controls.Add(this.panelName);
            this.panelUpdateData.Controls.Add(this.panelPhone);
            this.panelUpdateData.Controls.Add(this.textBoxAddress);
            this.panelUpdateData.Controls.Add(this.textBoxEmail);
            this.panelUpdateData.Controls.Add(this.textBoxPhone);
            this.panelUpdateData.Controls.Add(this.textBoxName);
            this.panelUpdateData.Location = new System.Drawing.Point(686, 73);
            this.panelUpdateData.Name = "panelUpdateData";
            this.panelUpdateData.Size = new System.Drawing.Size(386, 477);
            this.panelUpdateData.TabIndex = 8;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRefresh.Location = new System.Drawing.Point(175, 393);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(133, 42);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Nhập lại";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(119)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(14, 393);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 42);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Thêm mới";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // notAcitve
            // 
            this.notAcitve.AutoSize = true;
            this.notAcitve.Location = new System.Drawing.Point(152, 164);
            this.notAcitve.Name = "notAcitve";
            this.notAcitve.Size = new System.Drawing.Size(54, 27);
            this.notAcitve.TabIndex = 5;
            this.notAcitve.Text = "Nữ";
            this.notAcitve.UseVisualStyleBackColor = true;
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Checked = true;
            this.active.Location = new System.Drawing.Point(14, 165);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(70, 27);
            this.active.TabIndex = 4;
            this.active.TabStop = true;
            this.active.Text = "Nam";
            this.active.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.ForeColor = System.Drawing.Color.Black;
            this.textBoxId.Location = new System.Drawing.Point(3, 447);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(383, 30);
            this.textBoxId.TabIndex = 3;
            this.textBoxId.Text = "0";
            this.textBoxId.Visible = false;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(119)))));
            this.panelHeader.Controls.Add(this.labelFormInput);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(386, 60);
            this.panelHeader.TabIndex = 2;
            // 
            // labelFormInput
            // 
            this.labelFormInput.AutoSize = true;
            this.labelFormInput.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormInput.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFormInput.Location = new System.Drawing.Point(9, 15);
            this.labelFormInput.Name = "labelFormInput";
            this.labelFormInput.Size = new System.Drawing.Size(171, 26);
            this.labelFormInput.TabIndex = 0;
            this.labelFormInput.Text = "Cập nhật dữ liệu";
            // 
            // panelAddress
            // 
            this.panelAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(119)))));
            this.panelAddress.Location = new System.Drawing.Point(14, 355);
            this.panelAddress.Name = "panelAddress";
            this.panelAddress.Size = new System.Drawing.Size(351, 5);
            this.panelAddress.TabIndex = 1;
            // 
            // panelEmail
            // 
            this.panelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(119)))));
            this.panelEmail.Location = new System.Drawing.Point(14, 299);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(351, 5);
            this.panelEmail.TabIndex = 1;
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(119)))));
            this.panelName.Location = new System.Drawing.Point(14, 136);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(351, 5);
            this.panelName.TabIndex = 1;
            // 
            // panelPhone
            // 
            this.panelPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(119)))));
            this.panelPhone.Location = new System.Drawing.Point(14, 243);
            this.panelPhone.Name = "panelPhone";
            this.panelPhone.Size = new System.Drawing.Size(351, 5);
            this.panelPhone.TabIndex = 1;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.BackColor = System.Drawing.Color.White;
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxAddress.Location = new System.Drawing.Point(14, 323);
            this.textBoxAddress.MaxLength = 300;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(351, 27);
            this.textBoxAddress.TabIndex = 0;
            this.textBoxAddress.Text = "Nhập địa chỉ";
            this.textBoxAddress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxAddress_MouseClick);
            this.textBoxAddress.Leave += new System.EventHandler(this.textBoxAddress_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxEmail.Location = new System.Drawing.Point(14, 267);
            this.textBoxEmail.MaxLength = 300;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(351, 27);
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.Text = "Nhập Email";
            this.textBoxEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxEmail_MouseClick);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.BackColor = System.Drawing.Color.White;
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPhone.Location = new System.Drawing.Point(14, 211);
            this.textBoxPhone.MaxLength = 11;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(351, 27);
            this.textBoxPhone.TabIndex = 0;
            this.textBoxPhone.Text = "Nhập số điện thoại";
            this.textBoxPhone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPhone_MouseClick);
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            this.textBoxPhone.Leave += new System.EventHandler(this.textBoxPhone_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxName.Location = new System.Drawing.Point(14, 104);
            this.textBoxName.MaxLength = 300;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(351, 27);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Nhập tên";
            this.textBoxName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxName_MouseClick);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.comboBoxPageSize);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelUpdateData);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerForm";
            this.Size = new System.Drawing.Size(1078, 633);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelFuntion.ResumeLayout(false);
            this.panelFuntion.PerformLayout();
            this.panelUpdateData.ResumeLayout(false);
            this.panelUpdateData.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPageSize;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelFuntion;
        private System.Windows.Forms.Label labelCountRecord;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private FontAwesome.Sharp.IconButton pagePrev;
        private FontAwesome.Sharp.IconButton pageNext;
        private System.Windows.Forms.Panel panelUpdateData;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RadioButton notAcitve;
        private System.Windows.Forms.RadioButton active;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelFormInput;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Panel panelPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Panel panelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
    }
}
