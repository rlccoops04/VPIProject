using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPIProject
{
    public partial class AddDogovor : UserControl
    {
        RentRoomContext db = new();
        Arendodatel arendodatel;
        private List<int?> unfreerooms = new();
        public AddDogovor(Arendodatel arendodatel)
        {
            this.arendodatel = arendodatel;
            InitializeComponent();
        }
        private void AddDogovor_Load(object sender, EventArgs e)
        {
            foreach (Dogovor dogovor in db.Dogovors.ToList())
            {
                unfreerooms.Add(dogovor.NumRoom);
            }
            foreach (Room room in db.Rooms.ToList())
            {
                if (!unfreerooms.Contains(room.NumRoom))
                {
                    cbNumRoom.Items.Add(room.NumRoom);
                }
            }
            foreach (Arendator arendator in db.Arendators.ToList())
            {
                cbArendator.Items.Add(arendator.LoginArendator);
            }
        }

        private void btnAddDogovor_Click(object sender, EventArgs e)
        {
            if (cbArendator.Text != "" && cbNumRoom.Text != "" &&
                tbDateEnd.Text != "" && tbDateStart.Text != "")
            {
                try
                {
                    Dogovor dogovor = new Dogovor
                    {
                        NumRoom = Convert.ToInt32(cbNumRoom.Text),
                        LoginArendator = cbArendator.Text,
                        LoginArendodatel = arendodatel.LoginArendodatel,
                        DataStartDogovor = Convert.ToDateTime(tbDateStart.Text),
                        DataEndDogovor = Convert.ToDateTime(tbDateEnd.Text)
                    };
                    db.Dogovors.Add(dogovor);
                    db.SaveChanges();

                    cbNumRoom.Text = "";
                    cbArendator.Text = "";
                    tbDateStart.Text = "";
                    tbDateEnd.Text = "";
                }
                catch
                {

                }
            }
        }
    }
}
