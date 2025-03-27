namespace LB1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                labelUsers.Text = "������ �������������:";
                foreach (User u in users)
                {
                    LabelInfAboutUsers.Text += ($"{u.Id}.{u.Name} - {u.Age}\n");
                }

            }
        }
    }
}
