using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormasLTI
{
    public partial class MainForm : Form
    {
        /**
         * Useful variables
         * */
        
        private static string ConfirmationBoxUnChecked = "Debes hacer clic en la casilla de verificación para confirmar estar de acuerdo con las normas de este laboratorio.";

        string RegisteredUserFail = "Lo sentimos, ha ocurrido un error inesperado.";
        private bool UserResgistered = false;

        private StudentModel _context;
        private SubjectModel _contextSubjects;
        private bool isStudent = false;


        String info;
        String displayName;

        private bool dataLoaded = false;
        private bool enableClose = true;

        public MainForm(bool _isStudent, String _info, String _displayName)
        {
            
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            //label4.Text = label4_text;

            info = _info;
            displayName = _displayName;

            isStudent = _isStudent;

            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new StudentModel();
            _contextSubjects = new SubjectModel();
            var reglas = _context.NormasReglas;
            foreach (var regla in reglas)
            {
                Normas.AppendText(regla.NormaID + ") " + regla.NormaContent + "\n\n");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
            if (isStudent) {
  
            }
            else
            {
                DisplaySubjects.Hide();
                SubjectSection.Hide();
                comboBox1.Hide();
                button1.Hide();
            }
            
            int charLocation = info.IndexOf("\\");
            label4.Text = info.Substring(charLocation + 1);
            picLoad.Visible = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    MessageBox.Show("Debes aceptar las normas de uso de este laboratorio para continuar utilizando este equipo.", "Laboratorio de Tecnología de la Información");
                    e.Cancel = true;
                    break;
            }
            base.OnFormClosing(e);
        }

        private async void AcceptRules_Click(object sender, EventArgs e)
        {
            
            if (ConfirmCheck.Checked)
            {
                AcceptRules.Enabled = false;
                picLoad.Visible = true;
                await RegisterUser(); //Try to register the user
                if (parameterIsRegistered.Text.Equals("REGISTERED"))
                {
                    UserResgistered = true;
                }
                picLoad.Visible = false;
                if (UserResgistered)
                {
                    //User registered succesfully...
                    MessageBox.Show(displayName + ": has aceptado estas normas correctamente.");
                }
                else
                {
                    //Something bad happened...
                    MessageBox.Show(RegisteredUserFail);
                    AcceptRules.Enabled = true;
                }

                //Close the app
                Application.Exit();
            }
            else
            {
                //The user didn't check the confirmation box
                MessageBox.Show(ConfirmationBoxUnChecked, "Normas LTI");
            }
        }
        private async Task RegisterUser()
        {
            /**
             * Create a User object - Save it - Display confimation - Close app
             * */


            //MessageBox.Show("Begining registering the user.");
            Int32 id_subject = 0;
            if (button1.Text.Equals("-"))
            {
                id_subject = Int32.Parse(DisplaySubjects.SelectedValue.ToString()); //Id of the selected value of DisplaySubject
            }
            string btn_text1 = button1.Text;

            bool TaskResult = await Task.Run(() => ExecuteSaving(btn_text1, id_subject));

            if (TaskResult)
            {
                parameterIsRegistered.Text = "REGISTERED";
            }
            else
            {
                parameterIsRegistered.Text = "UNREGISTERED";
            }
            

            
        }

        private bool ExecuteSaving(string button1_text, int id_subject)
        {
            bool result = false;

            String info = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            String displayName = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName;

            int charLocation = info.IndexOf("\\");
            string loginName = info.Substring(charLocation + 1);
            string domain = info.Substring(0, charLocation);
            string userDisplayName = displayName;

            DateTime registeredDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            string computerName = Environment.MachineName.ToString();

            if (isStudent)
            {
                //Save the user to the database
                try
                {
                    Student student = new Student()
                    {
                        DisplayName = displayName,
                        LoginName = loginName,
                        Domain = domain,
                        ComputerName = computerName,
                        RegisteredDate = registeredDate
                    };
                    //MessageBox.Show("Student created!: " + student.DisplayName);
                    if (button1_text.Equals("-")) //Not required information
                    {

                        Subject asig = _contextSubjects.Subjects.Where(s => s.SubjectID == id_subject).FirstOrDefault();
                        if (asig != null)
                        {
                            student.SubjectName = asig.SubjectName;
                            student.SubjectCode = asig.SubjectCode;
                            student.SubjectSection = SubjectSection.Text;
                            student.TeacherID = Int32.Parse(comboBox1.SelectedValue.ToString());
                            //MessageBox.Show("Not required inf added to student: " + student.SubjectName);
                        }
                        else
                        {
                            //MessageBox.Show("Asig is null!");
                        }

                    }


                    _context.Students.Add(student);
                    _context.SaveChanges();

                    result = true;
                }
                catch (Exception exp)
                {
                    Console.WriteLine("Error on saving object: " + exp.Message);
                }
            }
            else
            {
                //Save a Teacher/Employee
                try
                {
                    Teacher teacher = new Teacher()
                    {
                        LoginName = loginName,
                        DisplayName = displayName,
                        RegisteredDate = registeredDate,
                        ComputerName = computerName,
                        Domain = domain
                    };
                    _context.Teachers.Add(teacher);
                    _context.SaveChanges();

                    result = true;
                }
                catch (Exception exp)
                {
                    Console.WriteLine("Error on saving object: " + exp.Message);
                }
            }

            return result;
        }

        private void MainTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!dataLoaded)
            {
                //Load combobox information
                this.subjectsTableAdapter.Fill(this.lTISignsDataSet1.Subjects);
                this.teachersTableAdapter.Fill(this.lTISignsDataSet.Teachers);
               dataLoaded = true;
            }

            if (button1.Text.Equals("+"))
            {
                //Enable TextBoxex
                DisplaySubjects.Enabled = true;
                SubjectSection.Enabled = true;
                comboBox1.Enabled = true;
                //SubjectName.Text = "";
                SubjectSection.Text = "01";

                label1.Text = "Nombre asignatura";
                label2.Text = "Sección";
                label3.Text = "Profesor";

                button1.Text = "-";

                DisplaySubjects.SelectedIndex = 1;
                comboBox1.SelectedIndex = 1;

                //Refresh Teachers List
                this.teachersTableAdapter.Fill(this.lTISignsDataSet.Teachers);

            }
            else
            {
                //Disable Textboxex
                DisplaySubjects.Enabled = false;
                SubjectSection.Enabled = false;
                comboBox1.Enabled = false;
               // SubjectName.Text = "Nombre de asignatura";
                SubjectSection.Text = "Sección";

                label1.Text = "";
                label2.Text = "";
                label3.Text = "";

                button1.Text = "+";

                DisplaySubjects.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;

            }
        }

    }
}
