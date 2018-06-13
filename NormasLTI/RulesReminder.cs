using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormasLTI
{
    public partial class RulesReminder : Form
    {
        string name;
        public RulesReminder(String name)
        {
            InitializeComponent();
            this.name = name;
            label1.Text = name;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    //MessageBox.Show("Debes aceptar las normas de uso de este laboratorio para continuar utilizando este equipo.", "Laboratorio de Tecnología de la Información");
                    e.Cancel = true;
                    break;
            }
            base.OnFormClosing(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RulesReminder_Load(object sender, EventArgs e)
        {
            
        }

        private void RulesReminder_Load_1(object sender, EventArgs e)
        {

        }
    }
}
