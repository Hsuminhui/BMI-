namespace BMI計算機
{
    partial class frmBMI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblResult0 = new System.Windows.Forms.Label();
            this.lblideal = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnRun);
            this.grpInput.Controls.Add(this.txtWeight);
            this.grpInput.Controls.Add(this.txtHeight);
            this.grpInput.Controls.Add(this.lblWeight);
            this.grpInput.Controls.Add(this.lblHeight);
            this.grpInput.Location = new System.Drawing.Point(35, 36);
            this.grpInput.Margin = new System.Windows.Forms.Padding(4);
            this.grpInput.Name = "grpInput";
            this.grpInput.Padding = new System.Windows.Forms.Padding(4);
            this.grpInput.Size = new System.Drawing.Size(517, 206);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "輸入";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.White;
            this.btnRun.ForeColor = System.Drawing.Color.Black;
            this.btnRun.Location = new System.Drawing.Point(389, 64);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 86);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "計算";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.Location = new System.Drawing.Point(193, 129);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(161, 34);
            this.txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeight.Location = new System.Drawing.Point(193, 50);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(161, 34);
            this.txtHeight.TabIndex = 2;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(39, 129);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(95, 25);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "體重 (kg)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(39, 53);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(100, 25);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "身高 (cm)";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblResult0);
            this.grpOutput.Controls.Add(this.lblideal);
            this.grpOutput.Controls.Add(this.lblResult);
            this.grpOutput.Controls.Add(this.lblBMI);
            this.grpOutput.Location = new System.Drawing.Point(35, 271);
            this.grpOutput.Margin = new System.Windows.Forms.Padding(4);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(4);
            this.grpOutput.Size = new System.Drawing.Size(517, 255);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "計算結果";
            // 
            // lblResult0
            // 
            this.lblResult0.BackColor = System.Drawing.Color.White;
            this.lblResult0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult0.Location = new System.Drawing.Point(267, 60);
            this.lblResult0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult0.Name = "lblResult0";
            this.lblResult0.Size = new System.Drawing.Size(227, 51);
            this.lblResult0.TabIndex = 5;
            this.lblResult0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblideal
            // 
            this.lblideal.AutoSize = true;
            this.lblideal.Location = new System.Drawing.Point(39, 72);
            this.lblideal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblideal.Name = "lblideal";
            this.lblideal.Size = new System.Drawing.Size(92, 25);
            this.lblideal.TabIndex = 4;
            this.lblideal.Text = "理想體重";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(267, 148);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(227, 51);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(39, 160);
            this.lblBMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(190, 25);
            this.lblBMI.TabIndex = 2;
            this.lblBMI.Text = "身體質量指數 (BMI)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picbox1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(605, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 490);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMI對照表";
            // 
            // picbox1
            // 
            this.picbox1.Location = new System.Drawing.Point(25, 33);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(370, 436);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox1.TabIndex = 0;
            this.picbox1.TabStop = false;
            // 
            // frmBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 792);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBMI";
            this.Text = "BMI計算機";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblResult0;
        private System.Windows.Forms.Label lblideal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picbox1;
    }
}

