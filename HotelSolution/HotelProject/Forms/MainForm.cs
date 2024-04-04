using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Drawing;
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
            try
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
            catch (Exception ex)
            {
                logger.Error($"Вылезла ошибка! {ex}");
            }
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
            nameColumn.Width = 220;
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Имя";
            guestDataGridView.Columns.Add(nameColumn);

            var birthDayColumn = new DataGridViewTextBoxColumn();
            birthDayColumn.Width = 100;
            birthDayColumn.DataPropertyName = "BirthDay";
            birthDayColumn.HeaderText = "Дата рождения";
            guestDataGridView.Columns.Add(birthDayColumn);

            var hasAnimalsColumn = new DataGridViewTextBoxColumn();
            hasAnimalsColumn.Width = 70;
            hasAnimalsColumn.DataPropertyName = "HasAnimals";
            hasAnimalsColumn.HeaderText = "Наличие животных";
            guestDataGridView.Columns.Add(hasAnimalsColumn);

            var statusColumn = new DataGridViewTextBoxColumn();
            statusColumn.Width = 140;
            statusColumn.DataPropertyName = "Status";
            statusColumn.HeaderText = "Статус";
            guestDataGridView.Columns.Add(statusColumn);

            var roomNumberColumn = new DataGridViewTextBoxColumn();
            roomNumberColumn.Width = 70;
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

                        if (guest.BirthDay > guest.DayOfArrival)
                        {
                            logger.Warn($"В таблицу был добавлен гость, который заехал в отель раньше чем родился. Имя гостя {guest.Name}");
                        }
                        if(guest.DayOfArrival > guest.DayOfDeparture)
                        {
                            logger.Warn($"В таблицу был добавлен гость, выселился раньше чем заселился. Имя гостя {guest.Name}");
                        }
                    }
                }
                else
                {
                    logger.Error("Файла guests.json не существует в папке Data");
                }
            }
            catch (Exception ex)
            {
                logger.Fatal($"В приложении возникла ошибка {ex}!");
            }

            logger.Debug("Данные из файла guests.json загружены в таблицу");
        }

        public void TickClockTimer(object sender, EventArgs e)
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
                var data = guestsList.Where(item => item.Status.ToUpper() == "ЗАРЕЗЕРВИРОВАННЫЕ").ToList();
                guestDataGridView.DataSource = data;
            }

            logger.Info("Таблица офильтрована в соответствии с пунктом \"Зарезервированные\"");
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

                    string picturePath = $"id{thisGuest.Id}.jpg";

                    guestNameLabel.Text = $"ФИО гостя: \n{thisGuest.Name}";
                    guestStatusLabel.Text = $"Статус гостя: \n{thisGuest.Status}";
                    guestDayOfArrivalLabel.Text = $"Дата заселения: {thisGuest.DayOfArrival}";
                    guestDayOfDepartureLabel.Text = $"Дата выселения: {thisGuest.DayOfDeparture}";

                    Image guestPicture = Image.FromFile($@"..\..\Data\Pictures\{picturePath}");
                    pictureBox1.Image = guestPicture;

                    hotelRoomLabel.Text = $"Номер № {thisGuest.RoomNumber}";

                    logger.Debug($"Пользователь выбрал в таблице гостя {thisGuest.Name}");

                    if (thisGuest.Name == string.Empty)
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

            TimeSpan difference = selectedGuest.DayOfDeparture.Subtract(selectedGuest.DayOfArrival);
            int differenceInDays = (int)difference.TotalDays;
            guestCard.SetClientData(selectedGuest.Name, selectedGuest.BirthDay, selectedGuest.HasAnimals, selectedGuest.PaymentType, differenceInDays);

            guestCard.Show();
        }
    }
}
