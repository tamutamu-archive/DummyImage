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
            this.SuspendLayout();
            // 
            // txtImageList
            // 
            this.txtImageList.Location = new System.Drawing.Point(19, 90);
            this.txtImageList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtImageList.Multiline = true;
            this.txtImageList.Name = "txtImageList";
            this.txtImageList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtImageList.Size = new System.Drawing.Size(453, 320);
            this.txtImageList.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(344, 437);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(128, 40);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "画　像　生　成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "出力先";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(59, 21);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(388, 19);
            this.txtOutput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "生成したい画像ファイル一覧";
            // 
            // btnFldOutput
            // 
            this.btnFldOutput.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnFldOutput.Location = new System.Drawing.Point(450, 21);
            this.btnFldOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFldOutput.Name = "btnFldOutput";
            this.btnFldOutput.Size = new System.Drawing.Size(22, 19);
            this.btnFldOutput.TabIndex = 5;
            this.btnFldOutput.Text = "...";
            this.btnFldOutput.UseVisualStyleBackColor = true;
            this.btnFldOutput.Click += new System.EventHandler(this.btnFldOutput_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(0, 519);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(499, 19);
            this.progressBar2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 537);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.btnFldOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtImageList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Dummy Img";
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
    }
}

