namespace Retalo
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.retalDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retal_DBDataSet = new Retalo.Retal_DBDataSet();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retalDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retal_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            this.dataGridView1.DataSource = this.retalDBDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(105, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // retalDBDataSetBindingSource
            // 
            this.retalDBDataSetBindingSource.DataSource = this.retal_DBDataSet;
            this.retalDBDataSetBindingSource.Position = 0;
            // 
            // retal_DBDataSet
            // 
            this.retal_DBDataSet.DataSetName = "Retal_DBDataSet";
            this.retal_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retalDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retal_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource retalDBDataSetBindingSource;
        private Retal_DBDataSet retal_DBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}

