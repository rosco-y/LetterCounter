using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterCounter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdOpenTextFile_Click(object sender, EventArgs e)
        {
            if (openTextFile.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    CountLetters counter = new CountLetters(openTextFile.FileName);
                    if (counter.Success)
                    {
                        cmdOpenTextFile.Text = openTextFile.SafeFileName;
                        foreach (var item in counter.SortedCharacterCount)
                        {
                            listBox1.Items.Add(string.Format($"{item.Key}, {item.Value}"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

            }
        }
    }
}
