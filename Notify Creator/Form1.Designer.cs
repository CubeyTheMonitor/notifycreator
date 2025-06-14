namespace Notify_Creator
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            notifyIcon1 = new NotifyIcon(components);
            label5 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            richTextBox1 = new RichTextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            label10 = new Label();
            tabPage1 = new TabPage();
            label14 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipText = "asdasd";
            notifyIcon1.BalloonTipTitle = "asdasd";
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightCoral;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 72);
            label5.Name = "label5";
            label5.Size = new Size(171, 19);
            label5.TabIndex = 6;
            label5.Text = "notifyIcon Version";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 51);
            label2.Name = "label2";
            label2.Size = new Size(351, 19);
            label2.TabIndex = 1;
            label2.Text = "Create and play the notification here!";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(6, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(401, 49);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 3;
            label3.Text = "Title";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 24F);
            textBox2.Location = new Point(6, 110);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(401, 49);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 92);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 5;
            label4.Text = "Message";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(13, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 170);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Labels and time";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(174, 377);
            button1.Name = "button1";
            button1.Size = new Size(85, 45);
            button1.TabIndex = 4;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Infomation", "Error", "Warning", "None" });
            comboBox1.Location = new Point(210, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 23);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Application", "Infomation", "Error", "Warning", "(Custom)" });
            comboBox2.Location = new Point(12, 53);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(191, 23);
            comboBox2.TabIndex = 9;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 35);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 8;
            label6.Text = "Application Icon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(299, 35);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 10;
            label7.Text = "Notification Icon";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(122, 19);
            label8.Name = "label8";
            label8.Size = new Size(169, 15);
            label8.TabIndex = 11;
            label8.Text = "These are completely different!";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(13, 265);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(413, 82);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Apperances";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 8);
            label1.Name = "label1";
            label1.Size = new Size(419, 43);
            label1.TabIndex = 0;
            label1.Text = "Notification Creator";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(2, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(441, 465);
            tabControl1.TabIndex = 7;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(433, 437);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "README";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(6, 180);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(420, 219);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(13, 131);
            label13.Name = "label13";
            label13.Size = new Size(171, 19);
            label13.TabIndex = 7;
            label13.Text = "notifyIcon Edition";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(13, 109);
            label12.Name = "label12";
            label12.Size = new Size(153, 19);
            label12.TabIndex = 5;
            label12.Text = "Created by Cubey";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(13, 86);
            label11.Name = "label11";
            label11.Size = new Size(45, 19);
            label11.TabIndex = 4;
            label11.Text = "V1.2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(7, 13);
            label9.Name = "label9";
            label9.Size = new Size(419, 43);
            label9.TabIndex = 2;
            label9.Text = "Notification Creator";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(13, 56);
            label10.Name = "label10";
            label10.Size = new Size(54, 19);
            label10.TabIndex = 3;
            label10.Text = "About";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(433, 437);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Creator";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(31, 354);
            label14.Name = "label14";
            label14.Size = new Size(371, 14);
            label14.TabIndex = 7;
            label14.Text = "If doesn't work then press it again or set the icons";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 471);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Notify Creator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private Label label5;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private GroupBox groupBox1;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox2;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label12;
        private Label label11;
        private Label label9;
        private Label label10;
        private Label label13;
        private RichTextBox richTextBox1;
        private Label label14;
    }
}
