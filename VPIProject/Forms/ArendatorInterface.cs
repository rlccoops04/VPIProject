﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPIProject
{
    public partial class ArendatorInterface : Form
    {
        public RentRoomContext db = new();
        private Arendator currArendator;
        private UCMyKabinet ucMyKabinet;
        private UCMyDogovors ucMyDogovors;
        private UCSearchRoom ucSearchRoom;
        private UCKatalog ucKatalog;
        public ArendatorInterface(Arendator currArendator)
        {
            this.currArendator = currArendator;
            InitializeComponent();
        }

        private void ArendatorInterface_Load(object sender, EventArgs e)
        {
            ucMyKabinet = new(currArendator);
            ucMyKabinet.Location = new Point(200, 75);
            this.Controls.Add(ucMyKabinet);

            ucMyDogovors = new(currArendator.LoginArendator);
            ucMyDogovors.Location = new Point(200, 75);
            this.Controls.Add(ucMyDogovors);

            ucSearchRoom = new();
            ucSearchRoom.Location = new Point(200, 75);
            this.Controls.Add(ucSearchRoom);

            ucKatalog = new();
            ucKatalog.Location = new Point(200, 75);
            this.Controls.Add(ucKatalog);
            HideAll();
        }
        private void HideAll()
        {
            ucMyKabinet.Hide();
            ucMyDogovors.Hide();
            ucSearchRoom.Hide();
            ucKatalog.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKab_Click(object sender, EventArgs e)
        {
            HideAll();
            ucMyKabinet.Show();
            lblCurrPage.Text = "Личный кабинет";
        }

        private void btnMyDogovor_Click(object sender, EventArgs e)
        {
            HideAll();
            ucMyDogovors.Show();
            lblCurrPage.Text = "Мои договоры";
        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            HideAll();
            ucSearchRoom.Show();
            lblCurrPage.Text = "Поиск помещения";
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            HideAll();
            ucKatalog.Show();
        }
    }
}
