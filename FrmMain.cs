namespace WFA230427
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Test01();
        }

        private void Test01()
        {
            Item item = new()
            {
                Title = "Mosogat�s",
                Description = "el k�ne' mosogatni a koszos ed�nyeket, mer anyu le fog baszni, ha nem :(",
                Importance = 3,
                Deadline = new(2023, 04, 27, 20, 00, 00),
                PeriodOfTime = new(00, 30, 00)
            };

            UcItemDetails ucid = new(item);
            pnlItemDetails.Controls.Add(ucid);
        }
    }
}