using System;
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
    public partial class ArendodatelInterface : Form
    {
        private UCSearchRoom ucSearchRoom;
        private UCKatalog ucKatalog;
        private UCMyDogovors ucMyDogovors;
        private Arendodatel currArendodatel;
        private UCAddArendator ucAddArendator;
        private AddDogovor ucAddDogovor;
        private UCAllArendators ucAllArendators;
        private UCAddRoom ucAddRoom;
        private RemoveRoom ucRemoveRoom;
        private UCRemoveArendator ucRemoveArendator;
        private UCRemoveDogovor ucRemoveDogovor;
        public ArendodatelInterface(Arendodatel arendodatel)
        {
            InitializeComponent();
            currArendodatel = arendodatel;
        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            HideAll();
            ucSearchRoom = new();
            ucSearchRoom.Location = new Point(200, 75);
            this.Controls.Add(ucSearchRoom);
            ucSearchRoom.Show();
        }
        private void ArendodatelInterface_Load(object sender, EventArgs e)
        {
            ucSearchRoom = new();
            ucSearchRoom.Location = new Point(200, 75);
            this.Controls.Add(ucSearchRoom);

            ucKatalog = new();
            ucKatalog.Location = new Point(200, 75);
            this.Controls.Add(ucKatalog);

            ucMyDogovors = new(currArendodatel.LoginArendodatel);
            ucMyDogovors.Location = new Point(200, 75);
            this.Controls.Add(ucMyDogovors);

            ucAddArendator = new();
            ucAddArendator.Location = new Point(200, 75);
            this.Controls.Add(ucAddArendator);

            ucAddDogovor = new(currArendodatel);
            ucAddDogovor.Location = new Point(200, 75);
            this.Controls.Add(ucAddDogovor);

            ucAllArendators = new(currArendodatel);
            ucAllArendators.Location = new Point(200, 75);
            this.Controls.Add(ucAllArendators);

            ucAddRoom = new();
            ucAddRoom.Location = new Point(200, 75);
            this.Controls.Add(ucAddRoom);

            ucRemoveRoom = new();
            ucRemoveRoom.Location = new Point(200, 75);
            this.Controls.Add(ucRemoveRoom);

            ucRemoveArendator = new();
            ucRemoveArendator.Location = new Point(200, 75);
            this.Controls.Add(ucRemoveArendator);

            ucRemoveDogovor = new();
            ucRemoveDogovor.Location = new Point(200, 75);
            this.Controls.Add(ucRemoveDogovor);
            HideAll();
        }
        private void HideAll()
        {
            //ucMyKabinet.Hide();
            ucRemoveRoom.Hide();
            ucMyDogovors.Hide();
            ucSearchRoom.Hide();
            ucKatalog.Hide();
            ucAddArendator.Hide();
            ucAddDogovor.Hide();
            ucAllArendators.Hide();
            ucAddRoom.Hide();
            ucRemoveArendator.Hide();
            ucRemoveDogovor.Hide();
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            HideAll();
            ucKatalog = new();
            ucKatalog.Location = new Point(200, 75);
            this.Controls.Add(ucKatalog);
            ucKatalog.Show();

        }

        private void btnMyDogovor_Click(object sender, EventArgs e)
        {
            HideAll();
            ucMyDogovors = new(currArendodatel.LoginArendodatel);
            ucMyDogovors.Location = new Point(200, 75);
            this.Controls.Add(ucMyDogovors);
            ucMyDogovors.Show();
        }

        private void btnAddArendator_Click(object sender, EventArgs e)
        {
            HideAll();
            ucAddArendator = new();
            ucAddArendator.Location = new Point(200, 75);
            this.Controls.Add(ucAddArendator);
            ucAddArendator.Show();
        }

        private void btnAddDogovor_Click(object sender, EventArgs e)
        {
            HideAll();
            ucAddDogovor = new(currArendodatel);
            ucAddDogovor.Location = new Point(200, 75);
            this.Controls.Add(ucAddDogovor);
            ucAddDogovor.Show();
        }

        private void btnAllArendators_Click(object sender, EventArgs e)
        {
            HideAll();
            ucAllArendators = new(currArendodatel);
            ucAllArendators.Location = new Point(200, 75);
            this.Controls.Add(ucAllArendators);
            ucAllArendators.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            HideAll();
            ucAddRoom = new();
            ucAddRoom.Location = new Point(200, 75);
            this.Controls.Add(ucAddRoom);
            ucAddRoom.Show();
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            HideAll();
            ucRemoveRoom = new();
            ucRemoveRoom.Location = new Point(200, 75);
            this.Controls.Add(ucRemoveRoom);
            ucRemoveRoom.Show();
        }

        private void btnRemoveArendator_Click(object sender, EventArgs e)
        {
            HideAll();
            ucRemoveArendator = new();
            ucRemoveArendator.Location = new Point(200, 75);
            this.Controls.Add(ucRemoveArendator);
            ucRemoveArendator.Show();
        }

        private void btnRemoveDogovor_Click(object sender, EventArgs e)
        {
            HideAll();
            ucRemoveDogovor = new();
            ucRemoveDogovor.Location = new Point(200, 75);
            this.Controls.Add(ucRemoveDogovor);
            ucRemoveDogovor.Show();
        }
    }
}
