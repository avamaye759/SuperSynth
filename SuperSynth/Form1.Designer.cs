namespace SuperSynth
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
            this.pianoBase = new System.Windows.Forms.Label();
            this.powerButton = new System.Windows.Forms.Button();
            this.drumButton = new System.Windows.Forms.Button();
            this.powerInd = new System.Windows.Forms.Label();
            this.drumInd = new System.Windows.Forms.Label();
            this.drumLoop = new System.Windows.Forms.Timer(this.components);
            this.c1Key = new System.Windows.Forms.Button();
            this.f1Key = new System.Windows.Forms.Button();
            this.d1Key = new System.Windows.Forms.Button();
            this.e1Key = new System.Windows.Forms.Button();
            this.a2Key = new System.Windows.Forms.Button();
            this.g1Key = new System.Windows.Forms.Button();
            this.d2Key = new System.Windows.Forms.Button();
            this.e2Key = new System.Windows.Forms.Button();
            this.b2Key = new System.Windows.Forms.Button();
            this.c2Key = new System.Windows.Forms.Button();
            this.g2Key = new System.Windows.Forms.Button();
            this.f2Key = new System.Windows.Forms.Button();
            this.a3Key = new System.Windows.Forms.Button();
            this.b3Key = new System.Windows.Forms.Button();
            this.cS1Key = new System.Windows.Forms.Button();
            this.dS1Key = new System.Windows.Forms.Button();
            this.fS1Key = new System.Windows.Forms.Button();
            this.gS1Key = new System.Windows.Forms.Button();
            this.aS2Key = new System.Windows.Forms.Button();
            this.cS2Key = new System.Windows.Forms.Button();
            this.dS2Key = new System.Windows.Forms.Button();
            this.fS2Key = new System.Windows.Forms.Button();
            this.gS2Key = new System.Windows.Forms.Button();
            this.aS3Key = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pianoBase
            // 
            this.pianoBase.BackColor = System.Drawing.Color.Coral;
            this.pianoBase.Location = new System.Drawing.Point(61, 32);
            this.pianoBase.Name = "pianoBase";
            this.pianoBase.Size = new System.Drawing.Size(679, 288);
            this.pianoBase.TabIndex = 0;
            // 
            // powerButton
            // 
            this.powerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.powerButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.powerButton.FlatAppearance.BorderSize = 0;
            this.powerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerButton.Font = new System.Drawing.Font("Haettenschweiler", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerButton.ForeColor = System.Drawing.Color.White;
            this.powerButton.Location = new System.Drawing.Point(92, 69);
            this.powerButton.Margin = new System.Windows.Forms.Padding(2);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(43, 25);
            this.powerButton.TabIndex = 25;
            this.powerButton.Text = "POWER";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // drumButton
            // 
            this.drumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drumButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.drumButton.FlatAppearance.BorderSize = 0;
            this.drumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drumButton.Font = new System.Drawing.Font("Haettenschweiler", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drumButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drumButton.Location = new System.Drawing.Point(172, 69);
            this.drumButton.Name = "drumButton";
            this.drumButton.Size = new System.Drawing.Size(56, 25);
            this.drumButton.TabIndex = 28;
            this.drumButton.Text = "DRUM";
            this.drumButton.UseVisualStyleBackColor = true;
            this.drumButton.Click += new System.EventHandler(this.drumButton_Click);
            // 
            // powerInd
            // 
            this.powerInd.BackColor = System.Drawing.Color.Brown;
            this.powerInd.Location = new System.Drawing.Point(140, 76);
            this.powerInd.Name = "powerInd";
            this.powerInd.Size = new System.Drawing.Size(10, 10);
            this.powerInd.TabIndex = 29;
            // 
            // drumInd
            // 
            this.drumInd.BackColor = System.Drawing.Color.Brown;
            this.drumInd.Location = new System.Drawing.Point(234, 76);
            this.drumInd.Name = "drumInd";
            this.drumInd.Size = new System.Drawing.Size(10, 10);
            this.drumInd.TabIndex = 30;
            // 
            // drumLoop
            // 
            this.drumLoop.Interval = 500;
            this.drumLoop.Tick += new System.EventHandler(this.drumLoop_Tick);
            // 
            // c1Key
            // 
            this.c1Key.BackColor = System.Drawing.Color.White;
            this.c1Key.Enabled = false;
            this.c1Key.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.c1Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.c1Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.c1Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c1Key.Location = new System.Drawing.Point(91, 123);
            this.c1Key.Name = "c1Key";
            this.c1Key.Size = new System.Drawing.Size(44, 196);
            this.c1Key.TabIndex = 31;
            this.c1Key.Text = "c1";
            this.c1Key.UseVisualStyleBackColor = false;
            this.c1Key.Click += new System.EventHandler(this.c1Key_Click);
            // 
            // f1Key
            // 
            this.f1Key.BackColor = System.Drawing.Color.White;
            this.f1Key.Enabled = false;
            this.f1Key.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.f1Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.f1Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.f1Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f1Key.Location = new System.Drawing.Point(223, 123);
            this.f1Key.Name = "f1Key";
            this.f1Key.Size = new System.Drawing.Size(44, 196);
            this.f1Key.TabIndex = 32;
            this.f1Key.Text = "f1";
            this.f1Key.UseVisualStyleBackColor = false;
            this.f1Key.Click += new System.EventHandler(this.f1Key_Click);
            // 
            // d1Key
            // 
            this.d1Key.BackColor = System.Drawing.Color.White;
            this.d1Key.Enabled = false;
            this.d1Key.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.d1Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.d1Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.d1Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d1Key.Location = new System.Drawing.Point(135, 123);
            this.d1Key.Name = "d1Key";
            this.d1Key.Size = new System.Drawing.Size(44, 196);
            this.d1Key.TabIndex = 32;
            this.d1Key.Text = "d1";
            this.d1Key.UseVisualStyleBackColor = false;
            this.d1Key.Click += new System.EventHandler(this.d1Key_Click);
            // 
            // e1Key
            // 
            this.e1Key.BackColor = System.Drawing.Color.White;
            this.e1Key.Enabled = false;
            this.e1Key.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.e1Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.e1Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.e1Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e1Key.Location = new System.Drawing.Point(179, 123);
            this.e1Key.Name = "e1Key";
            this.e1Key.Size = new System.Drawing.Size(44, 196);
            this.e1Key.TabIndex = 32;
            this.e1Key.Text = "e1";
            this.e1Key.UseVisualStyleBackColor = false;
            this.e1Key.Click += new System.EventHandler(this.e1Key_Click);
            // 
            // a2Key
            // 
            this.a2Key.BackColor = System.Drawing.Color.White;
            this.a2Key.Enabled = false;
            this.a2Key.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.a2Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.a2Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.a2Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a2Key.Location = new System.Drawing.Point(311, 123);
            this.a2Key.Name = "a2Key";
            this.a2Key.Size = new System.Drawing.Size(44, 196);
            this.a2Key.TabIndex = 32;
            this.a2Key.Text = "a2";
            this.a2Key.UseVisualStyleBackColor = false;
            this.a2Key.Click += new System.EventHandler(this.a2Key_Click);
            // 
            // g1Key
            // 
            this.g1Key.BackColor = System.Drawing.Color.White;
            this.g1Key.Enabled = false;
            this.g1Key.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.g1Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.g1Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.g1Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g1Key.Location = new System.Drawing.Point(267, 123);
            this.g1Key.Name = "g1Key";
            this.g1Key.Size = new System.Drawing.Size(44, 196);
            this.g1Key.TabIndex = 32;
            this.g1Key.Text = "g1";
            this.g1Key.UseVisualStyleBackColor = false;
            this.g1Key.Click += new System.EventHandler(this.g1Key_Click);
            // 
            // d2Key
            // 
            this.d2Key.BackColor = System.Drawing.Color.White;
            this.d2Key.Enabled = false;
            this.d2Key.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.d2Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.d2Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.d2Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d2Key.Location = new System.Drawing.Point(443, 123);
            this.d2Key.Name = "d2Key";
            this.d2Key.Size = new System.Drawing.Size(44, 196);
            this.d2Key.TabIndex = 33;
            this.d2Key.Text = "d2";
            this.d2Key.UseVisualStyleBackColor = false;
            this.d2Key.Click += new System.EventHandler(this.d2Key_Click);
            // 
            // e2Key
            // 
            this.e2Key.BackColor = System.Drawing.Color.White;
            this.e2Key.Enabled = false;
            this.e2Key.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.e2Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.e2Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.e2Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e2Key.Location = new System.Drawing.Point(487, 123);
            this.e2Key.Name = "e2Key";
            this.e2Key.Size = new System.Drawing.Size(44, 196);
            this.e2Key.TabIndex = 34;
            this.e2Key.Text = "e2";
            this.e2Key.UseVisualStyleBackColor = false;
            this.e2Key.Click += new System.EventHandler(this.e2Key_Click);
            // 
            // b2Key
            // 
            this.b2Key.BackColor = System.Drawing.Color.White;
            this.b2Key.Enabled = false;
            this.b2Key.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.b2Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.b2Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.b2Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2Key.Location = new System.Drawing.Point(355, 123);
            this.b2Key.Name = "b2Key";
            this.b2Key.Size = new System.Drawing.Size(44, 196);
            this.b2Key.TabIndex = 35;
            this.b2Key.Text = "b2";
            this.b2Key.UseVisualStyleBackColor = false;
            this.b2Key.Click += new System.EventHandler(this.b2Key_Click);
            // 
            // c2Key
            // 
            this.c2Key.BackColor = System.Drawing.Color.White;
            this.c2Key.Enabled = false;
            this.c2Key.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.c2Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.c2Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.c2Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c2Key.Location = new System.Drawing.Point(399, 123);
            this.c2Key.Name = "c2Key";
            this.c2Key.Size = new System.Drawing.Size(44, 196);
            this.c2Key.TabIndex = 36;
            this.c2Key.Text = "c2";
            this.c2Key.UseVisualStyleBackColor = false;
            this.c2Key.Click += new System.EventHandler(this.c2Key_Click);
            // 
            // g2Key
            // 
            this.g2Key.BackColor = System.Drawing.Color.White;
            this.g2Key.Enabled = false;
            this.g2Key.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.g2Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.g2Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.g2Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g2Key.Location = new System.Drawing.Point(575, 123);
            this.g2Key.Name = "g2Key";
            this.g2Key.Size = new System.Drawing.Size(44, 196);
            this.g2Key.TabIndex = 37;
            this.g2Key.Text = "g2";
            this.g2Key.UseVisualStyleBackColor = false;
            this.g2Key.Click += new System.EventHandler(this.g2Key_Click);
            // 
            // f2Key
            // 
            this.f2Key.BackColor = System.Drawing.Color.White;
            this.f2Key.Enabled = false;
            this.f2Key.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.f2Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.f2Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.f2Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f2Key.Location = new System.Drawing.Point(531, 123);
            this.f2Key.Name = "f2Key";
            this.f2Key.Size = new System.Drawing.Size(44, 196);
            this.f2Key.TabIndex = 40;
            this.f2Key.Text = "f2";
            this.f2Key.UseVisualStyleBackColor = false;
            this.f2Key.Click += new System.EventHandler(this.f2Key_Click);
            // 
            // a3Key
            // 
            this.a3Key.BackColor = System.Drawing.Color.White;
            this.a3Key.Enabled = false;
            this.a3Key.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.a3Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.a3Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.a3Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a3Key.Location = new System.Drawing.Point(619, 123);
            this.a3Key.Name = "a3Key";
            this.a3Key.Size = new System.Drawing.Size(44, 196);
            this.a3Key.TabIndex = 41;
            this.a3Key.Text = "a3";
            this.a3Key.UseVisualStyleBackColor = false;
            this.a3Key.Click += new System.EventHandler(this.a3Key_Click);
            // 
            // b3Key
            // 
            this.b3Key.BackColor = System.Drawing.Color.White;
            this.b3Key.Enabled = false;
            this.b3Key.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.b3Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.b3Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.b3Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3Key.Location = new System.Drawing.Point(663, 123);
            this.b3Key.Name = "b3Key";
            this.b3Key.Size = new System.Drawing.Size(44, 196);
            this.b3Key.TabIndex = 42;
            this.b3Key.Text = "b3";
            this.b3Key.UseVisualStyleBackColor = false;
            this.b3Key.Click += new System.EventHandler(this.b3Key_Click);
            // 
            // cS1Key
            // 
            this.cS1Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cS1Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.cS1Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.cS1Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cS1Key.Location = new System.Drawing.Point(123, 123);
            this.cS1Key.Name = "cS1Key";
            this.cS1Key.Size = new System.Drawing.Size(23, 116);
            this.cS1Key.TabIndex = 43;
            this.cS1Key.UseVisualStyleBackColor = false;
            this.cS1Key.Click += new System.EventHandler(this.cS1Key_Click);
            // 
            // dS1Key
            // 
            this.dS1Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dS1Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.dS1Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.dS1Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dS1Key.Location = new System.Drawing.Point(167, 123);
            this.dS1Key.Name = "dS1Key";
            this.dS1Key.Size = new System.Drawing.Size(23, 116);
            this.dS1Key.TabIndex = 43;
            this.dS1Key.UseVisualStyleBackColor = false;
            this.dS1Key.Click += new System.EventHandler(this.dS1Key_Click);
            // 
            // fS1Key
            // 
            this.fS1Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.fS1Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.fS1Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.fS1Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fS1Key.Location = new System.Drawing.Point(255, 123);
            this.fS1Key.Name = "fS1Key";
            this.fS1Key.Size = new System.Drawing.Size(23, 116);
            this.fS1Key.TabIndex = 43;
            this.fS1Key.UseVisualStyleBackColor = false;
            this.fS1Key.Click += new System.EventHandler(this.fS1Key_Click);
            // 
            // gS1Key
            // 
            this.gS1Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gS1Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.gS1Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.gS1Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gS1Key.Location = new System.Drawing.Point(299, 123);
            this.gS1Key.Name = "gS1Key";
            this.gS1Key.Size = new System.Drawing.Size(23, 116);
            this.gS1Key.TabIndex = 43;
            this.gS1Key.UseVisualStyleBackColor = false;
            this.gS1Key.Click += new System.EventHandler(this.gS1Key_Click);
            // 
            // aS2Key
            // 
            this.aS2Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.aS2Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.aS2Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.aS2Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aS2Key.Location = new System.Drawing.Point(343, 123);
            this.aS2Key.Name = "aS2Key";
            this.aS2Key.Size = new System.Drawing.Size(23, 116);
            this.aS2Key.TabIndex = 43;
            this.aS2Key.UseVisualStyleBackColor = false;
            this.aS2Key.Click += new System.EventHandler(this.aS2Key_Click);
            // 
            // cS2Key
            // 
            this.cS2Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cS2Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.cS2Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.cS2Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cS2Key.Location = new System.Drawing.Point(431, 123);
            this.cS2Key.Name = "cS2Key";
            this.cS2Key.Size = new System.Drawing.Size(23, 116);
            this.cS2Key.TabIndex = 43;
            this.cS2Key.UseVisualStyleBackColor = false;
            this.cS2Key.Click += new System.EventHandler(this.cS2Key_Click);
            // 
            // dS2Key
            // 
            this.dS2Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dS2Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.dS2Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.dS2Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dS2Key.Location = new System.Drawing.Point(475, 123);
            this.dS2Key.Name = "dS2Key";
            this.dS2Key.Size = new System.Drawing.Size(23, 116);
            this.dS2Key.TabIndex = 43;
            this.dS2Key.UseVisualStyleBackColor = false;
            this.dS2Key.Click += new System.EventHandler(this.dS2Key_Click);
            // 
            // fS2Key
            // 
            this.fS2Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.fS2Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.fS2Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.fS2Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fS2Key.Location = new System.Drawing.Point(563, 123);
            this.fS2Key.Name = "fS2Key";
            this.fS2Key.Size = new System.Drawing.Size(23, 116);
            this.fS2Key.TabIndex = 43;
            this.fS2Key.UseVisualStyleBackColor = false;
            this.fS2Key.Click += new System.EventHandler(this.fS2Key_Click);
            // 
            // gS2Key
            // 
            this.gS2Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gS2Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.gS2Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.gS2Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gS2Key.Location = new System.Drawing.Point(607, 123);
            this.gS2Key.Name = "gS2Key";
            this.gS2Key.Size = new System.Drawing.Size(23, 116);
            this.gS2Key.TabIndex = 43;
            this.gS2Key.UseVisualStyleBackColor = false;
            this.gS2Key.Click += new System.EventHandler(this.gS2Key_Click);
            // 
            // aS3Key
            // 
            this.aS3Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.aS3Key.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.aS3Key.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.aS3Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aS3Key.Location = new System.Drawing.Point(651, 123);
            this.aS3Key.Name = "aS3Key";
            this.aS3Key.Size = new System.Drawing.Size(23, 116);
            this.aS3Key.TabIndex = 43;
            this.aS3Key.UseVisualStyleBackColor = false;
            this.aS3Key.Click += new System.EventHandler(this.aS3Key_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.aS3Key);
            this.Controls.Add(this.gS2Key);
            this.Controls.Add(this.fS2Key);
            this.Controls.Add(this.dS2Key);
            this.Controls.Add(this.cS2Key);
            this.Controls.Add(this.aS2Key);
            this.Controls.Add(this.gS1Key);
            this.Controls.Add(this.fS1Key);
            this.Controls.Add(this.dS1Key);
            this.Controls.Add(this.cS1Key);
            this.Controls.Add(this.drumInd);
            this.Controls.Add(this.powerInd);
            this.Controls.Add(this.drumButton);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.b3Key);
            this.Controls.Add(this.a3Key);
            this.Controls.Add(this.g2Key);
            this.Controls.Add(this.f2Key);
            this.Controls.Add(this.d2Key);
            this.Controls.Add(this.e2Key);
            this.Controls.Add(this.b2Key);
            this.Controls.Add(this.c2Key);
            this.Controls.Add(this.d1Key);
            this.Controls.Add(this.g1Key);
            this.Controls.Add(this.a2Key);
            this.Controls.Add(this.e1Key);
            this.Controls.Add(this.f1Key);
            this.Controls.Add(this.c1Key);
            this.Controls.Add(this.pianoBase);
            this.Name = "Form1";
            this.Text = "SUPERSYNTH 3000";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pianoBase;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button drumButton;
        private System.Windows.Forms.Label powerInd;
        private System.Windows.Forms.Label drumInd;
        private System.Windows.Forms.Timer drumLoop;
        private System.Windows.Forms.Button c1Key;
        private System.Windows.Forms.Button f1Key;
        private System.Windows.Forms.Button d1Key;
        private System.Windows.Forms.Button e1Key;
        private System.Windows.Forms.Button a2Key;
        private System.Windows.Forms.Button g1Key;
        private System.Windows.Forms.Button d2Key;
        private System.Windows.Forms.Button e2Key;
        private System.Windows.Forms.Button b2Key;
        private System.Windows.Forms.Button c2Key;
        private System.Windows.Forms.Button g2Key;
        private System.Windows.Forms.Button f2Key;
        private System.Windows.Forms.Button a3Key;
        private System.Windows.Forms.Button b3Key;
        private System.Windows.Forms.Button cS1Key;
        private System.Windows.Forms.Button dS1Key;
        private System.Windows.Forms.Button fS1Key;
        private System.Windows.Forms.Button gS1Key;
        private System.Windows.Forms.Button aS2Key;
        private System.Windows.Forms.Button cS2Key;
        private System.Windows.Forms.Button dS2Key;
        private System.Windows.Forms.Button fS2Key;
        private System.Windows.Forms.Button gS2Key;
        private System.Windows.Forms.Button aS3Key;
    }
}

