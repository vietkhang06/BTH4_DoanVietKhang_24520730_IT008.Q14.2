namespace BTH4_BT6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.tbDest = new System.Windows.Forms.TextBox();
            this.btnChonNguon = new System.Windows.Forms.Button();
            this.btnChonDich = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnChonDich);
            this.groupBox1.Controls.Add(this.btnChonNguon);
            this.groupBox1.Controls.Add(this.tbDest);
            this.groupBox1.Controls.Add(this.tbSource);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(948, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao chép tập tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(13, 445);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(948, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiến trình sao chép";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(57, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đường Dẫn Thư Mục Đích";
            // 
            // tbSource
            // 
            this.tbSource.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSource.Location = new System.Drawing.Point(337, 55);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(511, 39);
            this.tbSource.TabIndex = 2;
            // 
            // tbDest
            // 
            this.tbDest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDest.Location = new System.Drawing.Point(337, 141);
            this.tbDest.Name = "tbDest";
            this.tbDest.Size = new System.Drawing.Size(511, 39);
            this.tbDest.TabIndex = 3;
            // 
            // btnChonNguon
            // 
            this.btnChonNguon.ForeColor = System.Drawing.Color.Blue;
            this.btnChonNguon.Location = new System.Drawing.Point(854, 55);
            this.btnChonNguon.Name = "btnChonNguon";
            this.btnChonNguon.Size = new System.Drawing.Size(55, 31);
            this.btnChonNguon.TabIndex = 4;
            this.btnChonNguon.Text = "...";
            this.btnChonNguon.UseVisualStyleBackColor = true;
            this.btnChonNguon.Click += new System.EventHandler(this.btnChonNguon_Click);
            // 
            // btnChonDich
            // 
            this.btnChonDich.ForeColor = System.Drawing.Color.Blue;
            this.btnChonDich.Location = new System.Drawing.Point(854, 141);
            this.btnChonDich.Name = "btnChonDich";
            this.btnChonDich.Size = new System.Drawing.Size(55, 31);
            this.btnChonDich.TabIndex = 5;
            this.btnChonDich.Text = "...";
            this.btnChonDich.UseVisualStyleBackColor = true;
            this.btnChonDich.Click += new System.EventHandler(this.btnChonDich_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(337, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 41);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sao Chép";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 55);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(896, 54);
            this.progressBar1.TabIndex = 0;
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWorker_RunWorkerCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 600);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(978, 30);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(140, 25);
            this.lblStatus.Text = "Đang sao chép: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 630);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnChonDich;
        private System.Windows.Forms.Button btnChonNguon;
        private System.Windows.Forms.TextBox tbDest;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblStatus;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

