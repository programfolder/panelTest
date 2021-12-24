using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panelTest
{
    public partial class Form1 : Form
    {
        public List<Button> list = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                button.Click += Button_Click;
                button.Location = new Point(20,50 + i*20);
                button.Size = new Size(100, 20);
                button.Text = "click" + @"  " + i.ToString();
                button.Name = i.ToString();
                list.Add(button);

            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int clickednumber = int.Parse(btn.Name);
                 if(list.All(item => item.Visible == true))
                 {
                    for (int i = 0; i < 5; i++)
                    {
                             if (i != clickednumber)
                             {
                                    list[i].Visible = false;
                             }
                              else if (i == clickednumber)
                              list[clickednumber].Location = new Point(20, 50);
                    }
                 }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        list[i].Location = new Point(20, 50 + i * 20);
                        list[i].Visible = true;
                    }

                }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("it is me");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5};            
            list.Remove( list.Count );
            list.ForEach(item => MessageBox.Show(item.ToString()));
        }
    }
}
