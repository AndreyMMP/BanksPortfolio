using BanksPortfolio.App.ViewModels;
using BanksPortfolio.Business.Factories;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;

namespace BanksPortfolio.App
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count <= 0)
            {
                MessageBox.Show("Your portfolio is Empty.");
            }
            else
            {
                List<string> categories = new List<string>();
                foreach (var item in listBox2.Items)
                {
                    listBox1.Items.Add(item);                                        
                    TradeInformation trade = new TradeInformation(item.ToString());
                    categories.Add(TradeFactory.Create(trade.Value, trade.ClientSector).GetTradeCategory());                    
                }
                listBox2.Items.Clear();
                textBox1.Text = JsonSerializer.Serialize(categories);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string curItem = listBox1.SelectedItem.ToString();
                TradeInformation trade = new TradeInformation(curItem);
                label7.Text = trade.Value.ToString();
                label8.Text = trade.ClientSector;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Select a Trade First!");
            }
            else
            {
                string curItem = listBox1.SelectedItem.ToString();
                var selectedIndex = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(selectedIndex);
                label7.Text = "";
                label8.Text = "";
                listBox2.Items.Add(curItem);
            }
        }
    }
}
