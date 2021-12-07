
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorks2019DataSet = new WindowsFormsApp1.AdventureWorks2019DataSet();
            this.employeeTableAdapter = new WindowsFormsApp1.AdventureWorks2019DataSetTableAdapters.EmployeeTableAdapter();
            this.businessEntityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalIDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizationNodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizationLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2019DataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.businessEntityIDDataGridViewTextBoxColumn,
            this.nationalIDNumberDataGridViewTextBoxColumn,
            this.organizationNodeDataGridViewTextBoxColumn,
            this.organizationLevelDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1396, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.adventureWorks2019DataSet;
            // 
            // adventureWorks2019DataSet
            // 
            this.adventureWorks2019DataSet.DataSetName = "AdventureWorks2019DataSet";
            this.adventureWorks2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // businessEntityIDDataGridViewTextBoxColumn
            // 
            this.businessEntityIDDataGridViewTextBoxColumn.DataPropertyName = "BusinessEntityID";
            this.businessEntityIDDataGridViewTextBoxColumn.HeaderText = "BusinessEntityID";
            this.businessEntityIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.businessEntityIDDataGridViewTextBoxColumn.Name = "businessEntityIDDataGridViewTextBoxColumn";
            this.businessEntityIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nationalIDNumberDataGridViewTextBoxColumn
            // 
            this.nationalIDNumberDataGridViewTextBoxColumn.DataPropertyName = "NationalIDNumber";
            this.nationalIDNumberDataGridViewTextBoxColumn.HeaderText = "NationalIDNumber";
            this.nationalIDNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nationalIDNumberDataGridViewTextBoxColumn.Name = "nationalIDNumberDataGridViewTextBoxColumn";
            this.nationalIDNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // organizationNodeDataGridViewTextBoxColumn
            // 
            this.organizationNodeDataGridViewTextBoxColumn.DataPropertyName = "OrganizationNode";
            this.organizationNodeDataGridViewTextBoxColumn.HeaderText = "OrganizationNode";
            this.organizationNodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.organizationNodeDataGridViewTextBoxColumn.Name = "organizationNodeDataGridViewTextBoxColumn";
            this.organizationNodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // organizationLevelDataGridViewTextBoxColumn
            // 
            this.organizationLevelDataGridViewTextBoxColumn.DataPropertyName = "OrganizationLevel";
            this.organizationLevelDataGridViewTextBoxColumn.HeaderText = "OrganizationLevel";
            this.organizationLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.organizationLevelDataGridViewTextBoxColumn.Name = "organizationLevelDataGridViewTextBoxColumn";
            this.organizationLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.organizationLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.HeaderText = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            this.jobTitleDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1396, 27);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillByToolStrip_ItemClicked_1);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 450);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2019DataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AdventureWorks2019DataSet adventureWorks2019DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private AdventureWorks2019DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessEntityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalIDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizationNodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizationLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}

