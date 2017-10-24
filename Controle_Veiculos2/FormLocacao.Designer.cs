namespace Controle_Veiculos2
{
    partial class FormLocacao
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLocacaoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label idCarroLabel;
            System.Windows.Forms.Label dataDevolucaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLocacao));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sistemaBuggyDataSet = new Controle_Veiculos2.SistemaBuggyDataSet();
            this.locacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locacaoTableAdapter = new Controle_Veiculos2.SistemaBuggyDataSetTableAdapters.LocacaoTableAdapter();
            this.tableAdapterManager = new Controle_Veiculos2.SistemaBuggyDataSetTableAdapters.TableAdapterManager();
            this.locacaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.locacaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLocacaoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.idCarroTextBox = new System.Windows.Forms.TextBox();
            this.dataDevolucaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            idLocacaoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            idCarroLabel = new System.Windows.Forms.Label();
            dataDevolucaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBuggyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingNavigator)).BeginInit();
            this.locacaoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLocacaoLabel
            // 
            idLocacaoLabel.AutoSize = true;
            idLocacaoLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLocacaoLabel.Location = new System.Drawing.Point(274, 80);
            idLocacaoLabel.Name = "idLocacaoLabel";
            idLocacaoLabel.Size = new System.Drawing.Size(60, 20);
            idLocacaoLabel.TabIndex = 5;
            idLocacaoLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(274, 106);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(53, 20);
            nomeLabel.TabIndex = 7;
            nomeLabel.Text = "Nome:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idClienteLabel.Location = new System.Drawing.Point(274, 132);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(73, 20);
            idClienteLabel.TabIndex = 9;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloLabel.Location = new System.Drawing.Point(274, 158);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(63, 20);
            modeloLabel.TabIndex = 11;
            modeloLabel.Text = "Modelo:";
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anoLabel.Location = new System.Drawing.Point(274, 184);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(39, 20);
            anoLabel.TabIndex = 13;
            anoLabel.Text = "Ano:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaLabel.Location = new System.Drawing.Point(274, 210);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(53, 20);
            marcaLabel.TabIndex = 15;
            marcaLabel.Text = "Marca:";
            // 
            // idCarroLabel
            // 
            idCarroLabel.AutoSize = true;
            idCarroLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idCarroLabel.Location = new System.Drawing.Point(274, 236);
            idCarroLabel.Name = "idCarroLabel";
            idCarroLabel.Size = new System.Drawing.Size(65, 20);
            idCarroLabel.TabIndex = 17;
            idCarroLabel.Text = "Id Carro:";
            // 
            // dataDevolucaoLabel
            // 
            dataDevolucaoLabel.AutoSize = true;
            dataDevolucaoLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataDevolucaoLabel.Location = new System.Drawing.Point(246, 266);
            dataDevolucaoLabel.Name = "dataDevolucaoLabel";
            dataDevolucaoLabel.Size = new System.Drawing.Size(116, 20);
            dataDevolucaoLabel.TabIndex = 19;
            dataDevolucaoLabel.Text = "Data Devolucao:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(582, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Locação";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // sistemaBuggyDataSet
            // 
            this.sistemaBuggyDataSet.DataSetName = "SistemaBuggyDataSet";
            this.sistemaBuggyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locacaoBindingSource
            // 
            this.locacaoBindingSource.DataMember = "Locacao";
            this.locacaoBindingSource.DataSource = this.sistemaBuggyDataSet;
            // 
            // locacaoTableAdapter
            // 
            this.locacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.EmpresariosTableAdapter = null;
            this.tableAdapterManager.LocacaoTableAdapter = this.locacaoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Controle_Veiculos2.SistemaBuggyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // locacaoBindingNavigator
            // 
            this.locacaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.locacaoBindingNavigator.BindingSource = this.locacaoBindingSource;
            this.locacaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.locacaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.locacaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.locacaoBindingNavigatorSaveItem});
            this.locacaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.locacaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.locacaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.locacaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.locacaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.locacaoBindingNavigator.Name = "locacaoBindingNavigator";
            this.locacaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.locacaoBindingNavigator.Size = new System.Drawing.Size(666, 25);
            this.locacaoBindingNavigator.TabIndex = 4;
            this.locacaoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // locacaoBindingNavigatorSaveItem
            // 
            this.locacaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.locacaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("locacaoBindingNavigatorSaveItem.Image")));
            this.locacaoBindingNavigatorSaveItem.Name = "locacaoBindingNavigatorSaveItem";
            this.locacaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.locacaoBindingNavigatorSaveItem.Text = "Save Data";
            this.locacaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.locacaoBindingNavigatorSaveItem_Click);
            // 
            // idLocacaoTextBox
            // 
            this.idLocacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "IdLocacao", true));
            this.idLocacaoTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLocacaoTextBox.Location = new System.Drawing.Point(368, 77);
            this.idLocacaoTextBox.Name = "idLocacaoTextBox";
            this.idLocacaoTextBox.Size = new System.Drawing.Size(200, 27);
            this.idLocacaoTextBox.TabIndex = 6;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(368, 103);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 27);
            this.nomeTextBox.TabIndex = 8;
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "IdCliente", true));
            this.idClienteTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClienteTextBox.Location = new System.Drawing.Point(368, 129);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(200, 27);
            this.idClienteTextBox.TabIndex = 10;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "Modelo", true));
            this.modeloTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloTextBox.Location = new System.Drawing.Point(368, 155);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(200, 27);
            this.modeloTextBox.TabIndex = 12;
            // 
            // anoTextBox
            // 
            this.anoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "Ano", true));
            this.anoTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoTextBox.Location = new System.Drawing.Point(368, 181);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(200, 27);
            this.anoTextBox.TabIndex = 14;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "Marca", true));
            this.marcaTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaTextBox.Location = new System.Drawing.Point(368, 207);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(200, 27);
            this.marcaTextBox.TabIndex = 16;
            // 
            // idCarroTextBox
            // 
            this.idCarroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "IdCarro", true));
            this.idCarroTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCarroTextBox.Location = new System.Drawing.Point(368, 233);
            this.idCarroTextBox.Name = "idCarroTextBox";
            this.idCarroTextBox.Size = new System.Drawing.Size(46, 27);
            this.idCarroTextBox.TabIndex = 18;
            // 
            // dataDevolucaoDateTimePicker
            // 
            this.dataDevolucaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoBindingSource, "DataDevolucao", true));
            this.dataDevolucaoDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDevolucaoDateTimePicker.Location = new System.Drawing.Point(368, 259);
            this.dataDevolucaoDateTimePicker.Name = "dataDevolucaoDateTimePicker";
            this.dataDevolucaoDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.dataDevolucaoDateTimePicker.TabIndex = 20;
            // 
            // FormLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(666, 336);
            this.Controls.Add(idLocacaoLabel);
            this.Controls.Add(this.idLocacaoTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(anoLabel);
            this.Controls.Add(this.anoTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(idCarroLabel);
            this.Controls.Add(this.idCarroTextBox);
            this.Controls.Add(dataDevolucaoLabel);
            this.Controls.Add(this.dataDevolucaoDateTimePicker);
            this.Controls.Add(this.locacaoBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locação";
            this.Load += new System.EventHandler(this.FormLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBuggyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingNavigator)).EndInit();
            this.locacaoBindingNavigator.ResumeLayout(false);
            this.locacaoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SistemaBuggyDataSet sistemaBuggyDataSet;
        private System.Windows.Forms.BindingSource locacaoBindingSource;
        private SistemaBuggyDataSetTableAdapters.LocacaoTableAdapter locacaoTableAdapter;
        private SistemaBuggyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator locacaoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton locacaoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idLocacaoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox idCarroTextBox;
        private System.Windows.Forms.DateTimePicker dataDevolucaoDateTimePicker;
    }
}