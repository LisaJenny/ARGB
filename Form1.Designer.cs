namespace 配置编辑器
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCPU = new System.Windows.Forms.ComboBox();
            this.numericUpDownCPUCOUNT = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCPUPRISE = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox主板 = new System.Windows.Forms.ComboBox();
            this.numericUpDown主板COUNT = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown主板PRISE = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSSD = new System.Windows.Forms.ComboBox();
            this.numericUpDownSSDCOUNT = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSSDPRISE = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox内存 = new System.Windows.Forms.ComboBox();
            this.numericUpDown内存COUNT = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown内存PRISE = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCPUCOUNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCPUPRISE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown主板COUNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown主板PRISE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSSDCOUNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSSDPRISE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown内存COUNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown内存PRISE)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU";
            // 
            // comboBoxCPU
            // 
            this.comboBoxCPU.FormattingEnabled = true;
            this.comboBoxCPU.Items.AddRange(new object[] {
            "I3-12100",
            "I3-12100F",
            "I5-12400",
            "I5-12400F",
            "I5-12600K",
            "I5-12600KF",
            "I7-12700",
            "I7-12700F",
            "I7-12700K",
            "I7-12700KF",
            "I9-12900",
            "I9-12900F",
            "I9-12900K",
            "I9-12900KF",
            "I9-12900KS",
            "I3-13100",
            "I3-13100F",
            "I5-13400",
            "I5-13400F",
            "I5-13600K",
            "I5-13600KF",
            "I7-13700",
            "I7-13700F",
            "I7-13700K",
            "I7-13700KF",
            "I9-13900",
            "I9-13900F",
            "I9-13900K",
            "I9-13900KF",
            "I9-13900KS"});
            this.comboBoxCPU.Location = new System.Drawing.Point(50, 6);
            this.comboBoxCPU.Name = "comboBoxCPU";
            this.comboBoxCPU.Size = new System.Drawing.Size(121, 25);
            this.comboBoxCPU.TabIndex = 1;
            this.comboBoxCPU.TextChanged += new System.EventHandler(this.comboBoxCPU_TextChanged);
            // 
            // numericUpDownCPUCOUNT
            // 
            this.numericUpDownCPUCOUNT.Location = new System.Drawing.Point(177, 7);
            this.numericUpDownCPUCOUNT.Name = "numericUpDownCPUCOUNT";
            this.numericUpDownCPUCOUNT.Size = new System.Drawing.Size(42, 23);
            this.numericUpDownCPUCOUNT.TabIndex = 2;
            // 
            // numericUpDownCPUPRISE
            // 
            this.numericUpDownCPUPRISE.Location = new System.Drawing.Point(225, 8);
            this.numericUpDownCPUPRISE.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownCPUPRISE.Name = "numericUpDownCPUPRISE";
            this.numericUpDownCPUPRISE.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownCPUPRISE.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "主板";
            // 
            // comboBox主板
            // 
            this.comboBox主板.FormattingEnabled = true;
            this.comboBox主板.Items.AddRange(new object[] {
            "华硕 H610M-K D4",
            "微星 B660M-G D4",
            "微星 B660M迫击炮 D4 Wifi",
            "微星 B660M迫击炮 MAX D4",
            "微星 B660M-P D4",
            "华硕 B660M-A D4",
            "华硕 B660M TUF Wifi D4",
            "华硕 B660M TUF Wifi D5",
            "华硕 B660M-A D4",
            "微星 Z690-A D4",
            "微星 Z690-P D4",
            "微星 Z690 刀锋 钛 D4",
            "微星 Z690 刀锋 钛 D5",
            "微星 Z690 暗黑 D5",
            "ROG_Z690-A 吹雪 D4",
            "ROG_Z690-A 吹雪 D5 ",
            "ROG Z690-E D5",
            "ROG MAXIUMS Z690 HERO",
            "ROG MAXIUMS Z690 EXTREME GLACIAL",
            "微星 B760M 迫击炮 D4",
            "微星 B760M 迫击炮 D5",
            "微星 B760M 迫击炮 Wifi D4",
            "微星 B760M 迫击炮 Wifi D5",
            "微星 B760M 迫击炮 MAX Wifi D4",
            "微星 B760M 迫击炮 MAX Wifi D5",
            "微星 B760M 爆破弹 D4",
            "微星 Z790-P D4",
            "微星 Z790-A D4",
            "微星 Z790-A_D5",
            "微星 Z790 刀锋 D4",
            "微星 Z790 刀锋 D5",
            "微星 Z790 暗黑 D5",
            "华硕 Z790-P D4",
            "华硕 Z790-P D5",
            "华硕 Z790-P Wifi D4",
            "华硕 Z790-P Wifi D5",
            "ROG Z790-A D4 吹雪",
            "ROG Z790-A D5 吹雪",
            "ROG Z790-E",
            "ROG MAXIUMS Z790 HERO",
            "ROG MAXIUMS Z790 EXTREME",
            "ROG MAXIUMS Z790 APEX",
            "ROG B650-A 吹雪",
            "ROG X670E-A 吹雪",
            "ROG X670E-E",
            "ROG CROSSHAIR X670E HERO",
            "ROG CROSSHAIR X670E EXTREME",
            "ROG CROSSHAIR X670E GENE"});
            this.comboBox主板.Location = new System.Drawing.Point(50, 34);
            this.comboBox主板.Name = "comboBox主板";
            this.comboBox主板.Size = new System.Drawing.Size(121, 25);
            this.comboBox主板.TabIndex = 5;
            this.comboBox主板.TextChanged += new System.EventHandler(this.comboBox主板_TextChanged);
            // 
            // numericUpDown主板COUNT
            // 
            this.numericUpDown主板COUNT.Location = new System.Drawing.Point(177, 37);
            this.numericUpDown主板COUNT.Name = "numericUpDown主板COUNT";
            this.numericUpDown主板COUNT.Size = new System.Drawing.Size(42, 23);
            this.numericUpDown主板COUNT.TabIndex = 6;
            // 
            // numericUpDown主板PRISE
            // 
            this.numericUpDown主板PRISE.Location = new System.Drawing.Point(225, 37);
            this.numericUpDown主板PRISE.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown主板PRISE.Name = "numericUpDown主板PRISE";
            this.numericUpDown主板PRISE.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown主板PRISE.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "SSD";
            // 
            // comboBoxSSD
            // 
            this.comboBoxSSD.FormattingEnabled = true;
            this.comboBoxSSD.Items.AddRange(new object[] {
            "西数 SN770 1T",
            "西数 SN770 2T",
            "西数 SN770 500G ",
            "西数 SN770 250G ",
            "西数 SN570 1T",
            "西数 SN570 2T",
            "西数 SN570 500G ",
            "西数 SN570 250G ",
            "三星 980PRO 1T",
            "三星 980PRO 2T",
            "三星 980PRO 512G"});
            this.comboBoxSSD.Location = new System.Drawing.Point(50, 65);
            this.comboBoxSSD.Name = "comboBoxSSD";
            this.comboBoxSSD.Size = new System.Drawing.Size(121, 25);
            this.comboBoxSSD.TabIndex = 9;
            this.comboBoxSSD.TextChanged += new System.EventHandler(this.comboBoxSSD_TextChanged);
            // 
            // numericUpDownSSDCOUNT
            // 
            this.numericUpDownSSDCOUNT.Location = new System.Drawing.Point(177, 68);
            this.numericUpDownSSDCOUNT.Name = "numericUpDownSSDCOUNT";
            this.numericUpDownSSDCOUNT.Size = new System.Drawing.Size(42, 23);
            this.numericUpDownSSDCOUNT.TabIndex = 10;
            // 
            // numericUpDownSSDPRISE
            // 
            this.numericUpDownSSDPRISE.Location = new System.Drawing.Point(225, 68);
            this.numericUpDownSSDPRISE.Name = "numericUpDownSSDPRISE";
            this.numericUpDownSSDPRISE.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownSSDPRISE.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "内存";
            // 
            // comboBox内存
            // 
            this.comboBox内存.FormattingEnabled = true;
            this.comboBox内存.Items.AddRange(new object[] {
            "威刚 XPG 3200MHz D4 金色 8G*2",
            "威刚 XPG 3200MHz D4 金色 16G*2",
            "威刚 XPG 3200MHz D4 金色_8G",
            "威刚 XPG 3200MHz D4 金色_16G",
            "威刚 XPG D50 3600MHz 8G*2",
            "威刚 XPG D50 3600MHz 16G*2",
            "金士顿 野兽 3200MHz 8G*2",
            "金士顿 野兽 3200MHz 16G*2 ",
            "金士顿 野兽 3600MHz 8G*2",
            "金士顿 野兽 3600MHz 16G*2",
            "金士顿 野兽 4800MHz 8G*2",
            "金士顿 野兽 4800MHz 16G*2",
            "金士顿 野兽 5200MHz 8G*2",
            "金士顿 野兽 5200MHz 16G*2",
            "金士顿 野兽 6000MHz 8G*2 ",
            "金士顿 野兽 6000MHz 16G*2",
            "芝奇 幻锋戟 6000MHz C30 D5 科技白 32G*2",
            "芝奇 幻锋戟 6400MHz C32 D5 科技白 32G*2",
            "芝奇 幻锋戟 6000MHz C34 D5 科技白 16G*2",
            "芝奇 幻锋戟 6400MHz C32 D5 科技白 16G*2",
            "芝奇 幻锋戟 6800MHz C32 D5 科技白 16G*2",
            "芝奇 幻锋戟 7200MHz C32 D5 科技白 16G*2"});
            this.comboBox内存.Location = new System.Drawing.Point(50, 96);
            this.comboBox内存.Name = "comboBox内存";
            this.comboBox内存.Size = new System.Drawing.Size(121, 25);
            this.comboBox内存.TabIndex = 13;
            this.comboBox内存.TextChanged += new System.EventHandler(this.comboBox内存_TextChanged);
            // 
            // numericUpDown内存COUNT
            // 
            this.numericUpDown内存COUNT.Location = new System.Drawing.Point(177, 99);
            this.numericUpDown内存COUNT.Name = "numericUpDown内存COUNT";
            this.numericUpDown内存COUNT.Size = new System.Drawing.Size(42, 23);
            this.numericUpDown内存COUNT.TabIndex = 14;
            // 
            // numericUpDown内存PRISE
            // 
            this.numericUpDown内存PRISE.Location = new System.Drawing.Point(225, 99);
            this.numericUpDown内存PRISE.Name = "numericUpDown内存PRISE";
            this.numericUpDown内存PRISE.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown内存PRISE.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown内存PRISE);
            this.Controls.Add(this.numericUpDown内存COUNT);
            this.Controls.Add(this.comboBox内存);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownSSDPRISE);
            this.Controls.Add(this.numericUpDownSSDCOUNT);
            this.Controls.Add(this.comboBoxSSD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown主板PRISE);
            this.Controls.Add(this.numericUpDown主板COUNT);
            this.Controls.Add(this.comboBox主板);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownCPUPRISE);
            this.Controls.Add(this.numericUpDownCPUCOUNT);
            this.Controls.Add(this.comboBoxCPU);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCPUCOUNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCPUPRISE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown主板COUNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown主板PRISE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSSDCOUNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSSDPRISE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown内存COUNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown内存PRISE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private ComboBox comboBoxCPU;
        private NumericUpDown numericUpDownCPUCOUNT;
        private NumericUpDown numericUpDownCPUPRISE;
        private Label label2;
        private ComboBox comboBox主板;
        private NumericUpDown numericUpDown主板COUNT;
        private NumericUpDown numericUpDown主板PRISE;
        private Label label3;
        private ComboBox comboBoxSSD;
        private NumericUpDown numericUpDownSSDCOUNT;
        private NumericUpDown numericUpDownSSDPRISE;
        private Label label4;
        private ComboBox comboBox内存;
        private NumericUpDown numericUpDown内存COUNT;
        private NumericUpDown numericUpDown内存PRISE;
    }
}