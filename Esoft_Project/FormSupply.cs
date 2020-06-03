using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowRealEstate();
            ShowSupplySet();
        }

        void ShowAgents()
        {
            //очищаем comboBox
            comboBoxAgents.Items.Clear();
            foreach (AgentsSet agentsSet in Program.epDb.AgentsSet)
            {
                //добавляем информацию, которую хотим увидеть в строке comboBox-а
                //можно настроить по своему усмотрению, добавить/удалить некоторые элементы и сокращения
                //главное, не убирать Id, так как он нужен для дальнейшей работы
                string[] item = { agentsSet.Id.ToString() + ".", agentsSet.FirstName, agentsSet.LastName };
                comboBoxAgents.Items.Add(string.Join(" ", item));
            }
        }

        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.epDb.ClientsSet)
            {

                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName };
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }

        void ShowRealEstate()
        {
            comboBoxRealEstate.Items.Clear();
            foreach (RealEstateSet realEstateSet in Program.epDb.RealEstateSet)
            {

                string[] item = { realEstateSet.Id.ToString() + ".", realEstateSet.Address_City + ",",realEstateSet.Address_Street + ",",
                    "д.", realEstateSet.Address_House +",","кв."+realEstateSet.Address_Number };
                comboBoxRealEstate.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //проверяем, все ли поля заполнены
            if (comboBoxAgents.SelectedItem != null && comboBoxClients != null && comboBoxRealEstate != null && textBoxPrice.Text != "")
            {
                //создаём новый экземпляр класса предложение
                SupplySet supply = new SupplySet();
                //из выбранных строк в comboBox-ах отделяем Id риелтора( он отделён точкой) и делаем ссылку в supply.IdAgent
                supply.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                //отделяем и заносим Id объекта недвижимости
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                //цена объекта недвижимости чаще всего превосходит миллион, поэтому исп. Int64
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.epDb.SupplySet.Add(supply);
                Program.epDb.SaveChanges();
                ShowSupplySet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void ShowSupplySet()
        {
            //очищаем все listView
            listViewSupplySet.Items.Clear();
            foreach (SupplySet supply in Program.epDb.SupplySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    //Id риелтора
                    supply.IdAgent.ToString(),
                    //ФИО риелтора
                    supply.AgentsSet.LastName+" "+supply.AgentsSet.FirstName+" "+supply.AgentsSet.MiddleName,
                    //Id клиента
                    supply.IdClient.ToString(),
                    //ФИО клиента
                    supply.ClientsSet.LastName+" "+supply.ClientsSet.FirstName+" "+supply.ClientsSet.MiddleName,
                    //Id объекта недвижимости
                    supply.IdRealEstate.ToString(),
                    //адрес объекта недвижимости
                    "г."+supply.RealEstateSet.Address_City+", ул. "+supply.RealEstateSet.Address_Street+", д. "+
                    supply.RealEstateSet.Address_House+", кв. "+supply.RealEstateSet.Address_Number,
                    //цена
                    supply.Price.ToString()+"р"
                });
                item.Tag = supply;
                listViewSupplySet.Items.Add(item);
            }
            listViewSupplySet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSupplySet.SelectedItems.Count==1)
            {
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                supply.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                supply.Price = Convert.ToInt64(textBoxPrice.Text);               
                Program.epDb.SaveChanges();
                ShowSupplySet();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSupplySet.SelectedItems.Count == 1)
                {
                    SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                    Program.epDb.SupplySet.Remove(supply);
                    Program.epDb.SaveChanges();
                    ShowSupplySet();
                }
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewSupplySet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSupplySet.SelectedItems.Count == 1)
            {
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                //находим в comboBoxAgents необходимую строку по Id риелтора и задаём её отображение comboBox-у
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(supply.IdAgent.ToString());
                //точно так же поступаем с comboBoxClients и comboBoxRealEstate
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(supply.IdClient.ToString());
                comboBoxRealEstate.SelectedIndex = comboBoxRealEstate.FindString(supply.IdRealEstate.ToString());
                textBoxPrice.Text = supply.Price.ToString();
            }
            else
            {
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
        }
    }
}
