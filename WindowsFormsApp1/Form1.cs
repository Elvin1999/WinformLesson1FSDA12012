using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region SimpleEvent Timer
        //Timer timer = new Timer();
        //public Form1()
        //{
        //    InitializeComponent();
        //    timer.Tick += Timer_Tick;
        //    timer.Interval = 500;
        //    timer.Start();
        //}

        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    this.Text = DateTime.Now.ToLongTimeString();
        //}
        #endregion

        #region Work with controls
        public Form1()
        {
            InitializeComponent();
            AddControls();
        }

        private void AddControls()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(50, 150);
            label.Text = "I am new label";
            label.Font = new Font("Comic Sans MS", 30, FontStyle.Italic);

            this.Controls.Add(label);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.BackColor = Color.Yellow;
            }
            else if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.Red;
            }
            //string message = String.Empty;

            //message = $"X : {e.X}  Y : {e.Y}";
            //if (e.Button == MouseButtons.Right)
            //{
            //    message += "\nYou clicked the right mouse button . ";
            //}
            //else if (e.Button == MouseButtons.Left)
            //{
            //    message += "\nYou clicked the left mouse button . ";
            //}


            //MessageBox.Show(message);
        }


        private void Form1_MouseLeave(object sender, EventArgs e)
        {
           // mylabel.Text = "You left";
            mylabel.ForeColor = Color.Black;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            //mylabel.Text = "You entered";
            mylabel.ForeColor = Color.SpringGreen;
        }
        #endregion
        public bool HasClicked { get; set; }
        private void clickBtn_Click(object sender, EventArgs e)
        {

            //if (HasClicked)
            //{
            //    mylabel.Text = "Salam Dunya";
            //    HasClicked = false;
            //}
            //else
            //{
            //    mylabel.Text = "Hello World";
            //    HasClicked = true;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.mario;

            if(sender is Button bt)
            {
                bt.Dispose();

                Button button = new Button();
                button.Size = new Size(140, 50);
                Random random = new Random();
                int randomX = random.Next(this.Size.Width - 100);
                int randomY = random.Next(this.Size.Height - 100);

                button.Location = new Point(randomX, randomY);
                button.Text = "CLICK ME";
                button.Click += button1_Click;
                this.Controls.Add(button);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
