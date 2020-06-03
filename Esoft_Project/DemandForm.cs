using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class DemandForm : Form
    {
        public DemandForm()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowAgents();
            ShowClients();
            ShowDemandSet();
        }

        void ShowAgents()
        {
            comboBoxAgents.Items.Clear();
            foreach (AgentsSet agentsSet in Program.epDb.AgentsSet)
            {
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

        void ShowDemandSet()
        {
            listView_Apartment.Items.Clear();
            listView_House.Items.Clear();
            listView_Land.Items.Clear();
            
            foreach(DemandSet demand in Program.epDb.DemandSet)
            {
                if (demand.Type==0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        demand.IdAgent.ToString(),
                        demand.AgentsSet.LastName+" "+demand.AgentsSet.FirstName+" "+demand.AgentsSet.MiddleName,
                        demand.IdClient.ToString(),
                        demand.ClientsSet.LastName+" "+demand.ClientsSet.FirstName+" "+demand.ClientsSet.MiddleName,
                        demand.MinPrice.ToString()+"p",
                        demand.MaxPrice.ToString()+"p",
                        demand.MinArea.ToString(),
                        demand.MaxArea.ToString(),
                        demand.MinRooms.ToString(),
                        demand.MaxRooms.ToString(),
                        demand.MinFloor.ToString(),
                        demand.MaxFloor.ToString(),
                    }) ;
                    item.Tag = demand;
                    listView_Apartment.Items.Add(item);
                }
                else if (demand.Type==1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        demand.IdAgent.ToString(),
                        demand.AgentsSet.LastName+" "+demand.AgentsSet.FirstName+" "+demand.AgentsSet.MiddleName,
                        demand.IdClient.ToString(),
                        demand.ClientsSet.LastName+" "+demand.ClientsSet.FirstName+" "+demand.ClientsSet.MiddleName,
                        demand.MinPrice.ToString()+"p",
                        demand.MaxPrice.ToString()+"p",
                        demand.MinArea.ToString(),
                        demand.MaxArea.ToString(),
                        demand.MinFloors.ToString(),
                        demand.MaxFloors.ToString(),
                    });
                    item.Tag = demand;
                    listView_House.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        demand.IdAgent.ToString(),
                        demand.AgentsSet.LastName+" "+demand.AgentsSet.FirstName+" "+demand.AgentsSet.MiddleName,
                        demand.IdClient.ToString(),
                        demand.ClientsSet.LastName+" "+demand.ClientsSet.FirstName+" "+demand.ClientsSet.MiddleName,
                        demand.MinPrice.ToString()+"p",
                        demand.MaxPrice.ToString()+"p",
                        demand.MinArea.ToString(),
                        demand.MaxArea.ToString(),
                    });
                    item.Tag = demand;
                    listView_Land.Items.Add(item);
                }
            }
            listView_Apartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView_House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex==0)
            {
                listView_Apartment.Visible = true;                
                labelMinRooms.Visible = true;
                textBoxMinRooms.Visible = true;
                labelMaxRooms.Visible = true;
                textBoxMaxRooms.Visible = true;
                labelMinFloor.Visible = true;
                textBoxMinFloor.Visible = true;
                labelMaxFloor.Visible = true;
                textBoxMaxFloor.Visible = true;

                listView_House.Visible = false;
                listView_Land.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listView_House.Visible = true;
                labelMaxFloors.Visible = true;
                textBoxMaxFloors.Visible = true;
                labelMinFloors.Visible = true;
                textBoxMinFloors.Visible = true;

                listView_Apartment.Visible = false;
                listView_Land.Visible = false;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;

                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
            else
            {
                listView_Land.Visible = true;

                listView_House.Visible = false;
                listView_Apartment.Visible = false;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;

                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgents.SelectedItem != null && comboBoxClients != null)
            {
                DemandSet demand = new DemandSet();

                demand.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                demand.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                demand.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                demand.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);

                if (comboBoxType.SelectedIndex == 0)
                {
                    demand.Type = 0;
                    demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                    demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    demand.Type = 1;
                    demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                }
                else
                {
                    demand.Type = 2;
                }
                Program.epDb.DemandSet.Add(demand);
                Program.epDb.SaveChanges();
                ShowDemandSet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                if (listView_Apartment.SelectedItems.Count == 1)
                {
                    DemandSet demand = listView_Apartment.SelectedItems[0].Tag as DemandSet;
                    demand.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                    demand.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    demand.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demand.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                    demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                    demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                    demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);                    
                    Program.epDb.SaveChanges();
                    ShowDemandSet();
                }
            }
            else if (comboBoxType.SelectedIndex==1)
            {
                if (listView_House.SelectedItems.Count == 1)
                {
                    DemandSet demand = listView_House.SelectedItems[0].Tag as DemandSet;
                    demand.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                    demand.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    demand.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demand.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                    demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                    demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                    Program.epDb.SaveChanges();
                    ShowDemandSet();
                }
            }
            else
            {
                if (listView_Land.SelectedItems.Count == 1)
                {
                    DemandSet demand = listView_Land.SelectedItems[0].Tag as DemandSet;
                    demand.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                    demand.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    demand.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demand.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                    demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                    Program.epDb.SaveChanges();
                    ShowDemandSet();
                }
            }
        }
        private void listView_Apartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Apartment.SelectedItems.Count==1)
            {
                DemandSet demand = listView_Apartment.SelectedItems[0].Tag as DemandSet;
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(demand.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(demand.IdClient.ToString());
                textBoxMinPrice.Text = demand.MinPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMinArea.Text = demand.MinArea.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
                textBoxMinRooms.Text = demand.MinRooms.ToString();
                textBoxMaxRooms.Text = demand.MaxRooms.ToString();
                textBoxMinFloor.Text = demand.MaxFloor.ToString();
                textBoxMaxFloor.Text = demand.MaxFloor.ToString();
            }
            else
            {
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
            }
        }
        private void listView_House_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_House.SelectedItems.Count == 1)
            {
                DemandSet demand = listView_House.SelectedItems[0].Tag as DemandSet;
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(demand.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(demand.IdClient.ToString());
                textBoxMinPrice.Text = demand.MinPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMinArea.Text = demand.MinArea.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
                textBoxMinFloors.Text = demand.MaxFloors.ToString();
                textBoxMaxFloors.Text = demand.MaxFloors.ToString();
            }
            else
            {
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
        }
        private void listView_Land_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Land.SelectedItems.Count == 1)
            {
                DemandSet demand = listView_Land.SelectedItems[0].Tag as DemandSet;
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(demand.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(demand.IdClient.ToString());
                textBoxMinPrice.Text = demand.MinPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMinArea.Text = demand.MinArea.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
            }
            else
            {
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listView_Apartment.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listView_Apartment.SelectedItems[0].Tag as DemandSet;
                        Program.epDb.DemandSet.Remove(demand);
                        Program.epDb.SaveChanges();
                        ShowDemandSet();
                    }
                    comboBoxAgents.SelectedItem = null;
                    comboBoxClients.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = "";
                    textBoxMinFloor.Text = "";
                    textBoxMaxFloor.Text = "";
                }
                else if (comboBoxType.SelectedIndex==1)
                {
                    if (listView_House.SelectedItems.Count==1)
                    {
                        DemandSet demand = listView_House.SelectedItems[0].Tag as DemandSet;
                        Program.epDb.DemandSet.Remove(demand);
                        Program.epDb.SaveChanges();
                        ShowDemandSet();
                    }
                    comboBoxAgents.SelectedItem = null;
                    comboBoxClients.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinFloors.Text = "";
                    textBoxMaxFloors.Text = "";
                }
                else
                {
                    if (listView_Land.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listView_Land.SelectedItems[0].Tag as DemandSet;
                        Program.epDb.DemandSet.Remove(demand);
                        Program.epDb.SaveChanges();
                        ShowDemandSet();
                    }
                    comboBoxAgents.SelectedItem = null;
                    comboBoxClients.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
