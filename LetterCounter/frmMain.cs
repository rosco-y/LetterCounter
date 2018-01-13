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
                    MessageBox.Show($"Test: {counter.Success}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

            }
        }
    }
}
