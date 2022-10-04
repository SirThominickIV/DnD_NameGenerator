namespace DnD_Name_Generator
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
            this.rtb_Consonants = new System.Windows.Forms.RichTextBox();
            this.rtb_Vowels = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_Output = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_Pattern = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.b_ClearConsonants = new System.Windows.Forms.Button();
            this.b_ClearVowels = new System.Windows.Forms.Button();
            this.b_ClearPattern = new System.Windows.Forms.Button();
            this.b_ClearOutput = new System.Windows.Forms.Button();
            this.b_CreateName = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_AddVowelPattern = new System.Windows.Forms.Button();
            this.b_AddConsonantPattern = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.b_AddVowel = new System.Windows.Forms.Button();
            this.b_AddConsonant = new System.Windows.Forms.Button();
            this.tb_Vowels = new System.Windows.Forms.TextBox();
            this.tb_Consonants = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.b_CreateRandomSize = new System.Windows.Forms.Button();
            this.bt_CreatePattern = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_PatternLength = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_CreateRandom = new System.Windows.Forms.CheckBox();
            this.cb_CreateMax = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Github = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_Consonants
            // 
            this.rtb_Consonants.Location = new System.Drawing.Point(293, 63);
            this.rtb_Consonants.Name = "rtb_Consonants";
            this.rtb_Consonants.Size = new System.Drawing.Size(100, 451);
            this.rtb_Consonants.TabIndex = 0;
            this.rtb_Consonants.Text = "";
            // 
            // rtb_Vowels
            // 
            this.rtb_Vowels.Location = new System.Drawing.Point(399, 63);
            this.rtb_Vowels.Name = "rtb_Vowels";
            this.rtb_Vowels.Size = new System.Drawing.Size(100, 451);
            this.rtb_Vowels.TabIndex = 1;
            this.rtb_Vowels.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consonants";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vowels";
            // 
            // rtb_Output
            // 
            this.rtb_Output.Location = new System.Drawing.Point(750, 63);
            this.rtb_Output.Name = "rtb_Output";
            this.rtb_Output.Size = new System.Drawing.Size(193, 451);
            this.rtb_Output.TabIndex = 4;
            this.rtb_Output.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output";
            // 
            // rtb_Pattern
            // 
            this.rtb_Pattern.Location = new System.Drawing.Point(565, 60);
            this.rtb_Pattern.Name = "rtb_Pattern";
            this.rtb_Pattern.Size = new System.Drawing.Size(100, 454);
            this.rtb_Pattern.TabIndex = 10;
            this.rtb_Pattern.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Consonant/Vowel Pattern";
            // 
            // b_ClearConsonants
            // 
            this.b_ClearConsonants.Location = new System.Drawing.Point(293, 506);
            this.b_ClearConsonants.Name = "b_ClearConsonants";
            this.b_ClearConsonants.Size = new System.Drawing.Size(100, 23);
            this.b_ClearConsonants.TabIndex = 16;
            this.b_ClearConsonants.Text = "Clear";
            this.b_ClearConsonants.UseVisualStyleBackColor = true;
            this.b_ClearConsonants.Click += new System.EventHandler(this.b_ClearConsonants_Click);
            // 
            // b_ClearVowels
            // 
            this.b_ClearVowels.Location = new System.Drawing.Point(399, 506);
            this.b_ClearVowels.Name = "b_ClearVowels";
            this.b_ClearVowels.Size = new System.Drawing.Size(100, 23);
            this.b_ClearVowels.TabIndex = 17;
            this.b_ClearVowels.Text = "Clear";
            this.b_ClearVowels.UseVisualStyleBackColor = true;
            this.b_ClearVowels.Click += new System.EventHandler(this.b_ClearVowels_Click);
            // 
            // b_ClearPattern
            // 
            this.b_ClearPattern.Location = new System.Drawing.Point(565, 506);
            this.b_ClearPattern.Name = "b_ClearPattern";
            this.b_ClearPattern.Size = new System.Drawing.Size(100, 23);
            this.b_ClearPattern.TabIndex = 18;
            this.b_ClearPattern.Text = "Clear";
            this.b_ClearPattern.UseVisualStyleBackColor = true;
            this.b_ClearPattern.Click += new System.EventHandler(this.b_ClearPattern_Click);
            // 
            // b_ClearOutput
            // 
            this.b_ClearOutput.Location = new System.Drawing.Point(750, 506);
            this.b_ClearOutput.Name = "b_ClearOutput";
            this.b_ClearOutput.Size = new System.Drawing.Size(193, 23);
            this.b_ClearOutput.TabIndex = 19;
            this.b_ClearOutput.Text = "Clear";
            this.b_ClearOutput.UseVisualStyleBackColor = true;
            this.b_ClearOutput.Click += new System.EventHandler(this.b_ClearOutput_Click);
            // 
            // b_CreateName
            // 
            this.b_CreateName.Location = new System.Drawing.Point(37, 506);
            this.b_CreateName.Name = "b_CreateName";
            this.b_CreateName.Size = new System.Drawing.Size(186, 23);
            this.b_CreateName.TabIndex = 20;
            this.b_CreateName.Text = "Create Name";
            this.b_CreateName.UseVisualStyleBackColor = true;
            this.b_CreateName.Click += new System.EventHandler(this.b_CreateName_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.b_AddVowelPattern);
            this.panel1.Controls.Add(this.b_AddConsonantPattern);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(22, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 82);
            this.panel1.TabIndex = 24;
            // 
            // b_AddVowelPattern
            // 
            this.b_AddVowelPattern.Location = new System.Drawing.Point(116, 38);
            this.b_AddVowelPattern.Name = "b_AddVowelPattern";
            this.b_AddVowelPattern.Size = new System.Drawing.Size(90, 23);
            this.b_AddVowelPattern.TabIndex = 26;
            this.b_AddVowelPattern.Text = "Add Vowel";
            this.b_AddVowelPattern.UseVisualStyleBackColor = true;
            this.b_AddVowelPattern.Click += new System.EventHandler(this.b_AddVowelPattern_Click);
            // 
            // b_AddConsonantPattern
            // 
            this.b_AddConsonantPattern.Location = new System.Drawing.Point(20, 38);
            this.b_AddConsonantPattern.Name = "b_AddConsonantPattern";
            this.b_AddConsonantPattern.Size = new System.Drawing.Size(90, 23);
            this.b_AddConsonantPattern.TabIndex = 25;
            this.b_AddConsonantPattern.Text = "Add Consonant";
            this.b_AddConsonantPattern.UseVisualStyleBackColor = true;
            this.b_AddConsonantPattern.Click += new System.EventHandler(this.b_AddConsonantPattern_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Manual Pattern:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.b_AddVowel);
            this.panel2.Controls.Add(this.b_AddConsonant);
            this.panel2.Controls.Add(this.tb_Vowels);
            this.panel2.Controls.Add(this.tb_Consonants);
            this.panel2.Location = new System.Drawing.Point(22, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 117);
            this.panel2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Available Consonants and Vowels:";
            // 
            // b_AddVowel
            // 
            this.b_AddVowel.Location = new System.Drawing.Point(116, 73);
            this.b_AddVowel.Name = "b_AddVowel";
            this.b_AddVowel.Size = new System.Drawing.Size(90, 23);
            this.b_AddVowel.TabIndex = 19;
            this.b_AddVowel.Text = "Add Vowel";
            this.b_AddVowel.UseVisualStyleBackColor = true;
            this.b_AddVowel.Click += new System.EventHandler(this.b_AddVowel_Click);
            // 
            // b_AddConsonant
            // 
            this.b_AddConsonant.Location = new System.Drawing.Point(116, 46);
            this.b_AddConsonant.Name = "b_AddConsonant";
            this.b_AddConsonant.Size = new System.Drawing.Size(90, 23);
            this.b_AddConsonant.TabIndex = 18;
            this.b_AddConsonant.Text = "Add Consonant";
            this.b_AddConsonant.UseVisualStyleBackColor = true;
            this.b_AddConsonant.Click += new System.EventHandler(this.b_AddConsonant_Click);
            // 
            // tb_Vowels
            // 
            this.tb_Vowels.Location = new System.Drawing.Point(10, 76);
            this.tb_Vowels.Name = "tb_Vowels";
            this.tb_Vowels.Size = new System.Drawing.Size(100, 20);
            this.tb_Vowels.TabIndex = 17;
            this.tb_Vowels.Enter += new System.EventHandler(this.b_AddVowel_Click);
            // 
            // tb_Consonants
            // 
            this.tb_Consonants.Location = new System.Drawing.Point(10, 49);
            this.tb_Consonants.Name = "tb_Consonants";
            this.tb_Consonants.Size = new System.Drawing.Size(100, 20);
            this.tb_Consonants.TabIndex = 16;
            this.tb_Consonants.Enter += new System.EventHandler(this.b_AddConsonant_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.b_CreateRandomSize);
            this.panel3.Controls.Add(this.bt_CreatePattern);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tb_PatternLength);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(22, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 139);
            this.panel3.TabIndex = 26;
            // 
            // b_CreateRandomSize
            // 
            this.b_CreateRandomSize.Location = new System.Drawing.Point(116, 88);
            this.b_CreateRandomSize.Name = "b_CreateRandomSize";
            this.b_CreateRandomSize.Size = new System.Drawing.Size(90, 23);
            this.b_CreateRandomSize.TabIndex = 33;
            this.b_CreateRandomSize.Text = "Create Random";
            this.b_CreateRandomSize.UseVisualStyleBackColor = true;
            this.b_CreateRandomSize.Click += new System.EventHandler(this.b_CreateRandomSize_Click);
            // 
            // bt_CreatePattern
            // 
            this.bt_CreatePattern.Location = new System.Drawing.Point(20, 88);
            this.bt_CreatePattern.Name = "bt_CreatePattern";
            this.bt_CreatePattern.Size = new System.Drawing.Size(90, 23);
            this.bt_CreatePattern.TabIndex = 32;
            this.bt_CreatePattern.Text = "Create Max";
            this.bt_CreatePattern.UseVisualStyleBackColor = true;
            this.bt_CreatePattern.Click += new System.EventHandler(this.bt_CreatePattern_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Max Length:";
            // 
            // tb_PatternLength
            // 
            this.tb_PatternLength.Location = new System.Drawing.Point(96, 42);
            this.tb_PatternLength.MaxLength = 4;
            this.tb_PatternLength.Name = "tb_PatternLength";
            this.tb_PatternLength.Size = new System.Drawing.Size(100, 20);
            this.tb_PatternLength.TabIndex = 30;
            this.tb_PatternLength.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Auto Pattern:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cb_CreateRandom);
            this.panel4.Controls.Add(this.cb_CreateMax);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(22, 381);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 103);
            this.panel4.TabIndex = 27;
            // 
            // cb_CreateRandom
            // 
            this.cb_CreateRandom.AutoSize = true;
            this.cb_CreateRandom.Checked = true;
            this.cb_CreateRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_CreateRandom.Location = new System.Drawing.Point(20, 67);
            this.cb_CreateRandom.Name = "cb_CreateRandom";
            this.cb_CreateRandom.Size = new System.Drawing.Size(159, 17);
            this.cb_CreateRandom.TabIndex = 26;
            this.cb_CreateRandom.Text = "Always Create Random Size";
            this.cb_CreateRandom.UseVisualStyleBackColor = true;
            this.cb_CreateRandom.CheckedChanged += new System.EventHandler(this.cb_CreateRandom_CheckedChanged);
            // 
            // cb_CreateMax
            // 
            this.cb_CreateMax.AutoSize = true;
            this.cb_CreateMax.Location = new System.Drawing.Point(20, 44);
            this.cb_CreateMax.Name = "cb_CreateMax";
            this.cb_CreateMax.Size = new System.Drawing.Size(139, 17);
            this.cb_CreateMax.TabIndex = 25;
            this.cb_CreateMax.Text = "Always Create Max Size";
            this.cb_CreateMax.UseVisualStyleBackColor = true;
            this.cb_CreateMax.CheckedChanged += new System.EventHandler(this.cb_CreateMax_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Auto Pattern Settings:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_About,
            this.menu_Github});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_About
            // 
            this.menu_About.Name = "menu_About";
            this.menu_About.Size = new System.Drawing.Size(52, 20);
            this.menu_About.Text = "About";
            this.menu_About.Click += new System.EventHandler(this.menu_About_Click);
            // 
            // menu_Github
            // 
            this.menu_Github.Name = "menu_Github";
            this.menu_Github.Size = new System.Drawing.Size(57, 20);
            this.menu_Github.Text = "GitHub";
            this.menu_Github.Click += new System.EventHandler(this.menu_Github_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 559);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_CreateName);
            this.Controls.Add(this.b_ClearOutput);
            this.Controls.Add(this.b_ClearPattern);
            this.Controls.Add(this.b_ClearVowels);
            this.Controls.Add(this.b_ClearConsonants);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtb_Pattern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb_Output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_Vowels);
            this.Controls.Add(this.rtb_Consonants);
            this.Name = "Form1";
            this.Text = "Dungeons and Dragons Name Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Consonants;
        private System.Windows.Forms.RichTextBox rtb_Vowels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_Output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_Pattern;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_ClearConsonants;
        private System.Windows.Forms.Button b_ClearVowels;
        private System.Windows.Forms.Button b_ClearPattern;
        private System.Windows.Forms.Button b_ClearOutput;
        private System.Windows.Forms.Button b_CreateName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_AddVowelPattern;
        private System.Windows.Forms.Button b_AddConsonantPattern;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_AddVowel;
        private System.Windows.Forms.Button b_AddConsonant;
        private System.Windows.Forms.TextBox tb_Vowels;
        private System.Windows.Forms.TextBox tb_Consonants;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button b_CreateRandomSize;
        private System.Windows.Forms.Button bt_CreatePattern;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_PatternLength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cb_CreateRandom;
        private System.Windows.Forms.CheckBox cb_CreateMax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_About;
        private System.Windows.Forms.ToolStripMenuItem menu_Github;
    }
}

