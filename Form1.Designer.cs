namespace apoj
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Play_button = new System.Windows.Forms.Button();
            this.CreateHost = new System.Windows.Forms.Button();
            this.JoinLobby = new System.Windows.Forms.Button();
            this.panelCreateHost = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pathbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLobbyName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.button8 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panelCreateHost.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // Play_button
            // 
            this.Play_button.Image = ((System.Drawing.Image)(resources.GetObject("Play_button.Image")));
            this.Play_button.Location = new System.Drawing.Point(12, 639);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(276, 85);
            this.Play_button.TabIndex = 0;
            this.Play_button.UseVisualStyleBackColor = true;
            this.Play_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateHost
            // 
            this.CreateHost.Location = new System.Drawing.Point(12, 583);
            this.CreateHost.Name = "CreateHost";
            this.CreateHost.Size = new System.Drawing.Size(97, 23);
            this.CreateHost.TabIndex = 2;
            this.CreateHost.Text = "Создать лобби";
            this.CreateHost.UseVisualStyleBackColor = true;
            this.CreateHost.Visible = false;
            this.CreateHost.Click += new System.EventHandler(this.CreateHost_Click);
            // 
            // JoinLobby
            // 
            this.JoinLobby.Location = new System.Drawing.Point(191, 583);
            this.JoinLobby.Name = "JoinLobby";
            this.JoinLobby.Size = new System.Drawing.Size(97, 23);
            this.JoinLobby.TabIndex = 3;
            this.JoinLobby.Text = "Войти в лобби";
            this.JoinLobby.UseVisualStyleBackColor = true;
            this.JoinLobby.Visible = false;
            this.JoinLobby.Click += new System.EventHandler(this.JoinLobby_Click);
            // 
            // panelCreateHost
            // 
            this.panelCreateHost.Controls.Add(this.label12);
            this.panelCreateHost.Controls.Add(this.button9);
            this.panelCreateHost.Controls.Add(this.button6);
            this.panelCreateHost.Controls.Add(this.textBox1);
            this.panelCreateHost.Controls.Add(this.pathbutton);
            this.panelCreateHost.Location = new System.Drawing.Point(539, 402);
            this.panelCreateHost.Name = "panelCreateHost";
            this.panelCreateHost.Size = new System.Drawing.Size(280, 86);
            this.panelCreateHost.TabIndex = 4;
            this.panelCreateHost.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Выберете папку с музыкой";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(199, 56);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "Назад";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 56);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Загрузить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 6;
            // 
            // pathbutton
            // 
            this.pathbutton.Location = new System.Drawing.Point(3, 30);
            this.pathbutton.Name = "pathbutton";
            this.pathbutton.Size = new System.Drawing.Size(75, 23);
            this.pathbutton.TabIndex = 5;
            this.pathbutton.Text = "Выбрать";
            this.pathbutton.UseVisualStyleBackColor = true;
            this.pathbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название лобби";
            // 
            // textBoxLobbyName
            // 
            this.textBoxLobbyName.Location = new System.Drawing.Point(12, 30);
            this.textBoxLobbyName.Name = "textBoxLobbyName";
            this.textBoxLobbyName.Size = new System.Drawing.Size(156, 20);
            this.textBoxLobbyName.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(594, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 172);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Список лобби";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(84, 139);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 7;
            this.button10.Text = "Назад";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Войти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Location = new System.Drawing.Point(594, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 172);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(84, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 139);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "Старт";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Участники";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(24, 33);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Location = new System.Drawing.Point(594, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 86);
            this.panel3.TabIndex = 9;
            this.panel3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ваш ник";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(38, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Выбрать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Controls.Add(this.WMP);
            this.panel5.Location = new System.Drawing.Point(436, 273);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(517, 372);
            this.panel5.TabIndex = 7;
            this.panel5.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 332);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Введите название песни";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(377, 329);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 2;
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(-1, 0);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(518, 317);
            this.WMP.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1346, 701);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.textBoxLobbyName);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Location = new System.Drawing.Point(594, 402);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(175, 86);
            this.panel7.TabIndex = 14;
            this.panel7.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.button12);
            this.panel4.Controls.Add(this.checkBox4);
            this.panel4.Controls.Add(this.checkBox3);
            this.panel4.Controls.Add(this.checkBox2);
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Location = new System.Drawing.Point(554, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 222);
            this.panel4.TabIndex = 15;
            this.panel4.Visible = false;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(168, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Осталось времени на проверку";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "трек";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(86, 181);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 4;
            this.button12.Text = "Сохранить";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(146, 145);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(91, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "ждем ответа";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(146, 122);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(91, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "ждем ответа";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 145);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "ждем ответа";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "ждем ответа";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.button13);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(594, 402);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(151, 168);
            this.panel6.TabIndex = 7;
            this.panel6.Visible = false;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Результат";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(39, 139);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 4;
            this.button13.Text = "Закрыть";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label11);
            this.panel8.Location = new System.Drawing.Point(594, 402);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 78);
            this.panel8.TabIndex = 16;
            this.panel8.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(15, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Пожалуйста, подождите";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(74, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Сейчас на опросе";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(83, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Ответы на";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.CreateHost);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCreateHost);
            this.Controls.Add(this.JoinLobby);
            this.Controls.Add(this.Play_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelCreateHost.ResumeLayout(false);
            this.panelCreateHost.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.Button CreateHost;
        private System.Windows.Forms.Button JoinLobby;
        private System.Windows.Forms.Panel panelCreateHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLobbyName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button pathbutton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox4;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}

