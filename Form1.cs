using 配件;

namespace 配置编辑器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void comboBoxCPU_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxCPU.Text == "I3-12100")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU12100 = (int)CPU.I3_12100;
                numericUpDownCPUPRISE.Value = CPU12100 * CPUCount;
            }
            if (comboBoxCPU.Text == "I3-12100F")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU12100F = (int)CPU.I3_12100F;
                numericUpDownCPUPRISE.Value = CPU12100F * CPUCount;
            }
            if (comboBoxCPU.Text == "I5-12400F")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU12400F = (int)CPU.I5_12400F;
                numericUpDownCPUPRISE.Value = CPU12400F * CPUCount;
            }
            if (comboBoxCPU.Text == "I5-12400")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU12400 = (int)CPU.I5_12400;
                numericUpDownCPUPRISE.Value = CPU12400 * CPUCount;
            }
            if (comboBoxCPU.Text == "I5-12600K")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU12600K = (int)CPU.I5_12600K;
                numericUpDownCPUPRISE.Value = CPU12600K * CPUCount;
            }
            if (comboBoxCPU.Text == "I5-12600KF")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU12600KF = (int)CPU.I5_12600KF;
                numericUpDownCPUPRISE.Value = CPU12600KF * CPUCount;
            }
            if (comboBoxCPU.Text == "I7-12700")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU12700 = (int)CPU.I7_12700;
                numericUpDownCPUPRISE.Value = CPU12700 * CPUCount;
            }
            if (comboBoxCPU.Text == "I7-12700F")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU12700F = (int)CPU.I7_12700F;
                numericUpDownCPUPRISE.Value = CPU12700F * CPUCount;
            }
            if (comboBoxCPU.Text == "I7-12700K")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU12700K = (int)CPU.I7_12700K;
                numericUpDownCPUPRISE.Value = CPU12700K * CPUCount;
            }
            if (comboBoxCPU.Text == "I7-12700KF")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU12700KF = (int)CPU.I7_12700KF;
                numericUpDownCPUPRISE.Value = CPU12700KF * CPUCount;
            }
            if (comboBoxCPU.Text == "I9-12900")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU12900 = (int)CPU.I9_12900;
                numericUpDownCPUPRISE.Value = CPU12900 * CPUCount;
            }
            if (comboBoxCPU.Text == "I9-12900F")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU12900F = (int)CPU.I9_12900F;
                numericUpDownCPUPRISE.Value = CPU12900F * CPUCount;
            }
            if (comboBoxCPU.Text == "I9-12900K")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU12900K = (int)CPU.I9_12900K;
                numericUpDownCPUPRISE.Value = CPU12900K * CPUCount;
            }
            if (comboBoxCPU.Text == "I9-12900KF")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU12900KF = (int)CPU.I9_12900KF;
                numericUpDownCPUPRISE.Value = CPU12900KF * CPUCount;
            }
            if (comboBoxCPU.Text == "I9-12900KS")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU12900KS = (int)CPU.I9_12900KS;
                numericUpDownCPUPRISE.Value = CPU12900KS * CPUCount;
            }
            if (comboBoxCPU.Text == "I3-13100")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13100 = (int)CPU.I3_13100;
                numericUpDownCPUPRISE.Value = CPU13100 * CPUCount;
            }
            if (comboBoxCPU.Text == "I3-13100F")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13100F = (int)CPU.I3_13100F;
                numericUpDownCPUPRISE.Value = CPU13100F * CPUCount;
            }            
            if (comboBoxCPU.Text == "I5-134000")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13400 = (int)CPU.I5_13400;
                numericUpDownCPUPRISE.Value = CPU13400 * CPUCount;
            }            
            if (comboBoxCPU.Text == "I5-13400F")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13400F = (int)CPU.I5_13400F;
                numericUpDownCPUPRISE.Value = CPU13400F * CPUCount;
            }            
            if (comboBoxCPU.Text == "I5-13600K")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13600K = (int)CPU.I5_13600K;
                numericUpDownCPUPRISE.Value = CPU13600K * CPUCount;
            }            
            if (comboBoxCPU.Text == "I5-13600KF")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13600KF = (int)CPU.I5_13600KF;
                numericUpDownCPUPRISE.Value = CPU13600KF * CPUCount;
            }            
            if (comboBoxCPU.Text == "I7-13700")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13700 = (int)CPU.I7_13700;
                numericUpDownCPUPRISE.Value = CPU13700 * CPUCount;
            }            
            if (comboBoxCPU.Text == "I7-13700F")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13700F = (int)CPU.I7_13700F;
                numericUpDownCPUPRISE.Value = CPU13700F * CPUCount;
            }            
            if (comboBoxCPU.Text == "I7-13700K")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13700K = (int)CPU.I7_13700K;
                numericUpDownCPUPRISE.Value = CPU13700K * CPUCount;
            }            
            if (comboBoxCPU.Text == "I7-13700KF")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13700KF = (int)CPU.I7_13700KF;
                numericUpDownCPUPRISE.Value = CPU13700KF * CPUCount;
            }           
            if (comboBoxCPU.Text == "I3-13100F")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13100F = (int)CPU.I3_13100F;
                numericUpDownCPUPRISE.Value = CPU13100F * CPUCount;
            }            
            if (comboBoxCPU.Text == "I3-13100F")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13100F = (int)CPU.I3_13100F;
                numericUpDownCPUPRISE.Value = CPU13100F * CPUCount;
            }            
            if (comboBoxCPU.Text == "I3-13100F")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13100F = (int)CPU.I3_13100F;
                numericUpDownCPUPRISE.Value = CPU13100F * CPUCount;
            }            
            if (comboBoxCPU.Text == "I3-13100F")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13100F = (int)CPU.I3_13100F;
                numericUpDownCPUPRISE.Value = CPU13100F * CPUCount;
            }            
            if (comboBoxCPU.Text == "I3-13100F")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13100F = (int)CPU.I3_13100F;
                numericUpDownCPUPRISE.Value = CPU13100F * CPUCount;
            }            
            if (comboBoxCPU.Text == "I3-13100F")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13100F = (int)CPU.I3_13100F;
                numericUpDownCPUPRISE.Value = CPU13100F * CPUCount;
            }            
            if (comboBoxCPU.Text == "I3-13100F")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13100F = (int)CPU.I3_13100F;
                numericUpDownCPUPRISE.Value = CPU13100F * CPUCount;
            }            
            if (comboBoxCPU.Text == "I3-13100F")
            {
                int CPUCount = (int)numericUpDownCPUCOUNT.Value;
                int CPU13100F = (int)CPU.I3_13100F;
                numericUpDownCPUPRISE.Value = CPU13100F * CPUCount;
            }

        }

        private void comboBox主板_TextChanged(object sender, EventArgs e)
        {
            if (comboBox主板.Text == "华硕 H610M-K D4")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int H610M_K = (int)主板.华硕_H610M_K_D4;
                numericUpDown主板PRISE.Value = H610M_K * 主板Count;
            }
            if (comboBox主板.Text == "微星 B660M-G D4")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int B660M_G = (int)主板.微星_B660M_G_D4;
                numericUpDown主板PRISE.Value = B660M_G * 主板Count;
            }
            if (comboBox主板.Text == "微星 B660M迫击炮 D4 Wifi")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int B660M迫击炮D4 = (int)主板.微星_B660M_迫击炮_D4_Wifi;
                numericUpDown主板PRISE.Value = B660M迫击炮D4 * 主板Count;
            }
            if (comboBox主板.Text == "微星 B660M迫击炮 MAX D4")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int B660M迫击炮MAXD4 = (int)主板.微星_B660M_迫击炮_MAX_D4;
                numericUpDown主板PRISE.Value = B660M迫击炮MAXD4 * 主板Count;
            }
            if (comboBox主板.Text == "微星 B660M-P D4")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int B660M_P = (int)主板.微星_B660M_P_D4;
                numericUpDown主板PRISE.Value = B660M_P * 主板Count;
            }
            if (comboBox主板.Text == "华硕 B660M-A D4")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int B660M_A = (int)主板.华硕_B660M_A_D4;
                numericUpDown主板PRISE.Value = B660M_A * 主板Count;
            }
            if (comboBox主板.Text == "华硕 B660M TUF Wifi D4")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int B660M_TUF_D4 = (int)主板.华硕_B660M_TUF_Wifi_D4;
                numericUpDown主板PRISE.Value = B660M_TUF_D4 * 主板Count;
            }
            if (comboBox主板.Text == "华硕 B660M TUF Wifi D5")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int B660M_TUF_D5 = (int)主板.华硕_B660M_TUF_Wifi_D5;
                numericUpDown主板PRISE.Value = B660M_TUF_D5 * 主板Count;
            }
            if (comboBox主板.Text == "华硕 B660 M-A D4")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int B660M_A_D4 = (int)主板.华硕_B660M_A_D4;
                numericUpDown主板PRISE.Value = B660M_A_D4 * 主板Count;
            }
            if (comboBox主板.Text == "微星 Z690-A D4")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int Z690_A_D4 = (int)主板.微星_Z690_A_D4;
                numericUpDown主板PRISE.Value = Z690_A_D4 * 主板Count;
            }
            if (comboBox主板.Text == "微星 Z690-P D4")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int Z690_P_D4 = (int)主板.微星_Z690_P_D4;
                numericUpDown主板PRISE.Value = Z690_P_D4 * 主板Count;
            }
            if (comboBox主板.Text == "微星 Z690 刀锋 钛 D4")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int Z690_刀锋_钛_D4 = (int)主板.微星_Z690_刀锋_钛_D4;
                numericUpDown主板PRISE.Value = Z690_刀锋_钛_D4 * 主板Count;
            }
            if (comboBox主板.Text == "微星 Z690 刀锋 钛 D5")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int Z690_刀锋_钛_D5 = (int)主板.微星_Z690_刀锋_钛_D5;
                numericUpDown主板PRISE.Value = Z690_刀锋_钛_D5 * 主板Count;
            }
            if (comboBox主板.Text == "微星 Z690 暗黑 D5")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int Z690_暗黑_D5 = (int)主板.微星_Z690_暗黑_D5;
                numericUpDown主板PRISE.Value = Z690_暗黑_D5 * 主板Count;
            }
            if (comboBox主板.Text == "ROG_Z690-A 吹雪 D4")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int Z690_A_吹雪_D4 = (int)主板.ROG_Z690_A_吹雪_D4;
                numericUpDown主板PRISE.Value = Z690_A_吹雪_D4 * 主板Count;
            }
            if (comboBox主板.Text == "ROG_Z690-A 吹雪 D5")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int Z690_A_吹雪_D5 = (int)主板.ROG_Z690_A_吹雪_D5;
                numericUpDown主板PRISE.Value = Z690_A_吹雪_D5 * 主板Count;
            }
            if (comboBox主板.Text == "ROG Z690-E D5")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int Z690_E_D5 = (int)主板.ROG_Z690_E_D5;
                numericUpDown主板PRISE.Value = Z690_E_D5 * 主板Count;
            }
            if (comboBox主板.Text == "ROG MAXIUMS Z690 HERO")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int MZ690H = (int)主板.ROG_MAXIUMS_Z690_HERO;
                numericUpDown主板PRISE.Value = MZ690H * 主板Count;
            }
            if (comboBox主板.Text == "ROG MAXIUMS Z690 EXTREME GLACIAL")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int MZ690EG = (int)主板.ROG_MAXIUMS_Z690_EXTREME_GLACIAL;
                numericUpDown主板PRISE.Value = MZ690EG * 主板Count;
            }
            if (comboBox主板.Text == "微星 B760M 迫击炮 D4")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int B760M_迫击炮_D4 = (int)主板.微星_B760M_迫击炮_D4;
                numericUpDown主板PRISE.Value = B760M_迫击炮_D4 * 主板Count;
            }
            if (comboBox主板.Text == "微星 B760M 迫击炮 D5")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int B760M_迫击炮_D5 = (int)主板.微星_B760M_迫击炮_D5;
                numericUpDown主板PRISE.Value = B760M_迫击炮_D5 * 主板Count;
            }
            if (comboBox主板.Text == "微星 B760M 迫击炮 Wifi D4")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int 微星_B760M_迫击炮_Wifi_D4 = (int)主板.微星_B760M_迫击炮_Wifi_D4;
                numericUpDown主板PRISE.Value = 微星_B760M_迫击炮_Wifi_D4 * 主板Count;
            }
            if (comboBox主板.Text == "微星 B760M 迫击炮 Wifi D5")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int B760M_迫击炮_Wifi_D5 = (int)主板.微星_B760M_迫击炮_Wifi_D5;
                numericUpDown主板PRISE.Value = B760M_迫击炮_Wifi_D5 * 主板Count;
            }
            if (comboBox主板.Text == "微星 B760M 迫击炮 MAX Wifi D4")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int B760M_迫击炮_MAX_Wifi_D4 = (int)主板.微星_B760M_迫击炮_MAX_Wifi_D4;
                numericUpDown主板PRISE.Value = B760M_迫击炮_MAX_Wifi_D4 * 主板Count;
            }
            if (comboBox主板.Text == "微星 B760M 迫击炮 MAX Wifi D5")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int B760M_迫击炮_MAX_Wifi_D5 = (int)主板.微星_B760M_迫击炮_MAX_Wifi_D5;
                numericUpDown主板PRISE.Value = B760M_迫击炮_MAX_Wifi_D5 * 主板Count;
            }
            if (comboBox主板.Text == "微星 B760M 爆破弹 D4")
            {
                int 主板Count = (int)numericUpDown主板COUNT.Value;
                int B760M_爆破弹_D4 = (int)主板.微星_B760M_爆破弹_D4;
                numericUpDown主板PRISE.Value = B760M_爆破弹_D4 * 主板Count;
            }
        }

        private void comboBoxSSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox内存_TextChanged(object sender, EventArgs e)
        {

        }
    }
}