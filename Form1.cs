using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Fruit_Mart
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            apple_comboBox.Enabled = false;
            apple_numericUpDown.Controls[0].Visible = false;
            orange_comboBox.Enabled = false;
            orange_numericUpDown.Controls[0].Visible = false;
            mango_comboBox.Enabled = false;
            mango_numericUpDown3.Controls[0].Visible = false;
            pineapple_comboBox.Enabled = false;
            peach_numericUpDown.Controls[0].Visible = false;
            peach_comboBox.Enabled = false;
            pineapple_numericUpDown.Controls[0].Visible = false;
            strawberry_comboBox.Enabled = false;
            strawbery_numericUpDown.Controls[0].Visible = false;

        } 
        short itemNumber=0;
        private int apple,orange,mango,pineapple,peach,strawberry,bag=0;


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void apple_check_CheckedChanged(object sender, EventArgs e)
        {
            if(!apple_check.Checked)
            {
                fruit_item.Text = "";
                label27.Text = "";
                label20.Text = "";
                label14.Text = "";
                apple = 0;
                itemNumber--;
                apple_comboBox.Enabled = false;
                apple_numericUpDown.Controls[0].Visible = false;

            }
            else
            {
                itemNumber++;
                fruit_item.Text = "Apple";
                label14.Text = apple_numericUpDown.Value.ToString() + (" kg");
                apple_numericUpDown.Controls[0].Visible = true;
                apple_comboBox.Enabled = true;
            }
        }

        private void orange_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            label15.Text = orange_numericUpDown.Value.ToString() + (" kg");
            if (orange_comboBox.SelectedItem == "    VIP          Rs:300")
            {
                int weight = Int32.Parse(orange_numericUpDown.Value.ToString());

                label21.Text = (weight * 300).ToString();
                orange =  (weight * 300);
                label28.Text = DateTime.Now.ToString("h:mm:ss tt");

            }
            else if (orange_comboBox.SelectedItem == "   Normal     Rs:200")
            {
                int weight = Int32.Parse(orange_numericUpDown.Value.ToString());

                label21.Text = (weight * 200).ToString();
                orange=(weight * 200);
                label28.Text = DateTime.Now.ToString("h:mm:ss tt");
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void apple_numericUpDown_ValueChanged(object sender, EventArgs e)
        {  
            label14.Text = apple_numericUpDown.Value.ToString()+(" kg");
            if (apple_comboBox.SelectedItem == "    VIP          Rs:200")
            {
                int weight = Int32.Parse(apple_numericUpDown.Value.ToString());

                label20.Text = (weight * 200).ToString();
                apple  =(weight * 200);
                label27.Text = DateTime.Now.ToString("h:mm:ss tt");

            }
            else if(apple_comboBox.SelectedItem == "   Normal     Rs:150")
            {
                int weight = Int32.Parse(apple_numericUpDown.Value.ToString());
                label20.Text = (weight * 150).ToString();
                apple = (weight * 150);
                label27.Text = DateTime.Now.ToString("h:mm:ss tt");
            }
        }

        private void apple_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var;
            var = apple_comboBox.SelectedItem.ToString();
            if (apple_comboBox.SelectedItem == "    VIP          Rs:200")
            {
                int weight = Int32.Parse(apple_numericUpDown.Value.ToString());

                label20.Text = (weight * 200).ToString();
                apple = (weight * 200);
                label27.Text = DateTime.Now.ToString("h:mm:ss tt");

            }
            else if (apple_comboBox.SelectedItem == "   Normal     Rs:150")
            {
                int weight = Int32.Parse(apple_numericUpDown.Value.ToString());
                label20.Text = (weight * 150).ToString();
                apple = (weight * 150);
                label27.Text = DateTime.Now.ToString("h:mm:ss tt");
            }

        }

        private void orange_check_CheckedChanged(object sender, EventArgs e)
        {

            if (!orange_check.Checked)
            {
                label9.Text = "";
                label15.Text = "";
                label21.Text = "";
                label28.Text = "";
                orange = 0;
                itemNumber--;
                orange_comboBox.Enabled = false;
                orange_numericUpDown.Controls[0].Visible = false;

            }
            else
            {
                itemNumber++;
                label9.Text = "Orange";
                label15.Text = apple_numericUpDown.Value.ToString() + (" kg");
                orange_numericUpDown.Controls[0].Visible = true;
                orange_comboBox.Enabled = true;
            }
        }

        private void orange_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var;
            var = orange_comboBox.SelectedItem.ToString();
            if (orange_comboBox.SelectedItem == "    VIP          Rs:300")
            {
                int weight = Int32.Parse(orange_numericUpDown.Value.ToString());

                label21.Text = (weight * 300).ToString();
                orange= (weight * 300);
                label28.Text = DateTime.Now.ToString("h:mm:ss tt");

            }
            else if (orange_comboBox.SelectedItem == "   Normal     Rs:200")
            {
                int weight = Int32.Parse(orange_numericUpDown.Value.ToString());

                label21.Text = (weight * 200).ToString();
                orange = (weight * 200);
                label28.Text = DateTime.Now.ToString("h:mm:ss tt");
            }
        }

        private void mango_check_CheckedChanged(object sender, EventArgs e)
        {
            if (!mango_check.Checked)
            {
                label10.Text = "";
                label29.Text = "";
                label22.Text = "";
                label16.Text = "";
                mango = 0;
                itemNumber--;
                mango_comboBox.Enabled = false;
                mango_numericUpDown3.Controls[0].Visible = false;

            }
            else
            {
                itemNumber++;
                label10.Text = "Mango";
                label16.Text = mango_numericUpDown3.Value.ToString() + (" kg");
               mango_numericUpDown3.Controls[0].Visible = true;
               mango_comboBox.Enabled = true;
            }
        }

        private void peach_check_CheckedChanged(object sender, EventArgs e)
        {
            if (!pineapple_check.Checked)
            {
                label11.Text = "";
                label30.Text = "";
                label23.Text = "";
                label17.Text = "";
                pineapple = 0;
                itemNumber--;
                pineapple_comboBox.Enabled = false;
                pineapple_numericUpDown.Controls[0].Visible = false;

            }
            else
            {
                itemNumber ++;
                label11.Text = "Pineapple";
                label17.Text = pineapple_numericUpDown.Value.ToString() + (" kg");
                pineapple_numericUpDown.Controls[0].Visible = true;
                pineapple_comboBox.Enabled = true;
            }
        }

        private void pineapple_check_CheckedChanged(object sender, EventArgs e)
        {
            if (!peach_check.Checked)
            {
                label12.Text = "";
                label31.Text = "";
                label24.Text = "";
                label18.Text = "";
                peach = 0;
                itemNumber--;
                peach_comboBox.Enabled = false;
                peach_numericUpDown.Controls[0].Visible = false;

            }
            else
            {
                label12.Text = "Peach";
                itemNumber++;
                label18.Text = peach_numericUpDown.Value.ToString() + (" kg");
                peach_numericUpDown.Controls[0].Visible = true;
                peach_comboBox.Enabled = true;
            }
        }

        private void strawberry_check_CheckedChanged(object sender, EventArgs e)
        {
            if (!strawberry_check.Checked)
            {
                label13.Text = "";
                label32.Text = "";
                label25.Text = "";
                label19.Text = "";
                itemNumber--;
                strawberry= 0;
                strawberry_comboBox.Enabled = false;
                strawbery_numericUpDown.Controls[0].Visible = false;

            }
            else
            {
                label13.Text = "Strawberry";
                itemNumber++;
                label19.Text = strawbery_numericUpDown.Value.ToString() + (" kg");
                strawbery_numericUpDown.Controls[0].Visible = true;
                strawberry_comboBox.Enabled = true;
            }
        }

        private void mango_numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            label16.Text = mango_numericUpDown3.Value.ToString() + (" kg");
            if (mango_comboBox.SelectedItem == "    VIP          Rs:150")
            {
                int weight = Int32.Parse(mango_numericUpDown3.Value.ToString());

                label22.Text = (weight * 150).ToString();
                mango = (weight * 150);
                label29.Text = DateTime.Now.ToString("h:mm:ss tt");

            }
            else if (mango_comboBox.SelectedItem == "   Normal     Rs:120")
            {
                int weight = Int32.Parse(mango_numericUpDown3.Value.ToString());
                label22.Text = (weight * 120).ToString();
                mango = (weight * 120);
                label29.Text = DateTime.Now.ToString("h:mm:ss tt");
            }
        }

        private void peach_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            label17.Text = pineapple_numericUpDown.Value.ToString() + (" kg");
            if (pineapple_comboBox.SelectedItem == "    VIP          Rs:1000")
            {
                int weight = Int32.Parse(pineapple_numericUpDown.Value.ToString());

                label23.Text = (weight * 1000).ToString();
                pineapple = (weight * 1000);
                label30.Text = DateTime.Now.ToString("h:mm:ss tt");

            }
            else if (pineapple_comboBox.SelectedItem == "   Normal     Rs:800")
            {
                int weight = Int32.Parse(pineapple_numericUpDown.Value.ToString());
                label23.Text = (weight * 800).ToString();
                pineapple = (weight * 800);
                label30.Text = DateTime.Now.ToString("h:mm:ss tt");
            }
        }

        private void pineapple_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            label18.Text = peach_numericUpDown.Value.ToString() + (" kg");
            if (peach_comboBox.SelectedItem == "    VIP          Rs:250")
            {
                int weight = Int32.Parse(peach_numericUpDown.Value.ToString());

                label24.Text = (weight * 250).ToString();
                peach = (weight * 250);
                label31.Text = DateTime.Now.ToString("h:mm:ss tt");

            }
            else if (pineapple_comboBox.SelectedItem == "   Normal     Rs:200")
            {
                int weight = Int32.Parse(peach_numericUpDown.Value.ToString());
                label24.Text = (weight * 200).ToString();
                peach = (weight * 200);
                label31.Text = DateTime.Now.ToString("h:mm:ss tt");
            }
        }

        private void strawbery_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            label19.Text = strawbery_numericUpDown.Value.ToString() + (" kg");
            if (strawberry_comboBox.SelectedItem == "    VIP          Rs:90")
            {
                int weight = Int32.Parse(strawbery_numericUpDown.Value.ToString());

                label25.Text = (weight * 90).ToString();
                strawberry =(weight * 90);
                label32.Text = DateTime.Now.ToString("h:mm:ss tt");

            }
            else if (strawberry_comboBox.SelectedItem == "   Normal     Rs:60")
            {
                int weight = Int32.Parse(strawbery_numericUpDown.Value.ToString());

                label25.Text = (weight * 60).ToString();
                strawberry=  (weight * 60);
                label32.Text = DateTime.Now.ToString("h:mm:ss tt");
            }
        }

        private void no_bag_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(no_bag_radioButton.Checked)
            {
                bag = 0;
            }
        }

        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //  Bitmap bmp = new Bitmap(groupBox1.ClientRectangle.Width, groupBox1.ClientRectangle.Height);
            //  groupBox1.DrawToBitmap(bmp, groupBox1.ClientRectangle);
            //  e.Graphics.DrawImage(bmp, 0, 0);

            Bitmap bmp = new Bitmap(groupBox1.Width, groupBox1.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            groupBox1.DrawToBitmap(bmp, new Rectangle(0, 0, groupBox1.Width, groupBox1.Height));
            e.Graphics.DrawImage((Image)bmp, 0, 0);
        }

        private void genrate_button_Click(object sender, EventArgs e)
        {
            if(itemNumber != 0)
            {
                PrintPreviewDialog ppd = new PrintPreviewDialog();
                PrintDocument Pd = new PrintDocument();

                Pd.PrintPage += this.printDocument1_PrintPage;
                ppd.Document = Pd;
                ppd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select any Item to print Bill");
             }
            
        }
        private void mango_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var;
            var = mango_comboBox.SelectedItem.ToString();
            if (mango_comboBox.SelectedItem == "    VIP          Rs:150")
            {
                int weight = Int32.Parse(mango_numericUpDown3.Value.ToString());

                label22.Text = (weight * 200).ToString();
              mango =(weight * 150);
                label29.Text = DateTime.Now.ToString("h:mm:ss tt");
             
            }
            else if(mango_comboBox.SelectedItem == "   Normal     Rs:120")
            {
                int weight = Int32.Parse(mango_numericUpDown3.Value.ToString());

                label22.Text = (weight * 120).ToString();
                mango =(weight * 120);
                label29.Text = DateTime.Now.ToString("h:mm:ss tt");
            }

        }

        private void peach_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (peach_comboBox.SelectedItem == "    VIP          Rs:250")
            {
                int weight = Int32.Parse(peach_numericUpDown.Value.ToString());

                label24.Text = (weight * 250).ToString();
                peach = (weight * 250);
                label31.Text = DateTime.Now.ToString("h:mm:ss tt");

            }
            else if (pineapple_comboBox.SelectedItem == "   Normal     Rs:200")
            {
                int weight = Int32.Parse(peach_numericUpDown.Value.ToString());
                label24.Text = (weight * 200).ToString();
                peach = (weight * 200);
                label31.Text = DateTime.Now.ToString("h:mm:ss tt");
            }


        }

        private void pineapple_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pineapple_comboBox.SelectedItem == "    VIP          Rs:1000")
            {
                int weight = Int32.Parse(pineapple_numericUpDown.Value.ToString());

                label23.Text = (weight * 1000).ToString();
                pineapple = (weight * 1000);
                label30.Text = DateTime.Now.ToString("h:mm:ss tt");

            }
            else if (pineapple_comboBox.SelectedItem == "   Normal     Rs:800")
            {
                int weight = Int32.Parse(pineapple_numericUpDown.Value.ToString());
                label23.Text = (weight * 800).ToString();
                pineapple = (weight * 800);
                label30.Text = DateTime.Now.ToString("h:mm:ss tt");
            }

        }

        private void strawberry_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var;
            var = strawberry_comboBox.SelectedItem.ToString();
            if (strawberry_comboBox.SelectedItem == "    VIP          Rs:90")
            {
                int weight = Int32.Parse(strawbery_numericUpDown.Value.ToString());

                label25.Text = (weight * 90).ToString();
                strawberry= (weight * 90);
                label32.Text = DateTime.Now.ToString("h:mm:ss tt");

            }
            else if (strawberry_comboBox.SelectedItem == "   Normal     Rs:60")
            {
                int weight = Int32.Parse(strawbery_numericUpDown.Value.ToString());

                label25.Text = (weight * 60).ToString();
                strawberry = (weight * 60);
                
                label32.Text = DateTime.Now.ToString("h:mm:ss tt");
            }

        }

        private void yes_radio_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(yes_radio_radioButton.Checked)
            {
                bag = 20;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            int totalbill = apple + orange + mango + pineapple + peach + strawberry + bag;
            Total_item.Text = itemNumber.ToString();
            total_bill.Text = "Rs:" + totalbill.ToString() + "/=";
        }
    }
}
