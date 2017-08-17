namespace WinBairesCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGetDataFile = new System.Windows.Forms.Button();
            this.labelPathOriginalFile = new System.Windows.Forms.Label();
            this.buttonSaveParsedDataFile = new System.Windows.Forms.Button();
            this.labelPathParsedFile = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(758, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "BairesDev Coding Challenge";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGetDataFile
            // 
            this.buttonGetDataFile.Location = new System.Drawing.Point(21, 61);
            this.buttonGetDataFile.Name = "buttonGetDataFile";
            this.buttonGetDataFile.Size = new System.Drawing.Size(188, 27);
            this.buttonGetDataFile.TabIndex = 1;
            this.buttonGetDataFile.Text = "Obtener Archivo Datos";
            this.buttonGetDataFile.UseVisualStyleBackColor = true;
            this.buttonGetDataFile.Click += new System.EventHandler(this.ButtonGetDataFile_Click);
            // 
            // labelPathOriginalFile
            // 
            this.labelPathOriginalFile.Location = new System.Drawing.Point(233, 68);
            this.labelPathOriginalFile.Name = "labelPathOriginalFile";
            this.labelPathOriginalFile.Size = new System.Drawing.Size(388, 16);
            this.labelPathOriginalFile.TabIndex = 2;
            this.labelPathOriginalFile.Text = "...";
            // 
            // buttonSaveParsedDataFile
            // 
            this.buttonSaveParsedDataFile.Location = new System.Drawing.Point(21, 94);
            this.buttonSaveParsedDataFile.Name = "buttonSaveParsedDataFile";
            this.buttonSaveParsedDataFile.Size = new System.Drawing.Size(188, 27);
            this.buttonSaveParsedDataFile.TabIndex = 3;
            this.buttonSaveParsedDataFile.Text = "Guardar Archivo Datos Procesados";
            this.buttonSaveParsedDataFile.UseVisualStyleBackColor = true;
            this.buttonSaveParsedDataFile.Click += new System.EventHandler(this.ButtonSaveParsedDataFile_Click);
            // 
            // labelPathParsedFile
            // 
            this.labelPathParsedFile.Location = new System.Drawing.Point(233, 101);
            this.labelPathParsedFile.Name = "labelPathParsedFile";
            this.labelPathParsedFile.Size = new System.Drawing.Size(388, 16);
            this.labelPathParsedFile.TabIndex = 4;
            this.labelPathParsedFile.Text = "...";
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(27, 169);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(453, 79);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enunciado";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 271);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelPathParsedFile);
            this.Controls.Add(this.buttonSaveParsedDataFile);
            this.Controls.Add(this.labelPathOriginalFile);
            this.Controls.Add(this.buttonGetDataFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Baires Dev";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetDataFile;
        private System.Windows.Forms.Label labelPathOriginalFile;
        private System.Windows.Forms.Button buttonSaveParsedDataFile;
        private System.Windows.Forms.Label labelPathParsedFile;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

