using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using geronimo;
namespace Frontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnumerar_Click(object sender, EventArgs e)
        {
            DeviceEnumerator enumerator = new DeviceEnumerator();
            labelNumberOfPlatforms.Text = enumerator.GetNumberOfPlaforms().ToString();
        }
    }
}
