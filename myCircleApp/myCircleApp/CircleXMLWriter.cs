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
  
        public class CircleXMLWriter
        {
        
        int myTestWidth;
        int myTestSize;
        string myTestColour;
        XmlDocument doc = new XmlDocument();
        string xmlURL = "C:\\Users\\Admin\\source\\repos\\CircleFormsApp\\myCircleApp\\myCircleApp\\configureCircle.xml";
        
            public static void WriteCircleToXML(string EnterXMLPath)
            {
            int myTestWidth;
            int myTestSize;
            string myTestColour;
            XmlDocument doc = new XmlDocument();

            try
            {
                XmlTextWriter defineCircle = new XmlTextWriter(EnterXMLPath, Encoding.UTF8);
                defineCircle.Formatting = Formatting.Indented;
                defineCircle.WriteStartElement("CircleSpecs");
                defineCircle.WriteStartElement("CircleColour");
                defineCircle.WriteString(CircleMakerForm.ColourComboBox.Text);
                defineCircle.WriteEndElement();
                defineCircle.WriteStartElement("CircleSize");
                defineCircle.WriteString(CircleSizeBox.Text);
                defineCircle.WriteEndElement();
                defineCircle.WriteStartElement("BorderWidth");
                defineCircle.WriteString(BorderWidthBox.Text);
                defineCircle.WriteEndElement();
                defineCircle.WriteEndElement();
                defineCircle.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to Create XML File! Ensure that the 'xmlURL' string value in CircleMakerForm.cs is referencing a valid URL. ");
            }

            ///////////////////////////////the code below loads and reads the xml file we just created /////////////////////////////////

            try
            {
                /////////////////////load the xml file..///////////////
                doc.Load(xmlURL);

                /////////////////////////////////// selects and reads the Colour node ///////////////////////////////////////////////
                XmlNode myCircleColour = doc.SelectSingleNode("/CircleSpecs/CircleColour");
                myTestColour = myCircleColour.InnerText;


                /////////////////////////////////// selects and reads the size node ///////////////////////////////////////////////
                XmlNode myCircleSize = doc.SelectSingleNode("/CircleSpecs/CircleSize");
                myTestSize = Convert.ToInt32(myCircleSize.InnerText);

                ///////////////////////////////////  selects and reads the borderWidth node ///////////////////////////////////////////////
                XmlNode myCircleBorderWidth = doc.SelectSingleNode("/CircleSpecs/BorderWidth");
                myTestWidth = Convert.ToInt32(myCircleBorderWidth.InnerText);


                MessageBox.Show("Colour: " + myTestColour + "\n" + "Size: " + myTestSize + "\n" + "Border Width: " + myTestWidth);


            }
            catch (Exception)
            {
                MessageBox.Show("Unable to load XML File! Ensure that the 'xmlURL' string value in CircleMakerForm.cs is referencing a valid URL.");
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
                soonToBCircle.DrawEllipse(myPen, 50, 25, myTestSize, myTestSize);

            }
            catch (Exception)
            {
                MessageBox.Show("Can't draw circle now.");
            }

        }


    }

}
