namespace Controle_Veiculos2
{
    partial class FormCarros
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
            System.Windows.Forms.Label idCarroLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label locacaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarros));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sistemaBuggyDataSet = new Controle_Veiculos2.SistemaBuggyDataSet();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroTableAdapter = new Controle_Veiculos2.SistemaBuggyDataSetTableAdapters.CarroTableAdapter();
            this.tableAdapterManager = new Controle_Veiculos2.SistemaBuggyDataSetTableAdapters.TableAdapterManager();
            this.carroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.carroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idCarroTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.locacaoCheckBox = new System.Windows.Forms.CheckBox();
            idCarroLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            locacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBuggyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingNavigator)).BeginInit();
            this.carroBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idCarroLabel
            // 
            idCarroLabel.AutoSize = true;
            idCarroLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idCarroLabel.Location = new System.Drawing.Point(263, 84);
            idCarroLabel.Name = "idCarroLabel";
            idCarroLabel.Size = new System.Drawing.Size(60, 21);
            idCarroLabel.TabIndex = 5;
            idCarroLabel.Text = "Código";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloLabel.Location = new System.Drawing.Point(263, 110);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(67, 21);
            modeloLabel.TabIndex = 7;
            modeloLabel.Text = "Modelo:";
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            anoLabel.Location = new System.Drawing.Point(284, 136);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(42, 21);
            anoLabel.TabIndex = 9;
            anoLabel.Text = "Ano:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaLabel.Location = new System.Drawing.Point(274, 162);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(56, 21);
            marcaLabel.TabIndex = 11;
            marcaLabel.Text = "Marca:";
            // 
            // locacaoLabel
            // 
            locacaoLabel.AutoSize = true;
            locacaoLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locacaoLabel.Location = new System.Drawing.Point(263, 191);
            locacaoLabel.Name = "locacaoLabel";
            locacaoLabel.Size = new System.Drawing.Size(69, 21);
            locacaoLabel.TabIndex = 13;
            locacaoLabel.Text = "Locação:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Veículos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(341, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(422, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sistemaBuggyDataSet
            // 
            this.sistemaBuggyDataSet.DataSetName = "SistemaBuggyDataSet";
            this.sistemaBuggyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataMember = "Carro";
            this.carroBindingSource.DataSource = this.sistemaBuggyDataSet;
            // 
            // carroTableAdapter
            // 
            this.carroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = this.carroTableAdapter;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.EmpresariosTableAdapter = null;
            this.tableAdapterManager.LocacaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Controle_Veiculos2.SistemaBuggyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carroBindingNavigator
            // 
            this.carroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carroBindingNavigator.BindingSource = this.carroBindingSource;
            this.carroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.carroBindingNavigatorSaveItem});
            this.carroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carroBindingNavigator.Name = "carroBindingNavigator";
            this.carroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carroBindingNavigator.Size = new System.Drawing.Size(561, 25);
            this.carroBindingNavigator.TabIndex = 4;
            this.carroBindingNavigator.Text = "bindingNavigator1";
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
            // carroBindingNavigatorSaveItem
            // 
            this.carroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carroBindingNavigatorSaveItem.Image")));
            this.carroBindingNavigatorSaveItem.Name = "carroBindingNavigatorSaveItem";
            this.carroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carroBindingNavigatorSaveItem.Text = "Save Data";
            this.carroBindingNavigatorSaveItem.Click += new System.EventHandler(this.carroBindingNavigatorSaveItem_Click);
            // 
            // idCarroTextBox
            // 
            this.idCarroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroBindingSource, "IdCarro", true));
            this.idCarroTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCarroTextBox.Location = new System.Drawing.Point(332, 76);
            this.idCarroTextBox.Name = "idCarroTextBox";
            this.idCarroTextBox.Size = new System.Drawing.Size(39, 29);
            this.idCarroTextBox.TabIndex = 6;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroBindingSource, "Modelo", true));
            this.modeloTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeloTextBox.Location = new System.Drawing.Point(332, 107);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(178, 29);
            this.modeloTextBox.TabIndex = 8;
            // 
            // anoTextBox
            // 
            this.anoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroBindingSource, "Ano", true));
            this.anoTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoTextBox.Location = new System.Drawing.Point(332, 133);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(178, 29);
            this.anoTextBox.TabIndex = 10;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroBindingSource, "Marca", true));
            this.marcaTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaTextBox.Location = new System.Drawing.Point(332, 159);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(178, 29);
            this.marcaTextBox.TabIndex = 12;
            // 
            // locacaoCheckBox
            // 
            this.locacaoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.carroBindingSource, "Locacao", true));
            this.locacaoCheckBox.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locacaoCheckBox.Location = new System.Drawing.Point(341, 190);
            this.locacaoCheckBox.Name = "locacaoCheckBox";
            this.locacaoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.locacaoCheckBox.TabIndex = 14;
            this.locacaoCheckBox.Text = "Sim/Não";
            this.locacaoCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(561, 316);
            this.Controls.Add(idCarroLabel);
            this.Controls.Add(this.idCarroTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(anoLabel);
            this.Controls.Add(this.anoTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(locacaoLabel);
            this.Controls.Add(this.locacaoCheckBox);
            this.Controls.Add(this.carroBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormCarros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Veículos";
            this.Load += new System.EventHandler(this.FormCarros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBuggyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingNavigator)).EndInit();
            this.carroBindingNavigator.ResumeLayout(false);
            this.carroBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private SistemaBuggyDataSet sistemaBuggyDataSet;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private SistemaBuggyDataSetTableAdapters.CarroTableAdapter carroTableAdapter;
        private SistemaBuggyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carroBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton carroBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idCarroTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.CheckBox locacaoCheckBox;
    }
}