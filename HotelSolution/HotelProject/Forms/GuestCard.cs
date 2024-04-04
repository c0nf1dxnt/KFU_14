using System.Windows.Forms;
using System;

namespace HotelProject
{
    public partial class GuestCard : Form
    {
        public GuestCard()
        {
            InitializeComponent();
        }
        public void SetClientData(string name, DateTime birthDay, bool hasAnimals, string paymentType, int differenceInDays)
        {
            guestNameLabel.Text = $"ФИО гостя: \n{name}";
            guestBirthdayLabel.Text = $"Дата рождения: {birthDay.ToShortDateString()}";
            guestHasAnimalsLabel.Text = $"Есть животные: {(hasAnimals ? "Да" : "Нет")}";
            guestPaymentTypeLabel.Text = $"Оплачено: {paymentType}";
            guestNumberOfDaysAtHotelLabel.Text = $"Количество дней в отеле: {differenceInDays}";
        }
    }
}
