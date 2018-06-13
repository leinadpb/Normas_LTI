/**
 * AUTHOR: DANIEL JOSE PEÑA BERROA
 * PUESTO: AUXILIAR DEL LABORATORIO DE TI - INTEC
 * CARRERA: INGENIERIA DE SOFTWARE
 * 
 * PROPIETARIO: INSTITUTO TECNOLOGICO DE SANTO DOMINGO (INTEC)
 * DESCRIPCION: DAR A CONOCER LAS NORMAS DE USO DEL LABORATORIO DE TI A TODOS LOS ESTUDIANTES QUE LO UTILICEN.
 *              SE PRETENDE CAPTURAR DE ALGUNA FORMA UNA CONSTANCIA DE QUE EL ESTUDIANTE A LEIDO Y ACEPTADO ESTAS NORMAS.
 *              A SU VEZ, SE DEBE PODER GENERAR E IMPRIMIR REPORTES DE ESTUDIANTES QUE HAN FIRMADO POR ASIGNATURA, PROFESOR Y TRIMESTRE.
 *              
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormasLTI
{
    static class Program
    {

        private static StudentModel _context = new StudentModel();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            String info = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            String displayName = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName;

            int charLocation = info.IndexOf("\\");
            string loginName = info.Substring(charLocation + 1);
            string domain = info.Substring(0, charLocation);
            string userDisplayName = displayName;

            bool isStudent = false;
            if (domain.ToUpper().Equals("INTEC")) // Student user
            {
                isStudent = true;
            }

            /**
             * Determine if there is an active trimestre. If there isn't show "Rules Reminder", 
             * otherwise verify if the user exists in the appropiate table.
             * */
            var trimestres = _context.Trimestres.Select(t => t);
            Trimestre trimeste_actual = null;
            foreach(Trimestre t in trimestres)
            {
                if(t.Active == 1)
                {
                    trimeste_actual = t;
                    break;
                }
            }

            if(trimeste_actual != null)
            {
                //Existe un trimestre activo
                /**
                 * Determine if the user logged in exist in the table. If it isn't show "Main Form"
                 * Otherwise, Get the user and verify if it's registered date is beetween the start and end date date of the trimestre.
                 * */
                if (isStudent) //look in Students table
                {
                    Student student = null;
                    try
                    {
                        //Get user
                        student = _context.Students.Where(s => s.LoginName.ToLower().Equals(loginName.ToLower())).FirstOrDefault();

                        if(student != null)
                        {
                            //If the user in the table have signed in the trimestre_actual tirmestre dates range.
                            if (student.RegisteredDate >= trimeste_actual.StartDate && student.RegisteredDate <= trimeste_actual.EndDate)
                            {
                                //Show "Rules Reminder"
                                Application.Run(new RulesReminder(userDisplayName));
                            }
                            else
                            {
                                //Move user to History

                                //  1. Create HistoryStudent object
                                HistoryStudent Hstudent = new HistoryStudent()
                                {
                                    LoginName = student.LoginName,
                                    DisplayName = student.DisplayName,
                                    RegisteredDate = student.RegisteredDate,
                                    Domain = student.Domain,
                                    ComputerName = student.ComputerName,
                                    SubjectName = student.SubjectName,
                                    SubjectSection = student.SubjectSection,
                                    TeacherID = student.TeacherID
                                };
                                _context.HistoryStudents.Add(Hstudent);
                                _context.SaveChanges();

                                //  2. Delete student form Table Students
                                _context.Students.Remove(student);
                                _context.SaveChanges();

                                //Show "Main Form"
                                Application.Run(new MainForm(isStudent, info, displayName));
                            }
                        }
                        else
                        {
                            //Show main form
                            Application.Run(new MainForm(isStudent, info, displayName));
                        }
                    }catch(Exception exp)
                    {
                        Console.WriteLine("Error: " + exp.Message);
                        Application.Run(new RulesReminder(userDisplayName));
                        Application.Exit();
                    }                 
                }
                else //look in teachers table
                {
                    Teacher teacher = null;
                    try
                    {
                        //Get user
                        teacher = _context.Teachers.Where(t => t.LoginName.ToLower().Equals(loginName.ToLower())).FirstOrDefault();

                        if (teacher != null)
                        {
                            //If the user in the table have signed in the trimestre_actual tirmestre dates range.
                            if (teacher.RegisteredDate >= trimeste_actual.StartDate && teacher.RegisteredDate <= trimeste_actual.EndDate)
                            {
                                //Show "Rules Reminder"
                                Application.Run(new RulesReminder(userDisplayName));
                            }
                            else
                            {
                                //Move user to History

                                //  1. Create HistoryStudent object
                                HistoryTeacher Hteacher = new HistoryTeacher()
                                {
                                    LoginName = teacher.LoginName,
                                    DisplayName = teacher.DisplayName,
                                    RegisteredDate = teacher.RegisteredDate,
                                    Domain = teacher.Domain,
                                    ComputerName = teacher.ComputerName
                                };
                                _context.HistoryTeachers.Add(Hteacher);
                                _context.SaveChanges();

                                //  2. Delete student form Table Students
                                _context.Teachers.Remove(teacher);
                                _context.SaveChanges();

                                //Show "Main Form"
                                Application.Run(new MainForm(isStudent, info, displayName));
                            }
                        }
                        else
                        {
                            //Show main form
                            Application.Run(new MainForm(isStudent, info, displayName));
                        }
                    }
                    catch (Exception exp)
                    {
                        Console.WriteLine("Error: " + exp.Message);
                        Application.Run(new RulesReminder(userDisplayName));
                        Application.Exit();
                    }
                }
            }
            else
            {
                //No existe trimestre activo
                Application.Run(new RulesReminder(userDisplayName));
            }
        }
    }
}
