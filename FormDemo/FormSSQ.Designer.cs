namespace FormDemo
{
    partial class FormSSQ
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
            this.label1 = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.BallPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BlueBall = new System.Windows.Forms.Label();
            this.RedBall06 = new System.Windows.Forms.Label();
            this.RedBall05 = new System.Windows.Forms.Label();
            this.RedBall04 = new System.Windows.Forms.Label();
            this.RedBall03 = new System.Windows.Forms.Label();
            this.RedBall02 = new System.Windows.Forms.Label();
            this.RedBall01 = new System.Windows.Forms.Label();
            this.btParaStart = new System.Windows.Forms.Button();
            this.btParaStop = new System.Windows.Forms.Button();
            this.BallPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "多线程双色球实例";
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(182, 245);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 27);
            this.btStop.TabIndex = 6;
            this.btStop.Text = "停 止";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(101, 245);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 27);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "开 始";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // BallPanel
            // 
            this.BallPanel.Controls.Add(this.label2);
            this.BallPanel.Controls.Add(this.BlueBall);
            this.BallPanel.Controls.Add(this.RedBall06);
            this.BallPanel.Controls.Add(this.RedBall05);
            this.BallPanel.Controls.Add(this.RedBall04);
            this.BallPanel.Controls.Add(this.RedBall03);
            this.BallPanel.Controls.Add(this.RedBall02);
            this.BallPanel.Controls.Add(this.RedBall01);
            this.BallPanel.Location = new System.Drawing.Point(54, 74);
            this.BallPanel.Name = "BallPanel";
            this.BallPanel.Size = new System.Drawing.Size(487, 134);
            this.BallPanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "随机号码";
            // 
            // BlueBall
            // 
            this.BlueBall.AutoSize = true;
            this.BlueBall.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BlueBall.ForeColor = System.Drawing.Color.Blue;
            this.BlueBall.Location = new System.Drawing.Point(378, 71);
            this.BlueBall.Name = "BlueBall";
            this.BlueBall.Size = new System.Drawing.Size(45, 30);
            this.BlueBall.TabIndex = 0;
            this.BlueBall.Text = "00";
            // 
            // RedBall06
            // 
            this.RedBall06.AutoSize = true;
            this.RedBall06.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RedBall06.ForeColor = System.Drawing.Color.Red;
            this.RedBall06.Location = new System.Drawing.Point(276, 71);
            this.RedBall06.Name = "RedBall06";
            this.RedBall06.Size = new System.Drawing.Size(45, 30);
            this.RedBall06.TabIndex = 0;
            this.RedBall06.Text = "00";
            // 
            // RedBall05
            // 
            this.RedBall05.AutoSize = true;
            this.RedBall05.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RedBall05.ForeColor = System.Drawing.Color.Red;
            this.RedBall05.Location = new System.Drawing.Point(231, 71);
            this.RedBall05.Name = "RedBall05";
            this.RedBall05.Size = new System.Drawing.Size(45, 30);
            this.RedBall05.TabIndex = 0;
            this.RedBall05.Text = "00";
            // 
            // RedBall04
            // 
            this.RedBall04.AutoSize = true;
            this.RedBall04.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RedBall04.ForeColor = System.Drawing.Color.Red;
            this.RedBall04.Location = new System.Drawing.Point(186, 71);
            this.RedBall04.Name = "RedBall04";
            this.RedBall04.Size = new System.Drawing.Size(45, 30);
            this.RedBall04.TabIndex = 0;
            this.RedBall04.Text = "00";
            // 
            // RedBall03
            // 
            this.RedBall03.AutoSize = true;
            this.RedBall03.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RedBall03.ForeColor = System.Drawing.Color.Red;
            this.RedBall03.Location = new System.Drawing.Point(141, 71);
            this.RedBall03.Name = "RedBall03";
            this.RedBall03.Size = new System.Drawing.Size(45, 30);
            this.RedBall03.TabIndex = 0;
            this.RedBall03.Text = "00";
            // 
            // RedBall02
            // 
            this.RedBall02.AutoSize = true;
            this.RedBall02.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RedBall02.ForeColor = System.Drawing.Color.Red;
            this.RedBall02.Location = new System.Drawing.Point(96, 71);
            this.RedBall02.Name = "RedBall02";
            this.RedBall02.Size = new System.Drawing.Size(45, 30);
            this.RedBall02.TabIndex = 0;
            this.RedBall02.Text = "00";
            // 
            // RedBall01
            // 
            this.RedBall01.AutoSize = true;
            this.RedBall01.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RedBall01.ForeColor = System.Drawing.Color.Red;
            this.RedBall01.Location = new System.Drawing.Point(51, 71);
            this.RedBall01.Name = "RedBall01";
            this.RedBall01.Size = new System.Drawing.Size(45, 30);
            this.RedBall01.TabIndex = 0;
            this.RedBall01.Text = "00";
            // 
            // btParaStart
            // 
            this.btParaStart.Location = new System.Drawing.Point(338, 247);
            this.btParaStart.Name = "btParaStart";
            this.btParaStart.Size = new System.Drawing.Size(75, 23);
            this.btParaStart.TabIndex = 8;
            this.btParaStart.Text = "并行开始";
            this.btParaStart.UseVisualStyleBackColor = true;
            this.btParaStart.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btParaStop
            // 
            this.btParaStop.Location = new System.Drawing.Point(419, 247);
            this.btParaStop.Name = "btParaStop";
            this.btParaStop.Size = new System.Drawing.Size(75, 23);
            this.btParaStop.TabIndex = 9;
            this.btParaStop.Text = "停止并行";
            this.btParaStop.UseVisualStyleBackColor = true;
            this.btParaStop.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FormSSQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 332);
            this.Controls.Add(this.btParaStop);
            this.Controls.Add(this.btParaStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.BallPanel);
            this.Name = "FormSSQ";
            this.Text = "FormSSQ";
            this.BallPanel.ResumeLayout(false);
            this.BallPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Panel BallPanel;
        private System.Windows.Forms.Label RedBall01;
        private System.Windows.Forms.Label BlueBall;
        private System.Windows.Forms.Label RedBall06;
        private System.Windows.Forms.Label RedBall05;
        private System.Windows.Forms.Label RedBall04;
        private System.Windows.Forms.Label RedBall03;
        private System.Windows.Forms.Label RedBall02;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btParaStart;
        private System.Windows.Forms.Button btParaStop;
    }
}