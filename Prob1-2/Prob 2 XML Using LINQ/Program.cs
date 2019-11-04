/*
Author: Daniel Davidson
Date: 10/19/2019
CTEC 135: Microsoft Software Development with C#
    Module 6, Programming Assignment 5, Problem 2
    
    
    XML Using LINQ
    The Main() method should call the methods described below. 
    See appendix B.

    * Create a static method that creates an XML document and saves it. 
      See pages 3 and 10 in Appendix B
    * Create a static method that creates an XML document from an array
      and saves it. See page 12 in Appendix B
    * Create a static method that loads an XML document and prints it 
      to the screen. You can load the doc created in 2 above. 
    * See page  13 in Appendix B. Note that all I am asking for is 
      for you to load the document and print. You can ignore the parsing
      part of the book's example code.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Linq;

namespace Prob_2_XML_Using_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling methods from main
            BuildXMLDocForBand();
            MakeXElementFromArray();
            LoadXML();
        }

        #region 1 Creates XML doc and saves it
        public static void BuildXMLDocForBand()
        {
            XElement doc =
                new XElement("Genre",
                    new XElement("Rock",
                    new XAttribute("Style", "Heavy"),
                    new XElement("Band", "Slipknot"),
                    new XElement("Album", "Iowa"),
                    new XElement("Company", "RoadRunner Records")
                    )
                    );

            // Save to file
            doc.Save("GenreWithLinq.xml");
        }
        #endregion

        #region 2 Create a static method that creates an XML 
        // document from an array and saves it.
        static void MakeXElementFromArray()
        {
            // Creating an array to be saved to XML doc
            
             var bands = new[]
            {
                new {BandName = "Slipknot", Year = "14"},
                new {BandName = "Metallica", Year = "38"},
                new {BandName = "Killswitch Engage", Year = "20"},
                new {BandName = "Slayer", Year = "38"}
            };
            /*
            XElement bandsDoc =
                new XElement("bands",
                from m in bands
                select new XElement("bands", new XAttribute("Year", m.Year),
                new XElement("BandName", m.BandName))
                );
            Console.WriteLine(bandDoc);
            */

            // Link query using explicit steps
            var arrayDataAsXElements = from m in bands
                                       select
                                       new XElement("band",
                                       new XAttribute("Year", m.Year),
                                       new XElement("BandName", m.BandName));
            XElement bandsDoc = new XElement("Bands", arrayDataAsXElements);
            Console.WriteLine(bandsDoc);

        }


        #endregion

        #region 3 
       
        // Loading and Parsing XML Content
        static void LoadXML()
        {
            Console.WriteLine("Loaded");
            // Load XML File. 
            XDocument bandsDoc = XDocument.Load("bands.xml");
            Console.WriteLine(bandsDoc);

        }
        #endregion

    }
}
