using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MatchData(textBox1.Text));
        }

        private string MatchData(string inputString)
        {
            // instance methods
            //^(?\S{3})-(?\d{4})$
            Regex myRegex = new Regex(
                @"^(?<StringPrefix>\S{3})-(?<DecimalPostfix>\d{4})$");
            Match expressionMatches = myRegex.Match(inputString);
            //expressionMatches.Groups[0];
            // static methods
            //Match expressionMatches = Regex.Match(inputString,
            //    @"^(?<StringPrefix>\S{3})-(?<DecimalPostfix>\d{4})$");

            return String.Format("Input string prefix: {0}, decimal postfix: {1}",
                expressionMatches.Groups["StringPrefix"].ToString(),
                expressionMatches.Groups["DecimalPostfix"].ToString());
        }
    }
}
