using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IBM ibm = new IBM("IBM", 100.00);
            ibm.Attach(new Investor("Acionista A"));
            ibm.Attach(new Investor("Acionista B"));
            /* depois de ter realizado o Attach, 
               a cada vez que atribuir um novo preço para ibm,
               cada um dos investidores será notificado.
             */
            ibm.Price = 200.10;
            ibm.Price = 500.00;

            this.Close();
        }
    }
}
