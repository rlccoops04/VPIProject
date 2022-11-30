namespace VPIProject
{
    public partial class Form1 : Form
    {
        private List<Arendator> arendators;
        private List<Arendodatel> arendodatels;
        private RentRoomContext db = new();
        public Form1()
        {
            InitializeComponent();
        }
        private void VisibleEnter(bool cond)
        {
            lblEnterMain.Visible = cond;
            lblEnterLogin.Visible = cond;
            lblEnterPassword.Visible = cond;
            txtboxEnterLogin.Visible = cond;
            txtboxEnterPassword.Visible = cond;
            btnEnterEnter.Visible = cond;
        }
        private void VisibleMenu(bool cond)
        {
            btnMenuEnter.Visible = cond;
            btnMenuReg.Visible = cond;
            lblMenuMain.Visible = cond;
        }
        private void VisibleReg(bool cond)
        {
            lblReg_Login.Visible = cond;
            lblReg_Name.Visible = cond;
            lblReg_NumTel.Visible = cond;
            lblReg_Password.Visible = cond;
            lblReg_Surname.Visible = cond;
            btnReg_Reg.Visible = cond;
            txtboxReg_Login.Visible = cond;
            txtboxReg_Name.Visible = cond;
            txtboxReg_NumTel.Visible = cond;
            txtboxReg_Password.Visible = cond;
            txtboxReg_Surname.Visible = cond;
        }

        private void btnMenuEnter_Click(object sender, EventArgs e)
        {
            VisibleMenu(false);
            VisibleEnter(true);
        }

        private void btnEnterEnter_Click(object sender, EventArgs e)
        {
            foreach (Arendator arendator in arendators)
            {
                if (arendator.LoginArendator == txtboxEnterLogin.Text &&
                    arendator.PasswordArendator == txtboxEnterPassword.Text)
                {
                    this.Hide();
                    ArendatorInterface arendatorInterface = new(arendator);
                    arendatorInterface.Show();
                    return;
                }
            }
            foreach (Arendodatel arendodatel in arendodatels)
            {
                if (arendodatel.LoginArendodatel == txtboxEnterLogin.Text &&
                    arendodatel.PasswordArendodatel == txtboxEnterPassword.Text)
                {
                    this.Hide();
                    ArendodatelInterface arendodatelInterface = new(arendodatel);
                    arendodatelInterface.Show();
                }
            }
            lblEnter_Error.Text = "Ќеверный логин или пароль";
        }

        private void btnMenuReg_Click(object sender, EventArgs e)
        {
            VisibleMenu(false);
            VisibleReg(true);
        }

        private void btnReg_Reg_Click(object sender, EventArgs e)
        {
            //—оздаЄм нового арендатора
            Arendator arendator = new Arendator { 
                LoginArendator = txtboxReg_Login.Text, 
                PasswordArendator = txtboxReg_Password.Text,
                SurNameArendator = txtboxReg_Surname.Text,
                NameArendator = txtboxReg_Name.Text,
                MobTelArendator = txtboxReg_NumTel.Text
            };

            //добавл€ем арендатора в базу данных и сохран€ем изменени€
            db.Arendators.Add(arendator);
            db.SaveChanges();

            //скрываем текущее окно
            this.Hide();

            //создаЄм новое окно дл€ арендатора и показываем его
            ArendatorInterface arendatorInterface = new ArendatorInterface(arendator);
            arendatorInterface.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VisibleEnter(false);
            VisibleReg(false);
            arendators = db.Arendators.ToList();
            arendodatels = db.Arendodatels.ToList();
        }
    }
}