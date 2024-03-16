using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LopushokModule
{
    public partial class UserControl1 : UserControl
    {
        string title;
        string articleNumber;
        string? imagePath;
        decimal price;
        string type;

        public UserControl1(string title, string articleNumber, string? imagePath, decimal price, string type)
        {
            InitializeComponent();
            this.title = title;
            this.articleNumber = articleNumber;
            this.imagePath = FilePicker.GetPic(imagePath);
            this.price = price;
            this.type = type;

            label1.Text = type;
            label3.Text = title;
            label4.Text = articleNumber;
            label5.Text = Convert.ToString(price) + " Р";
        }
        public void setPic()
        {
            try
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                imagePath = FilePicker.GetPic("");
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
