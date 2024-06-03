namespace library
{
    partial class BookByPublisher
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masterDataSet = new library.masterDataSet();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new library.masterDataSetTableAdapters.BOOKTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.masterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUBLISHERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUBLISHERTableAdapter = new library.masterDataSetTableAdapters.PUBLISHERTableAdapter();
            this.bOOKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fKBOOKPUBLISHPUBLISHEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBOOKPUBLISHPUBLISHEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 296);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.masterDataSet;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // masterDataSetBindingSource
            // 
            this.masterDataSetBindingSource.DataSource = this.masterDataSet;
            this.masterDataSetBindingSource.Position = 0;
            // 
            // pUBLISHERBindingSource
            // 
            this.pUBLISHERBindingSource.DataMember = "PUBLISHER";
            this.pUBLISHERBindingSource.DataSource = this.masterDataSetBindingSource;
            // 
            // pUBLISHERTableAdapter
            // 
            this.pUBLISHERTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKBindingSource1
            // 
            this.bOOKBindingSource1.DataMember = "BOOK";
            this.bOOKBindingSource1.DataSource = this.masterDataSetBindingSource;
            // 
            // bOOKBindingSource2
            // 
            this.bOOKBindingSource2.DataMember = "BOOK";
            this.bOOKBindingSource2.DataSource = this.masterDataSet;
            // 
            // bOOKBindingSource3
            // 
            this.bOOKBindingSource3.DataMember = "BOOK";
            this.bOOKBindingSource3.DataSource = this.masterDataSetBindingSource;
            // 
            // fKBOOKPUBLISHPUBLISHEBindingSource
            // 
            this.fKBOOKPUBLISHPUBLISHEBindingSource.DataMember = "FK_BOOK_PUBLISH_PUBLISHE";
            this.fKBOOKPUBLISHPUBLISHEBindingSource.DataSource = this.pUBLISHERBindingSource;
            // 
            // BookByPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library.Properties.Resources.abstract_grey_white_simple_background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "BookByPublisher";
            this.Text = "BookByPublisher";
            this.Load += new System.EventHandler(this.BookByPublisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBOOKPUBLISHPUBLISHEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private masterDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource masterDataSetBindingSource;
        private System.Windows.Forms.BindingSource pUBLISHERBindingSource;
        private masterDataSetTableAdapters.PUBLISHERTableAdapter pUBLISHERTableAdapter;
        private System.Windows.Forms.BindingSource bOOKBindingSource2;
        private System.Windows.Forms.BindingSource bOOKBindingSource1;
        private System.Windows.Forms.BindingSource bOOKBindingSource3;
        private System.Windows.Forms.BindingSource fKBOOKPUBLISHPUBLISHEBindingSource;
    }
}