﻿using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using NLog;

namespace HotelProject
{
    public partial class MainForm : Form
    {
        public Guest[] guestsList;
        public DataTable guestDataTable = new DataTable();
        private Guest selectedGuest = null;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public MainForm()
        {
            InitializeComponent();
            InitDataGridView();
            LoadGuestData();
            FillDataTable();

            logger.Trace("Программа успешно инициализирована");
        }
        
        /// <summary>
        /// Метод для заполнения guestDataTable и корректного отображения таблицы
        /// </summary>
        public void FillDataTable()
        {
            logger.Trace("Попытка заполнить таблицу guestDataTable");

            guestDataTable.Columns.Add("Id", typeof(int));
            guestDataTable.Columns.Add("Name", typeof(string));
            guestDataTable.Columns.Add("BirthDay", typeof(DateTime));
            guestDataTable.Columns.Add("HasAnimals", typeof(bool));
            guestDataTable.Columns.Add("Status", typeof(string));
            guestDataTable.Columns.Add("RoomNumber", typeof(int));

            logger.Trace("Таблица guestDataTable заполнена");
        }
        /// <summary>
        /// Метод для инициализации таблицы guestDataGridView и заполнения её столбцов
        /// </summary>
        public void InitDataGridView()
        {
            logger.Trace("Попытка заполнить таблицу guestDataGridView");

            var idColumn = new DataGridViewTextBoxColumn();
            idColumn.Width = 30;
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "ID";
            guestDataGridView.Columns.Add(idColumn);

            var nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Width = 250;
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Имя";
            guestDataGridView.Columns.Add(nameColumn);

            var birthDayColumn = new DataGridViewTextBoxColumn();
            birthDayColumn.Width = 100;
            birthDayColumn.DataPropertyName = "BirthDay";
            birthDayColumn.HeaderText = "Дата рождения";
            guestDataGridView.Columns.Add(birthDayColumn);

            var hasAnimalsColumn = new DataGridViewTextBoxColumn();
            hasAnimalsColumn.Width = 80;
            hasAnimalsColumn.DataPropertyName = "HasAnimals";
            hasAnimalsColumn.HeaderText = "Наличие животных";
            guestDataGridView.Columns.Add(hasAnimalsColumn);

            var statusColumn = new DataGridViewTextBoxColumn();
            statusColumn.Width = 80;
            statusColumn.DataPropertyName = "Status";
            statusColumn.HeaderText = "Статус";
            guestDataGridView.Columns.Add(statusColumn);

            var roomNumberColumn = new DataGridViewTextBoxColumn();
            roomNumberColumn.Width = 80;
            roomNumberColumn.DataPropertyName = "RoomNumber";
            roomNumberColumn.HeaderText = "Номер комнаты";
            guestDataGridView.Columns.Add(roomNumberColumn);

            logger.Trace("Таблица guestDataGridView заполнена столбцами");
        }
        private void LoadGuestData()
        {
            logger.Trace("Попытка загрузки данных из файла guests.json");

            string filePath = @"..\..\Data\guests.json";

            try
            {
                if (File.Exists(filePath))
                {
                    string data = File.ReadAllText(filePath);

                    guestsList = JsonConvert.DeserializeObject<Guest[]>(data);

                    foreach (var guest in guestsList)
                    {
                        guestDataGridView.Rows.Add(guest.Id, guest.Name, guest.BirthDay, guest.HasAnimals, guest.Status,
                            guest.RoomNumber);
                    }
                }
                else
                {
                    logger.Error("Файла guests.json не существует в папке Data");
                }
            }
            catch (Exception ex)
            {
                logger.Fatal($"В приложении возникла ошибка {ex}");
            }

            logger.Debug("Данные из файла guests.json загружены в таблицу");
        }

        private void TickClockTimer(object sender, EventArgs e)
        {
            this.clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ChangedAnyRadioButton(object sender, EventArgs e)
        {
            guestDataGridView.DataSource = guestsList;

            logger.Info("Таблица офильтрована в соответствии с пунктом \"Любой\"");
        }

        private void ChangedReservedRadioButton(object sender, EventArgs e)
        {
            if (reservedRadioBox.Checked)
            {
                var data = guestsList.Where(item => item.Status.ToUpper() == "ЗАРЕЗЕРВИРОВАНО").ToList();
                guestDataGridView.DataSource = data;
            }

            logger.Info("Таблица офильтрована в соответствии с пунктом \"Зарезервировано\"");
        }
        private void ChangedFreeRadioButton(object sender, EventArgs e)
        {
            if (freeRadioBox.Checked)
            {
                var data = guestsList.Where(item => item.Status.ToUpper() == "СВОБОДНЫЕ").ToList();
                guestDataGridView.DataSource = data;
            }

            logger.Info("Таблица офильтрована в соответствии с пунктом \"Свободные\"");
        }
        private void ChangedOccupiedRadioButton(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                var data = guestsList.Where(item => item.Status.ToUpper() == "ЗАНЯТЫЕ").ToList();
                guestDataGridView.DataSource = data;
            }

            logger.Info("Таблица офильтрована в соответствии с пунктом \"Занятые\"");
        }
        private void ChangedDischargedRadioButton(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                var data = guestsList.Where(item => item.Status.ToUpper() == "ВЫПИСЫВАЮТСЯ").ToList();
                guestDataGridView.DataSource = data;
            }

            logger.Info("Таблица офильтрована в соответствии с пунктом \"Выписываются\"");
        }

        private void ChangedSearchTextBox(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.Trim().ToUpper();

            if (searchText == string.Empty)
            {
                guestDataGridView.DataSource = guestsList;
            }
            else
            {
                var filteredData = guestsList.Where(item => item.Name.ToUpper().Contains(searchText)).ToList();
                guestDataGridView.DataSource = filteredData;
            }

            logger.Debug($"Совершен поиск данных по таблице. Запрос пользователя: {searchText}");
        }
        
        private void ShowGuestData(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var thisGuest = guestsList[e.RowIndex];
                    selectedGuest = thisGuest;
                    string name = thisGuest.Name;
                    string status = thisGuest.Status;

                    guestNameLabel.Text = $"ФИО гостя: \n{name}";
                    guestStatusLabel.Text = $"Статус гостя: \n{status}";

                    logger.Debug($"Пользователь выбрал в таблице гостя {name}");

                    if (name == string.Empty)
                    {
                        logger.Warn("Добавлен пользователь с пустым именем");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                logger.Fatal($"В приложении возникла ошибка {ex}");
            }
        }

        private void ShowAllDataAboutGuest(object sender, EventArgs e)
        {
            if (selectedGuest == null)
            {
                MessageBox.Show("Вы не выбрали ни одного гостя!", "Внимание!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                logger.Warn("Пользователь не выбрал ни одного гостя в таблице и попытался открыть его");

                return;
            }
            var guestCard = new GuestCard();

            guestCard.SetClientData(selectedGuest.Name, selectedGuest.BirthDay, selectedGuest.HasAnimals);

            guestCard.Show();
        }
    }
}