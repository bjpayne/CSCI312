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

        public Form1()
        {
            InitializeComponent();

            resources = new ComponentResourceManager(typeof(Form1));

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

        }

        private void calculatorButtonClear_Click(object sender, EventArgs e)
        {

        }
    }
}
