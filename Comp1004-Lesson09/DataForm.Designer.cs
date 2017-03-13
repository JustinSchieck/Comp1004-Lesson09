namespace Comp1004_Lesson09
{
    partial class DataForm
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
            this.FirstNameListBox = new System.Windows.Forms.ListBox();
            this._Comp1004_namesDataSet = new Comp1004_Lesson09._Comp1004_namesDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Comp1004_Lesson09._Comp1004_namesDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._Comp1004_namesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameListBox
            // 
            this.FirstNameListBox.DataSource = this.usersBindingSource;
            this.FirstNameListBox.DisplayMember = "FirstName";
            this.FirstNameListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameListBox.FormattingEnabled = true;
            this.FirstNameListBox.ItemHeight = 25;
            this.FirstNameListBox.Location = new System.Drawing.Point(95, 79);
            this.FirstNameListBox.Name = "FirstNameListBox";
            this.FirstNameListBox.Size = new System.Drawing.Size(257, 254);
            this.FirstNameListBox.TabIndex = 0;
            // 
            // _Comp1004_namesDataSet
            // 
            this._Comp1004_namesDataSet.DataSetName = "_Comp1004_namesDataSet";
            this._Comp1004_namesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this._Comp1004_namesDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // DataForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(677, 604);
            this.Controls.Add(this.FirstNameListBox);
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Comp1004_namesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FirstNameListBox;
        private _Comp1004_namesDataSet _Comp1004_namesDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private _Comp1004_namesDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}

