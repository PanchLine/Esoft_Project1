﻿namespace Esoft_Project
{
    partial class FormRealEstate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelAddress_City = new System.Windows.Forms.Label();
            this.labelAddress_Street = new System.Windows.Forms.Label();
            this.labelAddress_House = new System.Windows.Forms.Label();
            this.labelAddress_Number = new System.Windows.Forms.Label();
            this.labelCoordinate_latitude = new System.Windows.Forms.Label();
            this.labelCoordinate_longtitude = new System.Windows.Forms.Label();
            this.labelTotalArea = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.labelTotalFloors = new System.Windows.Forms.Label();
            this.textBoxAddress_Number = new System.Windows.Forms.TextBox();
            this.textBoxAddress_House = new System.Windows.Forms.TextBox();
            this.textBoxAddress_Street = new System.Windows.Forms.TextBox();
            this.textBoxAddress_City = new System.Windows.Forms.TextBox();
            this.textBoxCoordinate_longtitude = new System.Windows.Forms.TextBox();
            this.textBoxCoordinate_latitude = new System.Windows.Forms.TextBox();
            this.textBoxTotalArea = new System.Windows.Forms.TextBox();
            this.textBoxRooms = new System.Windows.Forms.TextBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.textBoxTotalFloors = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.listViewRealEstateSet_Apartment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRealEstateSet_House = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRealEstateSet_Land = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(484, 464);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(83, 34);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(573, 464);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(83, 34);
            this.buttonEdit.TabIndex = 23;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(662, 464);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(83, 34);
            this.buttonDel.TabIndex = 24;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelAddress_City
            // 
            this.labelAddress_City.AutoSize = true;
            this.labelAddress_City.Location = new System.Drawing.Point(12, 8);
            this.labelAddress_City.Name = "labelAddress_City";
            this.labelAddress_City.Size = new System.Drawing.Size(48, 17);
            this.labelAddress_City.TabIndex = 25;
            this.labelAddress_City.Text = "Город";
            // 
            // labelAddress_Street
            // 
            this.labelAddress_Street.AutoSize = true;
            this.labelAddress_Street.Location = new System.Drawing.Point(12, 51);
            this.labelAddress_Street.Name = "labelAddress_Street";
            this.labelAddress_Street.Size = new System.Drawing.Size(49, 17);
            this.labelAddress_Street.TabIndex = 26;
            this.labelAddress_Street.Text = "Улица";
            // 
            // labelAddress_House
            // 
            this.labelAddress_House.AutoSize = true;
            this.labelAddress_House.Location = new System.Drawing.Point(12, 96);
            this.labelAddress_House.Name = "labelAddress_House";
            this.labelAddress_House.Size = new System.Drawing.Size(88, 17);
            this.labelAddress_House.TabIndex = 27;
            this.labelAddress_House.Text = "Номер дома";
            // 
            // labelAddress_Number
            // 
            this.labelAddress_Number.AutoSize = true;
            this.labelAddress_Number.Location = new System.Drawing.Point(12, 141);
            this.labelAddress_Number.Name = "labelAddress_Number";
            this.labelAddress_Number.Size = new System.Drawing.Size(118, 17);
            this.labelAddress_Number.TabIndex = 28;
            this.labelAddress_Number.Text = "Номер квартиры";
            this.labelAddress_Number.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelCoordinate_latitude
            // 
            this.labelCoordinate_latitude.AutoSize = true;
            this.labelCoordinate_latitude.Location = new System.Drawing.Point(12, 186);
            this.labelCoordinate_latitude.Name = "labelCoordinate_latitude";
            this.labelCoordinate_latitude.Size = new System.Drawing.Size(58, 17);
            this.labelCoordinate_latitude.TabIndex = 29;
            this.labelCoordinate_latitude.Text = "Широта";
            // 
            // labelCoordinate_longtitude
            // 
            this.labelCoordinate_longtitude.AutoSize = true;
            this.labelCoordinate_longtitude.Location = new System.Drawing.Point(12, 231);
            this.labelCoordinate_longtitude.Name = "labelCoordinate_longtitude";
            this.labelCoordinate_longtitude.Size = new System.Drawing.Size(63, 17);
            this.labelCoordinate_longtitude.TabIndex = 30;
            this.labelCoordinate_longtitude.Text = "Долгота";
            // 
            // labelTotalArea
            // 
            this.labelTotalArea.AutoSize = true;
            this.labelTotalArea.Location = new System.Drawing.Point(168, 55);
            this.labelTotalArea.Name = "labelTotalArea";
            this.labelTotalArea.Size = new System.Drawing.Size(68, 17);
            this.labelTotalArea.TabIndex = 31;
            this.labelTotalArea.Text = "Площадь";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(168, 8);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(33, 17);
            this.labelType.TabIndex = 32;
            this.labelType.Text = "Тип";
            this.labelType.Click += new System.EventHandler(this.label8_Click);
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Location = new System.Drawing.Point(169, 98);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(137, 17);
            this.labelRooms.TabIndex = 33;
            this.labelRooms.Text = "Количество комнат";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Location = new System.Drawing.Point(168, 143);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(41, 17);
            this.labelFloor.TabIndex = 34;
            this.labelFloor.Text = "Этаж";
            // 
            // labelTotalFloors
            // 
            this.labelTotalFloors.AutoSize = true;
            this.labelTotalFloors.Location = new System.Drawing.Point(168, 98);
            this.labelTotalFloors.Name = "labelTotalFloors";
            this.labelTotalFloors.Size = new System.Drawing.Size(137, 17);
            this.labelTotalFloors.TabIndex = 35;
            this.labelTotalFloors.Text = "Количество этажей";
            this.labelTotalFloors.Visible = false;
            // 
            // textBoxAddress_Number
            // 
            this.textBoxAddress_Number.Location = new System.Drawing.Point(15, 161);
            this.textBoxAddress_Number.Name = "textBoxAddress_Number";
            this.textBoxAddress_Number.Size = new System.Drawing.Size(134, 22);
            this.textBoxAddress_Number.TabIndex = 36;
            // 
            // textBoxAddress_House
            // 
            this.textBoxAddress_House.Location = new System.Drawing.Point(15, 116);
            this.textBoxAddress_House.Name = "textBoxAddress_House";
            this.textBoxAddress_House.Size = new System.Drawing.Size(134, 22);
            this.textBoxAddress_House.TabIndex = 37;
            // 
            // textBoxAddress_Street
            // 
            this.textBoxAddress_Street.Location = new System.Drawing.Point(15, 71);
            this.textBoxAddress_Street.Name = "textBoxAddress_Street";
            this.textBoxAddress_Street.Size = new System.Drawing.Size(134, 22);
            this.textBoxAddress_Street.TabIndex = 38;
            // 
            // textBoxAddress_City
            // 
            this.textBoxAddress_City.Location = new System.Drawing.Point(15, 28);
            this.textBoxAddress_City.Name = "textBoxAddress_City";
            this.textBoxAddress_City.Size = new System.Drawing.Size(134, 22);
            this.textBoxAddress_City.TabIndex = 39;
            // 
            // textBoxCoordinate_longtitude
            // 
            this.textBoxCoordinate_longtitude.Location = new System.Drawing.Point(15, 251);
            this.textBoxCoordinate_longtitude.Name = "textBoxCoordinate_longtitude";
            this.textBoxCoordinate_longtitude.Size = new System.Drawing.Size(134, 22);
            this.textBoxCoordinate_longtitude.TabIndex = 40;
            this.textBoxCoordinate_longtitude.TextChanged += new System.EventHandler(this.textBoxLongtitude_TextChanged);
            // 
            // textBoxCoordinate_latitude
            // 
            this.textBoxCoordinate_latitude.Location = new System.Drawing.Point(15, 206);
            this.textBoxCoordinate_latitude.Name = "textBoxCoordinate_latitude";
            this.textBoxCoordinate_latitude.Size = new System.Drawing.Size(134, 22);
            this.textBoxCoordinate_latitude.TabIndex = 41;
            this.textBoxCoordinate_latitude.TextChanged += new System.EventHandler(this.textBoxLatitude_TextChanged);
            // 
            // textBoxTotalArea
            // 
            this.textBoxTotalArea.Location = new System.Drawing.Point(171, 75);
            this.textBoxTotalArea.Name = "textBoxTotalArea";
            this.textBoxTotalArea.Size = new System.Drawing.Size(134, 22);
            this.textBoxTotalArea.TabIndex = 42;
            // 
            // textBoxRooms
            // 
            this.textBoxRooms.Location = new System.Drawing.Point(172, 118);
            this.textBoxRooms.Name = "textBoxRooms";
            this.textBoxRooms.Size = new System.Drawing.Size(134, 22);
            this.textBoxRooms.TabIndex = 43;
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(171, 163);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(134, 22);
            this.textBoxFloor.TabIndex = 44;
            // 
            // textBoxTotalFloors
            // 
            this.textBoxTotalFloors.Location = new System.Drawing.Point(171, 118);
            this.textBoxTotalFloors.Name = "textBoxTotalFloors";
            this.textBoxTotalFloors.Size = new System.Drawing.Size(135, 22);
            this.textBoxTotalFloors.TabIndex = 45;
            this.textBoxTotalFloors.Visible = false;
            // 
            // Logo
            // 
            this.Logo.Image = global::Esoft_Project.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(482, 14);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(263, 104);
            this.Logo.TabIndex = 46;
            this.Logo.TabStop = false;
            // 
            // listViewRealEstateSet_Apartment
            // 
            this.listViewRealEstateSet_Apartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewRealEstateSet_Apartment.FullRowSelect = true;
            this.listViewRealEstateSet_Apartment.GridLines = true;
            this.listViewRealEstateSet_Apartment.HideSelection = false;
            this.listViewRealEstateSet_Apartment.Location = new System.Drawing.Point(15, 279);
            this.listViewRealEstateSet_Apartment.MultiSelect = false;
            this.listViewRealEstateSet_Apartment.Name = "listViewRealEstateSet_Apartment";
            this.listViewRealEstateSet_Apartment.Size = new System.Drawing.Size(730, 179);
            this.listViewRealEstateSet_Apartment.TabIndex = 47;
            this.listViewRealEstateSet_Apartment.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Apartment.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_Apartment.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_Apartment_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Город";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Улица";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Номер дома";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Номер квартиры";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Широта";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Долгота";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Площадь";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Количество комнат";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Этаж";
            // 
            // listViewRealEstateSet_House
            // 
            this.listViewRealEstateSet_House.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader24});
            this.listViewRealEstateSet_House.FullRowSelect = true;
            this.listViewRealEstateSet_House.GridLines = true;
            this.listViewRealEstateSet_House.HideSelection = false;
            this.listViewRealEstateSet_House.Location = new System.Drawing.Point(15, 279);
            this.listViewRealEstateSet_House.MultiSelect = false;
            this.listViewRealEstateSet_House.Name = "listViewRealEstateSet_House";
            this.listViewRealEstateSet_House.Size = new System.Drawing.Size(730, 179);
            this.listViewRealEstateSet_House.TabIndex = 48;
            this.listViewRealEstateSet_House.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_House.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_House.Visible = false;
            this.listViewRealEstateSet_House.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_House_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Город";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Улица";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Номер дома";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Номер квартиры";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Широта";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Долгота";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Площадь";
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Количество этажей";
            // 
            // listViewRealEstateSet_Land
            // 
            this.listViewRealEstateSet_Land.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23});
            this.listViewRealEstateSet_Land.FullRowSelect = true;
            this.listViewRealEstateSet_Land.GridLines = true;
            this.listViewRealEstateSet_Land.HideSelection = false;
            this.listViewRealEstateSet_Land.Location = new System.Drawing.Point(15, 279);
            this.listViewRealEstateSet_Land.MultiSelect = false;
            this.listViewRealEstateSet_Land.Name = "listViewRealEstateSet_Land";
            this.listViewRealEstateSet_Land.Size = new System.Drawing.Size(730, 179);
            this.listViewRealEstateSet_Land.TabIndex = 49;
            this.listViewRealEstateSet_Land.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Land.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_Land.Visible = false;
            this.listViewRealEstateSet_Land.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_Land_SelectedIndexChanged);
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Город";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Улица";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Номер дома";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Номер квартиры";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Широта";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Долгота";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Площадь";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(171, 28);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(134, 24);
            this.comboBoxType.TabIndex = 50;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // FormRealEstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 514);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.listViewRealEstateSet_Land);
            this.Controls.Add(this.listViewRealEstateSet_House);
            this.Controls.Add(this.listViewRealEstateSet_Apartment);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.textBoxTotalFloors);
            this.Controls.Add(this.textBoxFloor);
            this.Controls.Add(this.textBoxRooms);
            this.Controls.Add(this.textBoxTotalArea);
            this.Controls.Add(this.textBoxCoordinate_latitude);
            this.Controls.Add(this.textBoxCoordinate_longtitude);
            this.Controls.Add(this.textBoxAddress_City);
            this.Controls.Add(this.textBoxAddress_Street);
            this.Controls.Add(this.textBoxAddress_House);
            this.Controls.Add(this.textBoxAddress_Number);
            this.Controls.Add(this.labelTotalFloors);
            this.Controls.Add(this.labelFloor);
            this.Controls.Add(this.labelRooms);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTotalArea);
            this.Controls.Add(this.labelCoordinate_longtitude);
            this.Controls.Add(this.labelCoordinate_latitude);
            this.Controls.Add(this.labelAddress_Number);
            this.Controls.Add(this.labelAddress_House);
            this.Controls.Add(this.labelAddress_Street);
            this.Controls.Add(this.labelAddress_City);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormRealEstate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объекты недвижимости";
            this.Load += new System.EventHandler(this.FormRealEstate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelAddress_City;
        private System.Windows.Forms.Label labelAddress_Street;
        private System.Windows.Forms.Label labelAddress_House;
        private System.Windows.Forms.Label labelAddress_Number;
        private System.Windows.Forms.Label labelCoordinate_latitude;
        private System.Windows.Forms.Label labelCoordinate_longtitude;
        private System.Windows.Forms.Label labelTotalArea;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label labelTotalFloors;
        private System.Windows.Forms.TextBox textBoxAddress_Number;
        private System.Windows.Forms.TextBox textBoxAddress_House;
        private System.Windows.Forms.TextBox textBoxAddress_Street;
        private System.Windows.Forms.TextBox textBoxAddress_City;
        private System.Windows.Forms.TextBox textBoxCoordinate_longtitude;
        private System.Windows.Forms.TextBox textBoxCoordinate_latitude;
        private System.Windows.Forms.TextBox textBoxTotalArea;
        private System.Windows.Forms.TextBox textBoxRooms;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.TextBox textBoxTotalFloors;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ListView listViewRealEstateSet_Apartment;
        private System.Windows.Forms.ListView listViewRealEstateSet_House;
        private System.Windows.Forms.ListView listViewRealEstateSet_Land;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ColumnHeader columnHeader24;
    }
}