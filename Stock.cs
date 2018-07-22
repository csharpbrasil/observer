using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public abstract class Stock
    {
        private string m_symbol;
        private double m_price;
        private List<IInvestor> m_investors = new List<IInvestor>();

        public Stock(string symbol, double price)
        {
            this.m_symbol = symbol;
            this.m_price = price;
        }

        public void Attach(IInvestor investor)
        {
            m_investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            m_investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (IInvestor investor in m_investors)
                investor.Update(this);
        }

        public double Price
        {
            get { return m_price; }
            set
            {
                if (m_price != value)
                {
                    m_price = value;
                    Notify();
                }
            }
        }

        public string Symbol
        {
            get { return m_symbol; }
        }
    }
}
