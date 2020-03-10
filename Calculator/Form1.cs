using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private ComponentResourceManager resources;

        private Calculator calculator;
        private Caretaker caretaker;

        public Form1()
        {
            InitializeComponent();

            resources = new ComponentResourceManager(typeof(Form1));

            calculator = new Calculator();

            caretaker = new Caretaker(calculator);

            CultureInfo ci = CultureInfo.InstalledUICulture;

            switch (ci.Name)
            {
                case "fr-FR":
                    ChangeLanguage(ci.Name);
                    break;
                case "zh-TW":
                    ChangeLanguage(ci.Name);
                    break;
                default:
                    break;
            }

            undoMenuItem.Enabled = false;
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            String culture = Thread.CurrentThread.CurrentUICulture.Name;

            String message;

            switch (culture)
            {
                case "fr-FR":
                    message = "Un programme de calculatrice simple avec annulation et prise en charge multilingue.";
                    message += "\nÉcrit par Ben Payne";
                    break;
                case "zh-TW":
                    message = "具有撤消和多语言支持的简单计算器程序。";
                    message += "\n撰写者 Ben Payne";
                    break;
                default:
                    message = "A simple calculator program with undo, and multilanguage support.";
                    message += "\nWritten by Ben Payne";
                    break;
            }

            MessageBox.Show(message);
        }

        private void EnglishLanguageMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en-US");
        }

        private void MandarinLanguageMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("zh-TW");
        }

        private void FrenchLanguageMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("fr-FR");
        }

        private void ChangeLanguage(String language)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            resources.ApplyResources(fileMenuItem, fileMenuItem.Name, new CultureInfo(language));
            resources.ApplyResources(exitMenuItem, exitMenuItem.Name, new CultureInfo(language));
            resources.ApplyResources(editMenuItem, editMenuItem.Name, new CultureInfo(language));
            resources.ApplyResources(undoMenuItem, undoMenuItem.Name, new CultureInfo(language));
            resources.ApplyResources(helpMenuItem, helpMenuItem.Name, new CultureInfo(language));
            resources.ApplyResources(languageMenuItem, languageMenuItem.Name, new CultureInfo(language));
            resources.ApplyResources(englishLanguageMenuItem, englishLanguageMenuItem.Name, new CultureInfo(language));
            resources.ApplyResources(chineeseLanguageMenuItem, chineeseLanguageMenuItem.Name, new CultureInfo(language));
            resources.ApplyResources(frenchLanguageMenuItem, frenchLanguageMenuItem.Name, new CultureInfo(language));
            resources.ApplyResources(aboutMenuItem, aboutMenuItem.Name, new CultureInfo(language));
        }

        private void undoMenuItem_Click(object sender, EventArgs e)
        {
            Int32 mementosCount = caretaker.Undo();

            undoMenuItem.Enabled = mementosCount > 0;

            outputScreen.Text = calculator.ToString();
        }

        private void calculatorButtonClear_Click(object sender, EventArgs e)
        {
            caretaker.Clear();

            calculator.Clear();

            outputScreen.Text = "";

            undoMenuItem.Enabled = false;
        }

        private void calculatorButton0_Click(object sender, EventArgs e)
        {
            calculator.Constant("0");

            outputScreen.Text += "0";
        }

        private void calculatorButton1_Click(object sender, EventArgs e)
        {
            calculator.Constant("1");

            outputScreen.Text += "1";
        }

        private void calculatorButton2_Click(object sender, EventArgs e)
        {
            calculator.Constant("2");

            outputScreen.Text += "2";
        }

        private void calculatorButton3_Click(object sender, EventArgs e)
        {
            calculator.Constant("3");

            outputScreen.Text += "3";
        }

        private void calculatorButton4_Click(object sender, EventArgs e)
        {
            calculator.Constant("4");

            outputScreen.Text += "4";
        }

        private void calculatorButton5_Click(object sender, EventArgs e)
        {
            calculator.Constant("5");

            outputScreen.Text += "5";
        }

        private void calculatorButton6_Click(object sender, EventArgs e)
        {
            calculator.Constant("6");

            outputScreen.Text += "6";
        }

        private void calculatorButton7_Click(object sender, EventArgs e)
        {
            calculator.Constant("7");

            outputScreen.Text += "7";
        }

        private void calculatorButton8_Click(object sender, EventArgs e)
        {
            calculator.Constant("8");

            outputScreen.Text += "8";
        }

        private void calculatorButton9_Click(object sender, EventArgs e)
        {
            calculator.Constant("9");

            outputScreen.Text += "9";
        }

        private void calculatorButtonMultiply_Click(object sender, EventArgs e)
        {
            caretaker.Backup();

            calculator.Multiply();

            outputScreen.Text = "";

            caretaker.Backup();
            undoMenuItem.Enabled = true;
        }

        private void calculatorButtonDivide_Click(object sender, EventArgs e)
        {
            caretaker.Backup();

            calculator.Divide();

            outputScreen.Text = "";

            undoMenuItem.Enabled = true;
        }

        private void calculatorAdd_Click(object sender, EventArgs e)
        {
            caretaker.Backup();

            calculator.Add();

            outputScreen.Text = "";

            undoMenuItem.Enabled = true;
        }

        private void calculatorButtonSubtract_Click(object sender, EventArgs e)
        {
            caretaker.Backup();

            calculator.Subtract();

            outputScreen.Text = "";

            undoMenuItem.Enabled = true;
        }

        private void calculatorButtonDecimalPoint_Click(object sender, EventArgs e)
        {
            if (outputScreen.Text[outputScreen.Text.Length - 1] == '.')
            {
                return;
            }

            calculator.DecimalPoint();

            outputScreen.Text += ".";
        }

        private void calculatorButtonEquals_Click(object sender, EventArgs e)
        {
            if (calculator.ToString() == "")
            {
                return;
            }

            caretaker.Backup();

            String solution = calculator.Solve();

            outputScreen.Text = solution;

            undoMenuItem.Enabled = true;
        }
    }
}
