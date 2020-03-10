namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputScreen = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishLanguageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chineeseLanguageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchLanguageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorButton7 = new System.Windows.Forms.Button();
            this.calculatorButton8 = new System.Windows.Forms.Button();
            this.calculatorButton9 = new System.Windows.Forms.Button();
            this.calculatorAdd = new System.Windows.Forms.Button();
            this.calculatorButton4 = new System.Windows.Forms.Button();
            this.calculatorButton5 = new System.Windows.Forms.Button();
            this.calculatorButton6 = new System.Windows.Forms.Button();
            this.calculatorButtonEquals = new System.Windows.Forms.Button();
            this.calculatorButton1 = new System.Windows.Forms.Button();
            this.calculatorButton2 = new System.Windows.Forms.Button();
            this.calculatorButton3 = new System.Windows.Forms.Button();
            this.calculatorButton0 = new System.Windows.Forms.Button();
            this.calculatorButtonDecimalPoint = new System.Windows.Forms.Button();
            this.calculatorButtonClear = new System.Windows.Forms.Button();
            this.calculatorButtonDivide = new System.Windows.Forms.Button();
            this.calculatorButtonMultiply = new System.Windows.Forms.Button();
            this.calculatorButtonSubtract = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputScreen
            // 
            resources.ApplyResources(this.outputScreen, "outputScreen");
            this.outputScreen.Name = "outputScreen";
            this.outputScreen.ReadOnly = true;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.helpMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileMenuItem
            // 
            resources.ApplyResources(this.fileMenuItem, "fileMenuItem");
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            // 
            // exitMenuItem
            // 
            resources.ApplyResources(this.exitMenuItem, "exitMenuItem");
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // editMenuItem
            // 
            resources.ApplyResources(this.editMenuItem, "editMenuItem");
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            // 
            // undoMenuItem
            // 
            resources.ApplyResources(this.undoMenuItem, "undoMenuItem");
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.Click += new System.EventHandler(this.undoMenuItem_Click);
            // 
            // helpMenuItem
            // 
            resources.ApplyResources(this.helpMenuItem, "helpMenuItem");
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageMenuItem,
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            // 
            // languageMenuItem
            // 
            resources.ApplyResources(this.languageMenuItem, "languageMenuItem");
            this.languageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishLanguageMenuItem,
            this.chineeseLanguageMenuItem,
            this.frenchLanguageMenuItem});
            this.languageMenuItem.Name = "languageMenuItem";
            // 
            // englishLanguageMenuItem
            // 
            resources.ApplyResources(this.englishLanguageMenuItem, "englishLanguageMenuItem");
            this.englishLanguageMenuItem.Name = "englishLanguageMenuItem";
            this.englishLanguageMenuItem.Click += new System.EventHandler(this.EnglishLanguageMenuItem_Click);
            // 
            // chineeseLanguageMenuItem
            // 
            resources.ApplyResources(this.chineeseLanguageMenuItem, "chineeseLanguageMenuItem");
            this.chineeseLanguageMenuItem.Name = "chineeseLanguageMenuItem";
            this.chineeseLanguageMenuItem.Click += new System.EventHandler(this.MandarinLanguageMenuItem_Click);
            // 
            // frenchLanguageMenuItem
            // 
            resources.ApplyResources(this.frenchLanguageMenuItem, "frenchLanguageMenuItem");
            this.frenchLanguageMenuItem.Name = "frenchLanguageMenuItem";
            this.frenchLanguageMenuItem.Click += new System.EventHandler(this.FrenchLanguageMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            resources.ApplyResources(this.aboutMenuItem, "aboutMenuItem");
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // calculatorButton7
            // 
            resources.ApplyResources(this.calculatorButton7, "calculatorButton7");
            this.calculatorButton7.Name = "calculatorButton7";
            this.calculatorButton7.UseVisualStyleBackColor = true;
            this.calculatorButton7.Click += new System.EventHandler(this.calculatorButton7_Click);
            // 
            // calculatorButton8
            // 
            resources.ApplyResources(this.calculatorButton8, "calculatorButton8");
            this.calculatorButton8.Name = "calculatorButton8";
            this.calculatorButton8.UseVisualStyleBackColor = true;
            this.calculatorButton8.Click += new System.EventHandler(this.calculatorButton8_Click);
            // 
            // calculatorButton9
            // 
            resources.ApplyResources(this.calculatorButton9, "calculatorButton9");
            this.calculatorButton9.Name = "calculatorButton9";
            this.calculatorButton9.UseVisualStyleBackColor = true;
            this.calculatorButton9.Click += new System.EventHandler(this.calculatorButton9_Click);
            // 
            // calculatorAdd
            // 
            resources.ApplyResources(this.calculatorAdd, "calculatorAdd");
            this.calculatorAdd.Name = "calculatorAdd";
            this.calculatorAdd.UseVisualStyleBackColor = true;
            this.calculatorAdd.Click += new System.EventHandler(this.calculatorAdd_Click);
            // 
            // calculatorButton4
            // 
            resources.ApplyResources(this.calculatorButton4, "calculatorButton4");
            this.calculatorButton4.Name = "calculatorButton4";
            this.calculatorButton4.UseVisualStyleBackColor = true;
            this.calculatorButton4.Click += new System.EventHandler(this.calculatorButton4_Click);
            // 
            // calculatorButton5
            // 
            resources.ApplyResources(this.calculatorButton5, "calculatorButton5");
            this.calculatorButton5.Name = "calculatorButton5";
            this.calculatorButton5.UseVisualStyleBackColor = true;
            this.calculatorButton5.Click += new System.EventHandler(this.calculatorButton5_Click);
            // 
            // calculatorButton6
            // 
            resources.ApplyResources(this.calculatorButton6, "calculatorButton6");
            this.calculatorButton6.Name = "calculatorButton6";
            this.calculatorButton6.UseVisualStyleBackColor = true;
            this.calculatorButton6.Click += new System.EventHandler(this.calculatorButton6_Click);
            // 
            // calculatorButtonEquals
            // 
            resources.ApplyResources(this.calculatorButtonEquals, "calculatorButtonEquals");
            this.calculatorButtonEquals.Name = "calculatorButtonEquals";
            this.calculatorButtonEquals.UseVisualStyleBackColor = true;
            this.calculatorButtonEquals.Click += new System.EventHandler(this.calculatorButtonEquals_Click);
            // 
            // calculatorButton1
            // 
            resources.ApplyResources(this.calculatorButton1, "calculatorButton1");
            this.calculatorButton1.Name = "calculatorButton1";
            this.calculatorButton1.UseVisualStyleBackColor = true;
            this.calculatorButton1.Click += new System.EventHandler(this.calculatorButton1_Click);
            // 
            // calculatorButton2
            // 
            resources.ApplyResources(this.calculatorButton2, "calculatorButton2");
            this.calculatorButton2.Name = "calculatorButton2";
            this.calculatorButton2.UseVisualStyleBackColor = true;
            this.calculatorButton2.Click += new System.EventHandler(this.calculatorButton2_Click);
            // 
            // calculatorButton3
            // 
            resources.ApplyResources(this.calculatorButton3, "calculatorButton3");
            this.calculatorButton3.Name = "calculatorButton3";
            this.calculatorButton3.UseVisualStyleBackColor = true;
            this.calculatorButton3.Click += new System.EventHandler(this.calculatorButton3_Click);
            // 
            // calculatorButton0
            // 
            resources.ApplyResources(this.calculatorButton0, "calculatorButton0");
            this.calculatorButton0.Name = "calculatorButton0";
            this.calculatorButton0.UseVisualStyleBackColor = true;
            this.calculatorButton0.Click += new System.EventHandler(this.calculatorButton0_Click);
            // 
            // calculatorButtonDecimalPoint
            // 
            resources.ApplyResources(this.calculatorButtonDecimalPoint, "calculatorButtonDecimalPoint");
            this.calculatorButtonDecimalPoint.Name = "calculatorButtonDecimalPoint";
            this.calculatorButtonDecimalPoint.UseVisualStyleBackColor = true;
            this.calculatorButtonDecimalPoint.Click += new System.EventHandler(this.calculatorButtonDecimalPoint_Click);
            // 
            // calculatorButtonClear
            // 
            resources.ApplyResources(this.calculatorButtonClear, "calculatorButtonClear");
            this.calculatorButtonClear.Name = "calculatorButtonClear";
            this.calculatorButtonClear.UseVisualStyleBackColor = true;
            this.calculatorButtonClear.Click += new System.EventHandler(this.calculatorButtonClear_Click);
            // 
            // calculatorButtonDivide
            // 
            resources.ApplyResources(this.calculatorButtonDivide, "calculatorButtonDivide");
            this.calculatorButtonDivide.Name = "calculatorButtonDivide";
            this.calculatorButtonDivide.UseVisualStyleBackColor = true;
            this.calculatorButtonDivide.Click += new System.EventHandler(this.calculatorButtonDivide_Click);
            // 
            // calculatorButtonMultiply
            // 
            resources.ApplyResources(this.calculatorButtonMultiply, "calculatorButtonMultiply");
            this.calculatorButtonMultiply.Name = "calculatorButtonMultiply";
            this.calculatorButtonMultiply.UseVisualStyleBackColor = true;
            this.calculatorButtonMultiply.Click += new System.EventHandler(this.calculatorButtonMultiply_Click);
            // 
            // calculatorButtonSubtract
            // 
            resources.ApplyResources(this.calculatorButtonSubtract, "calculatorButtonSubtract");
            this.calculatorButtonSubtract.Name = "calculatorButtonSubtract";
            this.calculatorButtonSubtract.UseVisualStyleBackColor = true;
            this.calculatorButtonSubtract.Click += new System.EventHandler(this.calculatorButtonSubtract_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.calculatorButtonSubtract);
            this.Controls.Add(this.calculatorButtonMultiply);
            this.Controls.Add(this.calculatorButtonDivide);
            this.Controls.Add(this.calculatorButtonClear);
            this.Controls.Add(this.calculatorButtonDecimalPoint);
            this.Controls.Add(this.calculatorButton0);
            this.Controls.Add(this.calculatorButton3);
            this.Controls.Add(this.calculatorButton2);
            this.Controls.Add(this.calculatorButton1);
            this.Controls.Add(this.calculatorButtonEquals);
            this.Controls.Add(this.calculatorButton6);
            this.Controls.Add(this.calculatorButton5);
            this.Controls.Add(this.calculatorButton4);
            this.Controls.Add(this.calculatorAdd);
            this.Controls.Add(this.calculatorButton7);
            this.Controls.Add(this.calculatorButton8);
            this.Controls.Add(this.calculatorButton9);
            this.Controls.Add(this.outputScreen);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishLanguageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chineeseLanguageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchLanguageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.Button calculatorButton7;
        private System.Windows.Forms.Button calculatorButton8;
        private System.Windows.Forms.Button calculatorButton9;
        private System.Windows.Forms.Button calculatorAdd;
        private System.Windows.Forms.Button calculatorButton4;
        private System.Windows.Forms.Button calculatorButton5;
        private System.Windows.Forms.Button calculatorButton6;
        private System.Windows.Forms.Button calculatorButtonEquals;
        private System.Windows.Forms.Button calculatorButton1;
        private System.Windows.Forms.Button calculatorButton2;
        private System.Windows.Forms.Button calculatorButton3;
        private System.Windows.Forms.Button calculatorButton0;
        private System.Windows.Forms.Button calculatorButtonDecimalPoint;
        private System.Windows.Forms.Button calculatorButtonClear;
        private System.Windows.Forms.Button calculatorButtonDivide;
        private System.Windows.Forms.Button calculatorButtonMultiply;
        private System.Windows.Forms.Button calculatorButtonSubtract;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoMenuItem;
        private System.Windows.Forms.TextBox outputScreen;
    }
}

