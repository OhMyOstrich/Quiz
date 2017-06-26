using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz.Forms {
    public partial class PasswordForm : Form {
        public PasswordForm() {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e) {
            byte[] hash;
            using (SHA512 sha = SHA512.Create()) {

                hash = sha.ComputeHash(Encoding.UTF8.GetBytes(textBox1.Text));
                string x = string.Empty;
                foreach (var y in hash) {
                    x += y;
                }

                if (x == GlobalVariables.pass) {
                    Console.WriteLine("textbox " + sha.ComputeHash(Encoding.UTF8.GetBytes(textBox1.Text)).ToString());
                    Console.WriteLine("Stuff.pass " + GlobalVariables.pass);
                    this.Hide();
                    CreateQuizForm form = new CreateQuizForm();
                    form.FormClosed += (s, args) => this.Close();
                    form.Show();
                } else {
                    MessageBox.Show("Password incorrect", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}