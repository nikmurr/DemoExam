namespace LopushokModule
{
    public partial class Form1 : Form
    {
        PostgreSQLHandler dbHandler;
        List<UserControl1> cards;
        public Form1()
        {
            InitializeComponent();
            dbHandler = new PostgreSQLHandler("db.edu.cchgeu.ru", "postgres", "isp-201o-muravyov", "postgres");
            cards = dbHandler.RetrieveProducts();
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;

            foreach (var card in cards)
            {
                card.Anchor = AnchorStyles.Left /*| AnchorStyles.Right*/ | AnchorStyles.Top;
                flowLayoutPanel1.Controls.Add(card);
                card.Width = flowLayoutPanel1.Width - 20;
                card.setPic();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}