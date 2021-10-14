using Gyakorlas_1.Mappa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyakorlas_1
{
    public partial class Form1 : Form
    {
        List<OlympicResult> results = new List<OlympicResult>();

        public Form1()
        {
            InitializeComponent();

            Fuggveny("Summer_olympic_Medals.csv");
            Feltoltes();
        }

        private void Fuggveny(string fajlnev)
        {
            
            using (var reader = new StreamReader(fajlnev))
            {
                bool flag = false;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (flag) {
                        
                        var values = line.Split(',');
                        OlympicResult or = new OlympicResult();
                        or.Country = values[3];
                        or.Year = Int32.Parse(values[0]);

                        or.Medals = new int[] { Convert.ToInt32(values[5]), Convert.ToInt32(values[6]), Convert.ToInt32(values[7]) };


                        results.Add(or);
                    }
                    else
                    {
                        flag = true;
                    }
                    
                }
            }
        }

        private void Feltoltes()
        {
            var year = (from x in results
                       orderby x.Year
                       select x.Year).Distinct().ToList();
            comboBox1.DataSource = year;
        }

        private void Helyezes(OlympicResult or)
        {

        }
    }
}
