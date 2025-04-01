namespace WalletBitcoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnBalance = new Button();
            btnClear = new Button();
            btnGenerate = new Button();
            label4 = new Label();
            label3 = new Label();
            tbKey = new TextBox();
            rcbSeed = new RichTextBox();
            label2 = new Label();
            cbRede = new ComboBox();
            label1 = new Label();
            tbAddress = new TextBox();
            tabPage2 = new TabPage();
            btnRecoverBalance = new Button();
            label18 = new Label();
            label17 = new Label();
            tbRecoverKey = new TextBox();
            btRecoverClear = new Button();
            btRecover = new Button();
            tbRecoverAddress = new TextBox();
            groupBox1 = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tb02 = new TextBox();
            tb12 = new TextBox();
            tb01 = new TextBox();
            tb11 = new TextBox();
            tb03 = new TextBox();
            tb10 = new TextBox();
            tb04 = new TextBox();
            tb09 = new TextBox();
            tb05 = new TextBox();
            tb08 = new TextBox();
            tb06 = new TextBox();
            tb07 = new TextBox();
            tabPage3 = new TabPage();
            richTextBox1 = new RichTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(482, 374);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnBalance);
            tabPage1.Controls.Add(btnClear);
            tabPage1.Controls.Add(btnGenerate);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(tbKey);
            tabPage1.Controls.Add(rcbSeed);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(cbRede);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(tbAddress);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(474, 346);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Generate new wallet";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBalance
            // 
            btnBalance.Location = new Point(388, 70);
            btnBalance.Name = "btnBalance";
            btnBalance.Size = new Size(75, 23);
            btnBalance.TabIndex = 10;
            btnBalance.Text = "Balance";
            btnBalance.UseVisualStyleBackColor = true;
            btnBalance.Click += btnBalance_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(89, 315);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(8, 315);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(8, 140);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 7;
            label4.Text = "Seed phrase:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(8, 96);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 6;
            label3.Text = "Private Key:";
            // 
            // tbKey
            // 
            tbKey.Location = new Point(8, 114);
            tbKey.Name = "tbKey";
            tbKey.Size = new Size(455, 23);
            tbKey.TabIndex = 5;
            // 
            // rcbSeed
            // 
            rcbSeed.Location = new Point(8, 158);
            rcbSeed.Name = "rcbSeed";
            rcbSeed.Size = new Size(455, 151);
            rcbSeed.TabIndex = 4;
            rcbSeed.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(342, 23);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Network";
            // 
            // cbRede
            // 
            cbRede.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRede.FormattingEnabled = true;
            cbRede.Items.AddRange(new object[] { "TestNet", "Mainnet" });
            cbRede.Location = new Point(342, 41);
            cbRede.Name = "cbRede";
            cbRede.Size = new Size(121, 23);
            cbRede.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(8, 52);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Address:";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(8, 70);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(374, 23);
            tbAddress.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnRecoverBalance);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(tbRecoverKey);
            tabPage2.Controls.Add(btRecoverClear);
            tabPage2.Controls.Add(btRecover);
            tabPage2.Controls.Add(tbRecoverAddress);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(474, 346);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Recover wallet";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRecoverBalance
            // 
            btnRecoverBalance.Location = new Point(391, 250);
            btnRecoverBalance.Name = "btnRecoverBalance";
            btnRecoverBalance.Size = new Size(75, 23);
            btnRecoverBalance.TabIndex = 19;
            btnRecoverBalance.Text = "Balance";
            btnRecoverBalance.UseVisualStyleBackColor = true;
            btnRecoverBalance.Click += btnRecoverBalance_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label18.ForeColor = Color.Green;
            label18.Location = new Point(8, 282);
            label18.Name = "label18";
            label18.Size = new Size(74, 15);
            label18.TabIndex = 18;
            label18.Text = "Private Key:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.ForeColor = Color.Green;
            label17.Location = new Point(8, 258);
            label17.Name = "label17";
            label17.Size = new Size(54, 15);
            label17.TabIndex = 17;
            label17.Text = "Address:";
            // 
            // tbRecoverKey
            // 
            tbRecoverKey.Location = new Point(82, 279);
            tbRecoverKey.Name = "tbRecoverKey";
            tbRecoverKey.Size = new Size(384, 23);
            tbRecoverKey.TabIndex = 16;
            // 
            // btRecoverClear
            // 
            btRecoverClear.Location = new Point(89, 317);
            btRecoverClear.Name = "btRecoverClear";
            btRecoverClear.Size = new Size(75, 23);
            btRecoverClear.TabIndex = 15;
            btRecoverClear.Text = "Clear";
            btRecoverClear.UseVisualStyleBackColor = true;
            btRecoverClear.Click += btRecoverClear_Click;
            // 
            // btRecover
            // 
            btRecover.Location = new Point(8, 317);
            btRecover.Name = "btRecover";
            btRecover.Size = new Size(75, 23);
            btRecover.TabIndex = 14;
            btRecover.Text = "Recover";
            btRecover.UseVisualStyleBackColor = true;
            btRecover.Click += btRecover_Click;
            // 
            // tbRecoverAddress
            // 
            tbRecoverAddress.Location = new Point(82, 250);
            tbRecoverAddress.Name = "tbRecoverAddress";
            tbRecoverAddress.Size = new Size(303, 23);
            tbRecoverAddress.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tb02);
            groupBox1.Controls.Add(tb12);
            groupBox1.Controls.Add(tb01);
            groupBox1.Controls.Add(tb11);
            groupBox1.Controls.Add(tb03);
            groupBox1.Controls.Add(tb10);
            groupBox1.Controls.Add(tb04);
            groupBox1.Controls.Add(tb09);
            groupBox1.Controls.Add(tb05);
            groupBox1.Controls.Add(tb08);
            groupBox1.Controls.Add(tb06);
            groupBox1.Controls.Add(tb07);
            groupBox1.Location = new Point(8, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(458, 221);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter the words in the correct order";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.HotTrack;
            label16.Location = new Point(257, 182);
            label16.Name = "label16";
            label16.Size = new Size(22, 15);
            label16.TabIndex = 23;
            label16.Text = "12.";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.HotTrack;
            label15.Location = new Point(257, 153);
            label15.Name = "label15";
            label15.Size = new Size(22, 15);
            label15.TabIndex = 22;
            label15.Text = "11.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.HotTrack;
            label14.Location = new Point(257, 124);
            label14.Name = "label14";
            label14.Size = new Size(22, 15);
            label14.TabIndex = 21;
            label14.Text = "10.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.HotTrack;
            label13.Location = new Point(257, 95);
            label13.Name = "label13";
            label13.Size = new Size(22, 15);
            label13.TabIndex = 20;
            label13.Text = "09.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(257, 66);
            label12.Name = "label12";
            label12.Size = new Size(22, 15);
            label12.TabIndex = 19;
            label12.Text = "08.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.HotTrack;
            label11.Location = new Point(257, 37);
            label11.Name = "label11";
            label11.Size = new Size(22, 15);
            label11.TabIndex = 18;
            label11.Text = "07.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(6, 182);
            label10.Name = "label10";
            label10.Size = new Size(22, 15);
            label10.TabIndex = 17;
            label10.Text = "06.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(6, 153);
            label9.Name = "label9";
            label9.Size = new Size(22, 15);
            label9.TabIndex = 16;
            label9.Text = "05.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(6, 124);
            label8.Name = "label8";
            label8.Size = new Size(22, 15);
            label8.TabIndex = 15;
            label8.Text = "04.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(6, 95);
            label7.Name = "label7";
            label7.Size = new Size(22, 15);
            label7.TabIndex = 14;
            label7.Text = "03.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(6, 66);
            label6.Name = "label6";
            label6.Size = new Size(22, 15);
            label6.TabIndex = 13;
            label6.Text = "02.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(6, 42);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 12;
            label5.Text = "01.";
            // 
            // tb02
            // 
            tb02.Location = new Point(34, 63);
            tb02.Name = "tb02";
            tb02.Size = new Size(167, 23);
            tb02.TabIndex = 1;
            // 
            // tb12
            // 
            tb12.Location = new Point(285, 179);
            tb12.Name = "tb12";
            tb12.Size = new Size(167, 23);
            tb12.TabIndex = 11;
            // 
            // tb01
            // 
            tb01.Location = new Point(34, 34);
            tb01.Name = "tb01";
            tb01.Size = new Size(167, 23);
            tb01.TabIndex = 0;
            // 
            // tb11
            // 
            tb11.Location = new Point(285, 150);
            tb11.Name = "tb11";
            tb11.Size = new Size(167, 23);
            tb11.TabIndex = 10;
            // 
            // tb03
            // 
            tb03.Location = new Point(34, 92);
            tb03.Name = "tb03";
            tb03.Size = new Size(167, 23);
            tb03.TabIndex = 2;
            // 
            // tb10
            // 
            tb10.Location = new Point(285, 121);
            tb10.Name = "tb10";
            tb10.Size = new Size(167, 23);
            tb10.TabIndex = 9;
            // 
            // tb04
            // 
            tb04.Location = new Point(34, 121);
            tb04.Name = "tb04";
            tb04.Size = new Size(167, 23);
            tb04.TabIndex = 3;
            // 
            // tb09
            // 
            tb09.Location = new Point(285, 92);
            tb09.Name = "tb09";
            tb09.Size = new Size(167, 23);
            tb09.TabIndex = 8;
            // 
            // tb05
            // 
            tb05.Location = new Point(34, 150);
            tb05.Name = "tb05";
            tb05.Size = new Size(167, 23);
            tb05.TabIndex = 4;
            // 
            // tb08
            // 
            tb08.Location = new Point(285, 63);
            tb08.Name = "tb08";
            tb08.Size = new Size(167, 23);
            tb08.TabIndex = 7;
            // 
            // tb06
            // 
            tb06.Location = new Point(34, 179);
            tb06.Name = "tb06";
            tb06.Size = new Size(167, 23);
            tb06.TabIndex = 5;
            // 
            // tb07
            // 
            tb07.Location = new Point(285, 34);
            tb07.Name = "tb07";
            tb07.Size = new Size(167, 23);
            tb07.TabIndex = 6;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(richTextBox1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(474, 346);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "About";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ControlLightLight;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Enabled = false;
            richTextBox1.Font = new Font("SimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(6, 48);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(460, 225);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 374);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BitcoinWallet management";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox tbAddress;
        private Label label2;
        private ComboBox cbRede;
        private Label label3;
        private TextBox tbKey;
        private RichTextBox rcbSeed;
        private Label label4;
        private Button btnClear;
        private Button btnGenerate;
        private TabPage tabPage3;
        private RichTextBox richTextBox1;
        private TextBox tb12;
        private TextBox tb11;
        private TextBox tb10;
        private TextBox tb09;
        private TextBox tb08;
        private TextBox tb07;
        private TextBox tb06;
        private TextBox tb05;
        private TextBox tb04;
        private TextBox tb03;
        private TextBox tb02;
        private TextBox tb01;
        private GroupBox groupBox1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tbRecoverAddress;
        private Button btRecoverClear;
        private Button btRecover;
        private TextBox tbRecoverKey;
        private Label label18;
        private Label label17;
        private Button btnBalance;
        private Button btnRecoverBalance;
    }
}
