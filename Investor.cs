using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Investor : IInvestor
    {
        private string m_name;
        private Stock m_stock;

        public Investor(string name)
        {
            this.m_name = name;
        }

        public void Update(Stock stock)
        {
            MessageBox.Show("Notificação: (" + m_name + ") de " + 
                             stock.Symbol + ".O preço foi alterado para " +
                             stock.Price.ToString("0.00"));
        }

        public Stock Stock
        {
            get { return m_stock; }
            set { m_stock = value; }
        }
    }
}
