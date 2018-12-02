using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;



namespace myCircleApp
{

    public partial class CircleMakerForm : Form
    {

        

        string xmlURL = Directory.GetCurrentDirectory() + "\\configureCircle.xml";
        //string xmlURL = "C:\\Users\\Admin\\source\\repos\\CircleFormsApp\\myCircleApp\\myCircleApp\\configureCircle.xml";
        

   

        public CircleMakerForm()
        {
            InitializeComponent();
        }

        public void createCircle_Click_1(object sender, EventArgs e)
        {

            


            

}


 ///////////////// Erases the circle when button is clicked by using the 'Clear()' method and setting the graphics background to white ///////////
 
        private void eraseCircle_Click(object sender, EventArgs e)
        {
            Graphics soonToNotBCircle = this.CreateGraphics();
            soonToNotBCircle.Clear(Color.White);
        }

 
        private void ComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
