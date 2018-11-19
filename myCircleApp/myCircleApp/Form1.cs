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
        int myTestWidth;
        int myTestSize;
        string myTestColour;
        XmlDocument doc = new XmlDocument();
        string xmlURL = "C:\\Users\\Admin\\source\\repos\\CircleFormsApp\\myCircleApp\\myCircleApp\\configureCircle.xml";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void createCircle_Click_1(object sender, EventArgs e)
        {


            ////////// creates and writes xml file using whatever is currently selected in the combo boxes /////////////////////////////////////
            try
            {
                XmlTextWriter defineCircle = new XmlTextWriter(xmlURL, Encoding.UTF8);
                defineCircle.Formatting = Formatting.Indented;
                defineCircle.WriteStartElement("CircleSpecs");
                defineCircle.WriteStartElement("CircleColour");
                defineCircle.WriteString(comboBox1.Text);
                defineCircle.WriteEndElement();
                defineCircle.WriteStartElement("CircleSize");
                defineCircle.WriteString(comboBox2.Text);
                defineCircle.WriteEndElement();
                defineCircle.WriteStartElement("BorderWidth");
                defineCircle.WriteString(comboBox3.Text);
                defineCircle.WriteEndElement();
                defineCircle.WriteEndElement();
                defineCircle.Close();
            }
            catch (Exception) {
                MessageBox.Show("Unable to Create XML File! Ensure that the 'xmlURL' string value in Form1.cs is referencing a valid URL. ");
            }

            ///////////////////////////////the code below loads and reads the xml file we just created /////////////////////////////////

            try
            {
                /////////////////////load the xml file..///////////////
                doc.Load(xmlURL);

                ///////////////////////////////////  reads the Colour node ///////////////////////////////////////////////
                XmlNode myCircleColour = doc.SelectSingleNode("/CircleSpecs/CircleColour");
                myTestColour = myCircleColour.InnerText;


                ///////////////////////////////////  reads the size node ///////////////////////////////////////////////
                XmlNode myCircleSize = doc.SelectSingleNode("/CircleSpecs/CircleSize");
                myTestSize = Convert.ToInt32(myCircleSize.InnerText);

                ///////////////////////////////////  reads the borderWidth node ///////////////////////////////////////////////
                XmlNode myCircleBorderWidth = doc.SelectSingleNode("/CircleSpecs/BorderWidth");
                myTestWidth = Convert.ToInt32(myCircleBorderWidth.InnerText);

                /*
                MessageBox.Show(myTestColour + myTestSize + myTestWidth);
                */

            }
            catch (Exception)
            {
                MessageBox.Show("Unable to load XML File! Ensure that the 'xmlURL' string value in Form1.cs is referencing a valid URL.");
            }


            try
            { 

            //////////////////// create circle using xml node names from above as parameters //////////////////
            Graphics soonToBCircle = this.CreateGraphics();

            ///// clears the screen in case there's already a circle.....//////////////
            soonToBCircle.Clear(Color.White);

            ///////// Make a pen to draw the circle ///////////////////////////
            Pen myPen = new Pen(Color.FromName(myTestColour), myTestWidth);
            
            //////////////// draws the circle /////////////////////
            soonToBCircle.DrawEllipse(myPen,50,25,myTestSize,myTestSize);

            }
            catch (Exception)
            {
                MessageBox.Show("Can't draw circle now.");
            }



}



        private void eraseCircle_Click(object sender, EventArgs e)
        {
            Graphics soonToNotBCircle = this.CreateGraphics();
            soonToNotBCircle.Clear(Color.White);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
