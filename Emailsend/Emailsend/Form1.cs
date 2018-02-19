using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Emailsend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
{
    MailMessage message = new MailMessage();
    SmtpClient smtp = new SmtpClient();

    message.From = new MailAddress(textBox2.Text);
    message.To.Add(new MailAddress(textBox1.Text));
    message.Subject = textBox3.Text;
    message.Body = richTextBox1.Text;
    /*message.From = new MailAddress("socket1socket@gmail.com");
    message.To.Add(new MailAddress("socket02socket@gmail.com"));
    message.Subject = "Test";
    message.Body = "Content";*/

    smtp.Port = 587;
    smtp.Host = "smtp.gmail.com";
    smtp.EnableSsl = true;
    smtp.UseDefaultCredentials = false;
    smtp.Credentials = new NetworkCredential(textBox1.Text, textBox4.Text);
    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
    smtp.Send(message);
}
catch (Exception ex)
{
    MessageBox.Show("err: " + ex.Message);
}
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
