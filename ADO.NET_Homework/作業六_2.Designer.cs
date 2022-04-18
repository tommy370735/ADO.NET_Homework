
namespace ADO.NET_Homework
{
    partial class Homework_6_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homework_6_2));
            System.Windows.Forms.Label photoIDLabel;
            System.Windows.Forms.Label cityNameLabel;
            System.Windows.Forms.Label photoLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.travelDataSet = new ADO.NET_Homework.TravelDataSet();
            this.newPhotoTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newPhotoTableTableAdapter = new ADO.NET_Homework.TravelDataSetTableAdapters.NewPhotoTableTableAdapter();
            this.tableAdapterManager = new ADO.NET_Homework.TravelDataSetTableAdapters.TableAdapterManager();
            this.newPhotoTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.newPhotoTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.newPhotoTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.photoIDTextBox = new System.Windows.Forms.TextBox();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            photoIDLabel = new System.Windows.Forms.Label();
            cityNameLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPhotoTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPhotoTableBindingNavigator)).BeginInit();
            this.newPhotoTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPhotoTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "加入圖片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // travelDataSet
            // 
            this.travelDataSet.DataSetName = "TravelDataSet";
            this.travelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newPhotoTableBindingSource
            // 
            this.newPhotoTableBindingSource.DataMember = "NewPhotoTable";
            this.newPhotoTableBindingSource.DataSource = this.travelDataSet;
            // 
            // newPhotoTableTableAdapter
            // 
            this.newPhotoTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = null;
            this.tableAdapterManager.NewPhotoTableTableAdapter = this.newPhotoTableTableAdapter;
            this.tableAdapterManager.PhotoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ADO.NET_Homework.TravelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // newPhotoTableBindingNavigator
            // 
            this.newPhotoTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.newPhotoTableBindingNavigator.BindingSource = this.newPhotoTableBindingSource;
            this.newPhotoTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.newPhotoTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.newPhotoTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.newPhotoTableBindingNavigatorSaveItem});
            this.newPhotoTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.newPhotoTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.newPhotoTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.newPhotoTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.newPhotoTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.newPhotoTableBindingNavigator.Name = "newPhotoTableBindingNavigator";
            this.newPhotoTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.newPhotoTableBindingNavigator.Size = new System.Drawing.Size(730, 25);
            this.newPhotoTableBindingNavigator.TabIndex = 1;
            this.newPhotoTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 15);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // newPhotoTableBindingNavigatorSaveItem
            // 
            this.newPhotoTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newPhotoTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("newPhotoTableBindingNavigatorSaveItem.Image")));
            this.newPhotoTableBindingNavigatorSaveItem.Name = "newPhotoTableBindingNavigatorSaveItem";
            this.newPhotoTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.newPhotoTableBindingNavigatorSaveItem.Text = "儲存資料";
            this.newPhotoTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.newPhotoTableBindingNavigatorSaveItem_Click);
            // 
            // newPhotoTableDataGridView
            // 
            this.newPhotoTableDataGridView.AutoGenerateColumns = false;
            this.newPhotoTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newPhotoTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1});
            this.newPhotoTableDataGridView.DataSource = this.newPhotoTableBindingSource;
            this.newPhotoTableDataGridView.Location = new System.Drawing.Point(79, 89);
            this.newPhotoTableDataGridView.Name = "newPhotoTableDataGridView";
            this.newPhotoTableDataGridView.RowTemplate.Height = 24;
            this.newPhotoTableDataGridView.Size = new System.Drawing.Size(300, 220);
            this.newPhotoTableDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PhotoID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PhotoID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CityName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CityName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Photo";
            this.dataGridViewImageColumn1.HeaderText = "Photo";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // photoIDLabel
            // 
            photoIDLabel.AutoSize = true;
            photoIDLabel.Location = new System.Drawing.Point(437, 100);
            photoIDLabel.Name = "photoIDLabel";
            photoIDLabel.Size = new System.Drawing.Size(50, 12);
            photoIDLabel.TabIndex = 3;
            photoIDLabel.Text = "Photo ID:";
            // 
            // photoIDTextBox
            // 
            this.photoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newPhotoTableBindingSource, "PhotoID", true));
            this.photoIDTextBox.Location = new System.Drawing.Point(501, 97);
            this.photoIDTextBox.Name = "photoIDTextBox";
            this.photoIDTextBox.Size = new System.Drawing.Size(205, 22);
            this.photoIDTextBox.TabIndex = 4;
            // 
            // cityNameLabel
            // 
            cityNameLabel.AutoSize = true;
            cityNameLabel.Location = new System.Drawing.Point(437, 128);
            cityNameLabel.Name = "cityNameLabel";
            cityNameLabel.Size = new System.Drawing.Size(58, 12);
            cityNameLabel.TabIndex = 5;
            cityNameLabel.Text = "City Name:";
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newPhotoTableBindingSource, "CityName", true));
            this.cityNameTextBox.Location = new System.Drawing.Point(501, 125);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(205, 22);
            this.cityNameTextBox.TabIndex = 6;
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(437, 153);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(35, 12);
            photoLabel.TabIndex = 7;
            photoLabel.Text = "Photo:";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.newPhotoTableBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(501, 153);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(205, 156);
            this.photoPictureBox.TabIndex = 8;
            this.photoPictureBox.TabStop = false;
            // 
            // Homework_6_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 355);
            this.Controls.Add(photoIDLabel);
            this.Controls.Add(this.photoIDTextBox);
            this.Controls.Add(cityNameLabel);
            this.Controls.Add(this.cityNameTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.newPhotoTableDataGridView);
            this.Controls.Add(this.newPhotoTableBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "Homework_6_2";
            this.Text = "作業六_2";
            this.Load += new System.EventHandler(this.Homework_6_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPhotoTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPhotoTableBindingNavigator)).EndInit();
            this.newPhotoTableBindingNavigator.ResumeLayout(false);
            this.newPhotoTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPhotoTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private TravelDataSet travelDataSet;
        private System.Windows.Forms.BindingSource newPhotoTableBindingSource;
        private TravelDataSetTableAdapters.NewPhotoTableTableAdapter newPhotoTableTableAdapter;
        private TravelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator newPhotoTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton newPhotoTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView newPhotoTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox photoIDTextBox;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
    }
}