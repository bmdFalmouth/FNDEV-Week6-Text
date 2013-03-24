using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncodingNonASCIIFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create an ASCII encoding.
            Encoding ascii = Encoding.ASCII;

            // A Unicode string with two characters outside the ASCII code range.
            String unicodeString =
                "This unicode string contains two characters " +
                "with codes outside the ASCII code range, " +
                "Pi (\u03a0) and Sigma (\u03a3).";
            textBox1.AppendText("Original string:");
            textBox1.AppendText(unicodeString);

            // Save the positions of the special characters for later reference.
            int indexOfPi = unicodeString.IndexOf('\u03a0');
            int indexOfSigma = unicodeString.IndexOf('\u03a3');

            // Encode the string.
            Byte[] encodedBytes = ascii.GetBytes(unicodeString);
            textBox1.AppendText("\r\nEncoded bytes:");
            foreach (Byte b in encodedBytes)
            {
                textBox1.AppendText(b + " ");
            }

            // Notice that the special characters have been replaced with
            // the value 63, which is the ASCII character code for '?'.
            textBox1.AppendText(
                "\r\nValue at position of Pi character: " +
                encodedBytes[indexOfPi]
                );
            textBox1.AppendText(
                "\r\nValue at position of Sigma character: " +
                encodedBytes[indexOfSigma]
                );

            // Decode bytes back to a string.
            // Notice missing the Pi and Sigma characters.
            String decodedString = ascii.GetString(encodedBytes);
            textBox1.AppendText("\r\nDecoded bytes:");
            textBox1.AppendText(decodedString);
        }
    }
}
