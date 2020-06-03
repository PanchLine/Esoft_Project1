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
    public partial class FormRealEstate : Form
    {
        public FormRealEstate()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowRealEstateSet();
        }

        void ShowRealEstateSet()
        {
            //предварительно очищаем все listView
            listViewRealEstateSet_Apartment.Items.Clear();
            listViewRealEstateSet_House.Items.Clear();
            listViewRealEstateSet_Land.Items.Clear();
            // проходим по коллекции клиентов, которые находятся в базе
            foreach (RealEstateSet realEstate in Program.epDb.RealEstateSet)
            {
                //отображение квартир в listViewRealEstateSet_Apartment
                if (realEstate.Type==0)
                {
                    //создадим новый элемент в listViewRealEstateSet_Apartment с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        //указываем необходимые поля
                        realEstate.Address_City, realEstate.Address_Street, realEstate.Address_House,
                        realEstate.Address_Number,realEstate.Coordinate_latitude.ToString(),
                        realEstate.Coordinate_longtitude.ToString(), realEstate.TotalArea.ToString(),
                        realEstate.Rooms.ToString(), realEstate.Floor.ToString()
                    });
                    //указываем, по какому тегу выбраны элементы
                    item.Tag = realEstate;
                    //добавляем элементы в listViewRealEstateSet_Apartment для отображения
                    listViewRealEstateSet_Apartment.Items.Add(item);
                }
                //отображение квартир в listViewRealEstateSet_House
                else if (realEstate.Type == 1)
                {
                    //создадим новый элемент в listViewRealEstateSet_House с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        //указываем необходимые поля
                        realEstate.Address_City, realEstate.Address_Street, realEstate.Address_House,
                        realEstate.Address_Number,realEstate.Coordinate_latitude.ToString(),
                        realEstate.Coordinate_longtitude.ToString(), realEstate.TotalArea.ToString(),
                        realEstate.TotalFloors.ToString()
                    });
                    //указываем, по какому тегу выбраны элементы
                    item.Tag = realEstate;
                    //добавляем элементы в listViewRealEstateSet_House для отображения
                    listViewRealEstateSet_House.Items.Add(item);
                }              
                else
                {
                    //создадим новый элемент в listViewRealEstateSet_Land с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        //указываем необходимые поля
                        realEstate.Address_City, realEstate.Address_Street, realEstate.Address_House,
                        realEstate.Address_Number,realEstate.Coordinate_latitude.ToString(),
                        realEstate.Coordinate_longtitude.ToString(), realEstate.TotalArea.ToString(),            
                    });
                    //указываем, по какому тегу выбраны элементы
                    item.Tag = realEstate;
                    //добавляем элементы в listViewRealEstateSet_Land для отображения
                    listViewRealEstateSet_Land.Items.Add(item);
                }
            }
            //выравниваеи элементы во всех listView
            listViewRealEstateSet_Apartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex==0)
            {
                listViewRealEstateSet_Apartment.Visible = true;
                labelFloor.Visible = true;
                textBoxFloor.Visible = true;
                labelRooms.Visible = true;
                textBoxRooms.Visible = true;

                listViewRealEstateSet_House.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelTotalFloors.Visible = false;
                textBoxTotalFloors.Visible = false;

                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longtitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxFloor.Text = "";
                textBoxRooms.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewRealEstateSet_House.Visible = true;
                labelTotalFloors.Visible = true;
                textBoxTotalFloors.Visible = true;

                listViewRealEstateSet_Apartment.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = false;
                textBoxRooms.Visible = false;

                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longtitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxTotalFloors.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                listViewRealEstateSet_Land.Visible = true;

                listViewRealEstateSet_Apartment.Visible = false;
                listViewRealEstateSet_House.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = false;
                textBoxRooms.Visible = false;
                labelTotalFloors.Visible = false;
                textBoxTotalFloors.Visible = false;

                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longtitude.Text = "";
                textBoxTotalArea.Text = "";
            }
        }

        private void FormRealEstate_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //создаём новый экземпляр класса Объект недвижимости
            RealEstateSet realEstate = new RealEstateSet();
            //Делаем ссылку на объект, который хранится в textBox-ах (сначала общиe поля)
            realEstate.Address_City = textBoxAddress_City.Text;
            realEstate.Address_House = textBoxAddress_House.Text;
            realEstate.Address_Street = textBoxAddress_Street.Text;
            realEstate.Address_Number = textBoxAddress_Number.Text;
            realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
            realEstate.Coordinate_longtitude = Convert.ToDouble(textBoxCoordinate_longtitude.Text);
            realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
            //Дополнительные поля для типа "Квартира"
            if (comboBoxType.SelectedIndex==0)
            {
                realEstate.Type = 0;
                realEstate.Rooms = Convert.ToInt32(textBoxRooms.Text);
                realEstate.Floor = Convert.ToInt32(textBoxFloor.Text);
            }
            //Дополнительные поля для типа "Дом"
            else if (comboBoxType.SelectedIndex == 1)
            {
                realEstate.Type = 1;
                realEstate.TotalFloors = Convert.ToInt32(textBoxTotalFloors.Text);
            }
            //Дополнительные поля для типа "Земля"
            else
            {
                realEstate.Type = 2;
            }
            //Добавляем в таблицу RealEstateSet новый объект недвижимости realEstate
            Program.epDb.RealEstateSet.Add(realEstate);
            Program.epDb.SaveChanges();
            ShowRealEstateSet();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                //если в listView выбран элемент
                if (listViewRealEstateSet_Apartment.SelectedItems.Count ==1)
                {
                    //ищем элемент из таблицы по тегу
                    RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                    //указываем, что может быть изменено
                    realEstate.Address_City = textBoxAddress_City.Text;
                    realEstate.Address_House = textBoxAddress_House.Text;
                    realEstate.Address_Street = textBoxAddress_Street.Text;
                    realEstate.Address_Number = textBoxAddress_Number.Text;
                    realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    realEstate.Coordinate_longtitude = Convert.ToDouble(textBoxCoordinate_longtitude.Text);
                    realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    realEstate.Rooms = Convert.ToInt32(textBoxRooms.Text);
                    realEstate.Floor = Convert.ToInt32(textBoxFloor.Text);
                    Program.epDb.SaveChanges();
                    ShowRealEstateSet();
                }
            }           
            else if (comboBoxType.SelectedIndex == 1)
            {
                //если в listView выбран элемент
                if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                    //указываем, что может быть изменено
                    realEstate.Address_City = textBoxAddress_City.Text;
                    realEstate.Address_House = textBoxAddress_House.Text;
                    realEstate.Address_Street = textBoxAddress_Street.Text;
                    realEstate.Address_Number = textBoxAddress_Number.Text;
                    realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    realEstate.Coordinate_longtitude = Convert.ToDouble(textBoxCoordinate_longtitude.Text);
                    realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    realEstate.TotalFloors = Convert.ToInt32(textBoxTotalFloors.Text);
                    Program.epDb.SaveChanges();
                    ShowRealEstateSet();
                }
            }
            else
            {
                //если в listView выбран элемент
                if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                    //указываем, что может быть изменено
                    realEstate.Address_City = textBoxAddress_City.Text;
                    realEstate.Address_House = textBoxAddress_House.Text;
                    realEstate.Address_Street = textBoxAddress_Street.Text;
                    realEstate.Address_Number = textBoxAddress_Number.Text;
                    realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    realEstate.Coordinate_longtitude = Convert.ToDouble(textBoxCoordinate_longtitude.Text);
                    realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    Program.epDb.SaveChanges();
                    ShowRealEstateSet();
                }
            }
        }

        private void listViewRealEstateSet_Apartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если выбран один элемент
            if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
            {
                RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_City.Text = realEstate.Address_City;
                textBoxAddress_Street.Text = realEstate.Address_Street;
                textBoxAddress_House.Text = realEstate.Address_House;
                textBoxAddress_Number.Text = realEstate.Address_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxCoordinate_longtitude.Text = realEstate.Coordinate_longtitude.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
                textBoxRooms.Text = realEstate.Rooms.ToString();
                textBoxFloor.Text = realEstate.Floor.ToString();
            }
            else
            {
                //если не выбран ни один элемент, задаём пустые строки
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longtitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxFloor.Text = "";
                textBoxRooms.Text = "";
            }
        }

        private void listViewRealEstateSet_House_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если выбран один элемент
            if (listViewRealEstateSet_House.SelectedItems.Count == 1)
            {
                RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_City.Text = realEstate.Address_City;
                textBoxAddress_Street.Text = realEstate.Address_Street;
                textBoxAddress_House.Text = realEstate.Address_House;
                textBoxAddress_Number.Text = realEstate.Address_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxCoordinate_longtitude.Text = realEstate.Coordinate_longtitude.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
                textBoxTotalFloors.Text = realEstate.TotalFloors.ToString();
            }
            else
            {
                //если не выбран ни один элемент, задаём пустые строки
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longtitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxTotalFloors.Text = "";      
            }
        }

        private void listViewRealEstateSet_Land_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если выбран один элемент
            if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
            {
                RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_City.Text = realEstate.Address_City;
                textBoxAddress_Street.Text = realEstate.Address_Street;
                textBoxAddress_House.Text = realEstate.Address_House;
                textBoxAddress_Number.Text = realEstate.Address_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxCoordinate_longtitude.Text = realEstate.Coordinate_longtitude.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
            }
            else
            {
                //если не выбран ни один элемент, задаём пустые строки
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longtitude.Text = "";
                textBoxTotalArea.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
                    {
                        //ищем этот элемент в базе по тегу
                        RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                        //удаляем из модели базы данных
                        Program.epDb.RealEstateSet.Remove(realEstate);
                        Program.epDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                    //очищаем тектовые поля
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longtitude.Text = "";
                    textBoxTotalArea.Text = "";
                    textBoxFloor.Text = "";
                    textBoxRooms.Text = "";
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                    {
                        //ищем этот элемент в базе по тегу
                        RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                        //удаляем из модели базы данных
                        Program.epDb.RealEstateSet.Remove(realEstate);
                        Program.epDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                    //очищаем тектовые поля
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longtitude.Text = "";
                    textBoxTotalArea.Text = "";
                    textBoxTotalFloors.Text = "";                    
                }
                else if (comboBoxType.SelectedIndex == 2)
                {
                    if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                    {
                        //ищем этот элемент в базе по тегу
                        RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                        //удаляем из модели базы данных
                        Program.epDb.RealEstateSet.Remove(realEstate);
                        Program.epDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                    //очищаем тектовые поля
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longtitude.Text = "";
                    textBoxTotalArea.Text = "";                   
                }
            }
            //если возникает какая-то ошибка
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxLatitude_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCoordinate_latitude.Text != "" && textBoxCoordinate_latitude.Text !="-")
            {
                if (Convert.ToDouble(textBoxCoordinate_latitude.Text) < -90 || Convert.ToDouble(textBoxCoordinate_latitude.Text) > 90)
                {
                    textBoxCoordinate_latitude.Text = "";
                }
            }
        }

        private void textBoxLongtitude_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCoordinate_longtitude.Text != "" && textBoxCoordinate_latitude.Text != "-")
            {
                if (Convert.ToDouble(textBoxCoordinate_longtitude.Text) < -180 || Convert.ToDouble(textBoxCoordinate_longtitude.Text) > 180)
                {
                    textBoxCoordinate_longtitude.Text = "";
                }
            }
        }
    }
}
