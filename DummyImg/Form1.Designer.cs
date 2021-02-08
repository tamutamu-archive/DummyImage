namespace DummyImg
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtImageList = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.fldOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFldOutput = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.rdoImage = new System.Windows.Forms.RadioButton();
            this.rdoPdf = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtImageList
            // 
            this.txtImageList.Location = new System.Drawing.Point(31, 226);
            this.txtImageList.Multiline = true;
            this.txtImageList.Name = "txtImageList";
            this.txtImageList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtImageList.Size = new System.Drawing.Size(752, 478);
            this.txtImageList.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(609, 742);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(175, 60);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "生　    成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "出力先";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(98, 32);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(644, 25);
            this.txtOutput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "生成したいファイル一覧";
            // 
            // btnFldOutput
            // 
            this.btnFldOutput.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnFldOutput.Location = new System.Drawing.Point(750, 32);
            this.btnFldOutput.Name = "btnFldOutput";
            this.btnFldOutput.Size = new System.Drawing.Size(37, 28);
            this.btnFldOutput.TabIndex = 5;
            this.btnFldOutput.Text = "...";
            this.btnFldOutput.UseVisualStyleBackColor = true;
            this.btnFldOutput.Click += new System.EventHandler(this.btnFldOutput_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(0, 841);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(832, 28);
            this.progressBar2.TabIndex = 7;
            // 
            // rdoImage
            // 
            this.rdoImage.AutoSize = true;
            this.rdoImage.Location = new System.Drawing.Point(31, 112);
            this.rdoImage.Name = "rdoImage";
            this.rdoImage.Size = new System.Drawing.Size(69, 22);
            this.rdoImage.TabIndex = 8;
            this.rdoImage.TabStop = true;
            this.rdoImage.Text = "画像";
            this.rdoImage.UseVisualStyleBackColor = true;
            // 
            // rdoPdf
            // 
            this.rdoPdf.AutoSize = true;
            this.rdoPdf.Location = new System.Drawing.Point(138, 112);
            this.rdoPdf.Name = "rdoPdf";
            this.rdoPdf.Size = new System.Drawing.Size(66, 22);
            this.rdoPdf.TabIndex = 8;
            this.rdoPdf.TabStop = true;
            this.rdoPdf.Text = "PDF";
            this.rdoPdf.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 870);
            this.Controls.Add(this.rdoPdf);
            this.Controls.Add(this.rdoImage);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.btnFldOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtImageList);
            this.Name = "Form1";
            this.Text = "Dummy Img";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImageList;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.FolderBrowserDialog fldOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFldOutput;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.RadioButton rdoImage;
        private System.Windows.Forms.RadioButton rdoPdf;
    }
}

