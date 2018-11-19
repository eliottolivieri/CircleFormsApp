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



namespace myCircleApp
{

    

    public partial class Form1 : Form
    {

        public int borderWidth;
        public int circleRadius;
        public int circleColour;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void createCircle_Click_1(object sender, EventArgs e)
        {


        
     
         ///// the code below creates and writes xml file /////////////////////////////////////

            XmlTextWriter defineCircle = new XmlTextWriter("C: \\Users\\Admin\\source\\repos\\myCircleApp\\myCircleApp\\configureCircle.xml", Encoding.UTF8 );
            defineCircle.Formatting = Formatting.Indented;
            defineCircle.WriteStartElement("CircleSpecs");  
            defineCircle.WriteStartElement("CircleColour");
            defineCircle.WriteString(textBox3.Text);
            defineCircle.WriteEndElement();
            defineCircle.WriteStartElement("CircleSize");
            defineCircle.WriteString(textBox1.Text);
            defineCircle.WriteEndElement();
            defineCircle.WriteStartElement("BorderWidth");
            defineCircle.WriteString(textBox2.Text);
            defineCircle.WriteEndElement();
            defineCircle.WriteEndElement();
            defineCircle.Close();

            /////////////////////the code below reads from the xml file we just created /////////////////////////////////

            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\Admin\\source\\repos\\myCircleApp\\myCircleApp\\configureCircle.xml");


            ///////////////////////////////////  reads the Colour ///////////////////////////////////////////////
            XmlNode myCircleColour = doc.SelectSingleNode("/CircleSpecs/CircleColour");
            string myTestColour = myCircleColour.InnerText;
      
            ///////////////////////////////////  reads the size ///////////////////////////////////////////////
            XmlNode myCircleSize = doc.SelectSingleNode("/CircleSpecs/CircleSize");
            int myTestSize = Convert.ToInt32(myCircleSize.InnerText);

            ///////////////////////////////////  reads the border width ///////////////////////////////////////////////
            XmlNode myCircleBorderWidth = doc.SelectSingleNode("/CircleSpecs/BorderWidth");
            int myTestWidth = Convert.ToInt32(myCircleBorderWidth.InnerText);


            //////////////////// the code below creates a circle for real ////////////////////////////////////////////   

            Graphics soonToBCircle = this.CreateGraphics();
            // Make a red pen.
            Pen myPen = new Pen(Color.FromName(myTestColour), myTestWidth);
            
            soonToBCircle.DrawEllipse(myPen,50,50,myTestSize,myTestSize);

            /*
            MessageBox.Show(myTestColour + myTestSize + myTestWidth);
            */
        }

        private void eraseCircle_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
