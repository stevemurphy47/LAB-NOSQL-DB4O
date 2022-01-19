using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;

namespace BT_LAB05_CSDL_NC
{
    public class Database
    {
        public static string DbFileName { get; set; }
        public static IObjectContainer Db => Db4oEmbedded.OpenFile(DbFileName);
        public static void CloseDB(IObjectContainer db)
        {
            db.Close();
        }
        //Employees Form
        public static void CreateEmployees(IObjectContainer db, string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nEmps = int.Parse(fin.ReadLine());
                for (int i = 0; i < nEmps; i++)
                {
                    string line = fin.ReadLine();
                    if (line != null)
                    {
                        string[] fields = line.Split(':');
                        string fname = fields[0];
                        char minit = fields[1][0];
                        string lname = fields[2];
                        int ssn = int.Parse(fields[3]);
                        string bdate = fields[4];
                        string address = fields[5];
                        char sex = fields[6][0];
                        float salary = float.Parse(fields[7]);

                        IList<Employee> emps = db.Query(delegate (Employee emp)
                        {
                            return (emp.Ssn == ssn);
                        });
                        if (emps != null && emps.Count != 0)
                            MessageBox.Show("Employee existed");
                        else
                        {
                            Employee e = new Employee
                            {
                                Ssn = ssn,
                                FName = fname,
                                MInit = minit,
                                LName = lname,
                                Address = address,
                                BirthDate = bdate,
                                Salary = salary,
                                Sex = sex
                            };
                            db.Store(e);
                        }
                    }
                }
                fin.Close();
                fs.Close();
            }
        }

        public static void DeleteEmployees(IObjectContainer db, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader fin = new StreamReader(fs);
            int nEmps = int.Parse(fin.ReadLine());
            List<int> ssnL = new List<int>();

            for (int i = 0; i < nEmps; i++)
            {
                string line = fin.ReadLine();
                if (line != null)
                {
                    string[] fields = line.Split(':');
                    int ssn = int.Parse(fields[3]);
                    ssnL.Add(ssn);
                }
            }
            IList<Employee> emps = db.Query(delegate (Employee emp)
            {
                return (ssnL.Contains(emp.Ssn));
            });
            IList<Dependent> dpds = db.Query(delegate (Dependent dpd)
            {
                return (ssnL.Contains(dpd.DependentOf.Ssn));
            });
            IList<Department> dpms = db.Query(delegate (Department dpm)
            {
                return true;
            });

            if (dpms.Count != 0)
            {
                foreach (Department d in dpms)
                {
                    if (d.Employees != null)
                    {
                        foreach (Employee emp in d.Employees.ToList())
                        {
                            if (ssnL.Contains(emp.Ssn))
                            {
                                d.Employees.Remove(emp);
                            }
                            if (d.Employees.Count == 0)
                            {
                                d.Employees = null;
                                break;
                            }
                        }
                    }
                    db.Store(d);
                }
            }
            if (dpds.Count != 0)
            {
                foreach (Dependent d in dpds)
                {
                    db.Delete(d);
                }
            }

            if (emps.Count == 0)
                MessageBox.Show("No employee existed");
            else
            {
                foreach (Employee emp in emps)
                {
                    db.Delete(emp);
                }
            }
            fin.Close();
            fs.Close();
        }

        public static void ModifyEmployees(IObjectContainer db, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader fin = new StreamReader(fs);
            int nEmps = int.Parse(fin.ReadLine());
            for (int i = 0; i < nEmps; i++)
            {
                string line = fin.ReadLine();
                if (line != null)
                {
                    string[] fields = line.Split(':');
                    string fname = fields[0];
                    char minit = fields[1][0];
                    string lname = fields[2];
                    int ssn = int.Parse(fields[3]);
                    string bdate = fields[4];
                    string address = fields[5];
                    char sex = fields[6][0];
                    float salary = float.Parse(fields[7]);

                    IList<Employee> emps = db.Query(delegate (Employee emp)
                    {
                        return (emp.Ssn == ssn);
                    });
                    IList<Dependent> dpds = db.Query(delegate (Dependent dpd)
                    {
                        return (dpd.DependentOf.Ssn == ssn);
                    });
                    IList<Department> dpms = db.Query(delegate (Department dpm)
                    {
                        return (dpm.Manager.Ssn == ssn);
                    });

                    //Employee e = null;
                    if (emps.Count == 0)
                        MessageBox.Show("No employee existed");
                    else
                    {
                        Employee e = emps[0];
                        e.FName = fname;
                        e.MInit = minit;
                        e.LName = lname;
                        e.Address = address;
                        e.BirthDate = bdate;
                        e.Salary = salary;
                        e.Sex = sex;

                        db.Store(e);

                        if (dpds.Count != 0)
                        {
                            foreach (Dependent d in dpds)
                            {
                                d.DependentOf = e;
                                db.Store(d);
                            }
                        }
                        if (dpms.Count != 0)
                        {
                            foreach (Department d in dpms)
                            {
                                d.Manager = e;
                                db.Store(d);
                            }
                        }
                    }
                }
            }
            fin.Close();
            fs.Close();
        }
        //Dependents Form
        public static void CreateDependents(IObjectContainer db, string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nDpds = int.Parse(fin.ReadLine());
                for (int i = 0; i < nDpds; i++)
                {
                    string line = fin.ReadLine();
                    if (line != null)
                    {
                        string[] fields = line.Split(',');
                        int ssn = int.Parse(fields[0]);
                        string name = fields[1];
                        char sex = fields[2][0];
                        string bdate = fields[3];
                        string relationship = fields[4];

                        Dependent d = new Dependent
                        {
                            Name = name,
                            Sex = sex,
                            BirthDate = bdate,
                            Relationship = relationship
                        }; 
                        IList<Employee> emps = db.Query(delegate (Employee emp)
                        {
                            return (emp.Ssn == ssn);
                        });
                        if (emps != null && emps.Count != 0)
                        {
                            d.DependentOf = emps[0];
                            db.Store(d);
                        }
                        else
                        {
                            MessageBox.Show($"No Employees {ssn} exist!");
                        }
                    }
                }
                fin.Close();
                fs.Close();
            }
        }

        public static void DeleteDependents(IObjectContainer db, string fileName) { }

        public static void ModifyDependents(IObjectContainer db, string fileName) { }
        //Department Form
        public static void CreateDepartment(IObjectContainer db, string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nDpms = int.Parse(fin.ReadLine());
                for (int i = 0; i < nDpms; i++)
                {
                    string line = fin.ReadLine();
                    if (line != null)
                    {
                        string[] fields = line.Split(':');
                        int dnumber = int.Parse(fields[0]);
                        string dname = fields[1];
                        List<string> locations = fields[2].Split(',').ToList();

                        IList<Department> depts = db.Query(delegate (Department dept)
                        {
                            return (dept.DNumber == dnumber);
                        });
                        if (depts != null && depts.Count != 0)
                            MessageBox.Show("Department existed");
                        else
                        {
                            Department d = new Department
                            {
                                DNumber = dnumber,
                                DName = dname,
                                Locations = locations
                            };
                            db.Store(d);
                        }
                    }
                }
                fin.Close();
                fs.Close();
            }
        }

        public static void DeleteDepartment(IObjectContainer db, string fileName) { }

        public static void ModifyDepartment(IObjectContainer db, string fileName) { }
        //Project Form
        public static void CreateProject(IObjectContainer db, string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nEmps = int.Parse(fin.ReadLine());
                for (int i = 0; i < nEmps; i++)
                {
                    string line = fin.ReadLine();
                    if (line != null)
                    {
                        string[] fields = line.Split(',');
                        int pnumber = int.Parse(fields[0]);
                        string pname = fields[1];
                        string location = fields[2];

                        IList<Project> prjs = db.Query(delegate (Project prj)
                        {
                            return (prj.PNumber == pnumber);
                        });
                        if (prjs != null && prjs.Count != 0)
                            MessageBox.Show("Project existed");
                        else
                        {
                            Project p = new Project
                            {
                                PNumber = pnumber,
                                PName = pname,
                                Location = location
                            };
                            db.Store(p);
                        }
                    }
                }
                fin.Close();
                fs.Close();
            }
        }

        public static void DeleteProject(IObjectContainer db, string fileName) { }

        public static void ModifyProject(IObjectContainer db, string fileName) { }
        //WorksOn Form
        public static void CreateWorksOn(IObjectContainer db, string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nWrkO = int.Parse(fin.ReadLine());
                for (int i = 0; i < nWrkO; i++)
                {
                    string line = fin.ReadLine();
                    if (line != null)
                    {
                        string[] fields = line.Split(',');
                        int ssn = int.Parse(fields[0]);
                        int pnumber = int.Parse(fields[1]);
                        float hours = float.Parse(fields[2]);

                        WorksOn w = new WorksOn
                        {
                            Hours = hours
                        };

                        IList<Employee> emps = (from Employee emp in db
                                                where emp.Ssn == ssn
                                                select emp).ToList();

                        IList<Project> prjs = (from Project prj in db
                                               where prj.PNumber == pnumber
                                               select prj).ToList();

                        Employee e = null;
                        Project p = null;
                        if(emps != null && emps.Count!=0 && prjs != null && prjs.Count != 0)
                        {
                            e = emps[0];
                            p = prjs[0];
                        }
                        if(e != null && p != null)
                        {
                            w.Employee = e;
                            w.Project = p;
                            db.Store(w);
                        }
                        else
                        {
                            MessageBox.Show($"Employee {e} or Project {p} is not available.");
                        }
                    }
                }
                fin.Close();
                fs.Close();
            }
        }

        public static void DeleteWorksOn(IObjectContainer db, string fileName) { }

        public static void ModifyWorksOn(IObjectContainer db, string fileName) { }
        //Modify DataGridView
        public static void SetDependents(IObjectContainer db, DataGridView dataGridView_Employee)
        {
            IList<Dependent> listDependent = db.Query(delegate (Dependent dept)
            {
                return true;
            });

            if (listDependent.Count != 0)
            {
                if (dataGridView_Employee.ColumnCount != 0)
                {
                    if (!dataGridView_Employee.Columns.Contains("Dependents"))
                    {
                        DataGridViewTextBoxColumn dependentsList = new DataGridViewTextBoxColumn();
                        dependentsList.HeaderText = "Dependents";
                        dependentsList.Name = "Dependents";
                        dataGridView_Employee.Columns.Insert(dataGridView_Employee.Columns["Supervisor"].DisplayIndex - 1, dependentsList);
                    }

                    foreach (DataGridViewRow row in dataGridView_Employee.Rows)
                    {
                        //Reference the ComboBoxCell.
                        //DataGridViewComboBoxCell location = (row.Cells[2] as DataGridViewComboBoxCell);
                        DataGridViewTextBoxCell dependent = (row.Cells["Dependents"] as DataGridViewTextBoxCell);

                        IList<Dependent> dependentName = db.Query(delegate (Dependent dept)
                        {
                            return (dept.DependentOf.Ssn == int.Parse(row.Cells["Ssn"].Value.ToString()));
                        });

                        IList<Employee> emps = db.Query(delegate (Employee emp)
                        {
                            return (emp.Ssn == int.Parse(row.Cells["Ssn"].Value.ToString()) && emp.Dependents != dependentName);
                        });

                        Employee e = null;
                        if (emps != null && emps.Count != 0)
                        {
                            e = emps[0];
                            e.Dependents = dependentName.ToList();
                            db.Store(e);
                        }

                        string defaultText = null;
                        defaultText = string.Join(", ", e.Dependents);
                        dependent.Value = defaultText;
                        //location.DataSource = d.Locations.ToList();
                    }
                }
            }
        }

        public static void SetLocations(IObjectContainer db, DataGridView dataGridView_Department)
        {
            var listDepartment = (from Department dp in db
                                  select dp).ToList();

            if (listDepartment.Count != 0)
            {
                //DataGridViewComboBoxColumn locationsList = new DataGridViewComboBoxColumn();
                int count = 0;
                foreach (DataGridViewColumn column in dataGridView_Department.Columns)
                {
                    if (column.Name == "Locations")
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    DataGridViewTextBoxColumn locationsList = new DataGridViewTextBoxColumn();
                    locationsList.HeaderText = "Locations";
                    locationsList.Name = "Locations";
                    dataGridView_Department.Columns.Insert(dataGridView_Department.Columns["DName"].DisplayIndex + 1, locationsList);
                }

                foreach (DataGridViewRow row in dataGridView_Department.Rows)
                {
                    //Reference the ComboBoxCell.
                    //DataGridViewComboBoxCell location = (row.Cells[2] as DataGridViewComboBoxCell);
                    DataGridViewTextBoxCell location = (row.Cells["Locations"] as DataGridViewTextBoxCell);

                    IList<Department> depts = db.Query(delegate (Department dept)
                    {
                        return (dept.DNumber == int.Parse(row.Cells["DNumber"].Value.ToString()));
                    });
                    Department d = null;
                    if (depts != null && depts.Count != 0)
                    {
                        d = depts[0];
                    }
                    string defaultText = string.Join(", ", d.Locations);
                    location.Value = defaultText;
                    //location.DataSource = d.Locations.ToList();
                }
            }
        }

        public static void SetProjects(IObjectContainer db, DataGridView dataGridView_Department)
        {
            var listDepartment = (from Department dp in db
                                  select dp).ToList();

            if (listDepartment.Count != 0)
            {
                //DataGridViewComboBoxColumn locationsList = new DataGridViewComboBoxColumn();
                int count = 0;
                foreach (DataGridViewColumn column in dataGridView_Department.Columns)
                {
                    if (column.Name == "Projects")
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    DataGridViewTextBoxColumn projectsList = new DataGridViewTextBoxColumn();
                    projectsList.HeaderText = "Projects";
                    projectsList.Name = "Projects";
                    dataGridView_Department.Columns.Insert(dataGridView_Department.Columns["Manager"].DisplayIndex + 1, projectsList);
                }
                foreach (DataGridViewRow row in dataGridView_Department.Rows)
                {
                    //Reference the ComboBoxCell.
                    //DataGridViewComboBoxCell location = (row.Cells[2] as DataGridViewComboBoxCell);
                    DataGridViewTextBoxCell project = (row.Cells["Projects"] as DataGridViewTextBoxCell);

                    IList<Department> depts = db.Query(delegate (Department dept)
                    {
                        return (dept.DNumber == int.Parse(row.Cells["DNumber"].Value.ToString()) && dept.Projects != null);
                    });
                    Department d = null;
                    if (depts != null && depts.Count != 0)
                    {
                        d = depts[0];
                        string defaultText = string.Join(", ", d.Projects);
                        project.Value = defaultText;
                    }
                    //location.DataSource = d.Locations.ToList();
                }
            }
        }

        public static void SetEmployees(IObjectContainer db, DataGridView dataGridView_Department)
        {
            var listDepartment = (from Department dp in db
                                  select dp).ToList();

            if (listDepartment.Count != 0)
            {
                //DataGridViewComboBoxColumn locationsList = new DataGridViewComboBoxColumn();
                int count = 0;
                foreach (DataGridViewColumn column in dataGridView_Department.Columns)
                {
                    if (column.Name == "Employees")
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    DataGridViewTextBoxColumn employeesList = new DataGridViewTextBoxColumn();
                    employeesList.HeaderText = "Employees";
                    employeesList.Name = "Employees";
                    dataGridView_Department.Columns.Insert(dataGridView_Department.Columns["Locations"].DisplayIndex + 1, employeesList);
                }
                foreach (DataGridViewRow row in dataGridView_Department.Rows)
                {
                    //Reference the ComboBoxCell.
                    //DataGridViewComboBoxCell location = (row.Cells[2] as DataGridViewComboBoxCell);
                    DataGridViewTextBoxCell employee = (row.Cells["Employees"] as DataGridViewTextBoxCell);

                    IList<Department> depts = db.Query(delegate (Department dept)
                    {
                        return (dept.DNumber == int.Parse(row.Cells["DNumber"].Value.ToString()) && dept.Employees != null);
                    });

                    Department d = null;
                    if (depts != null && depts.Count != 0)
                    {
                        d = depts[0];
                        string defaultText = string.Join(", ", d.Employees);
                        employee.Value = defaultText;
                    }
                }
            }
        }

        public static void SetEmployeeWorksOn(IObjectContainer db, DataGridView dataGridView_Employee)
        {
            var listWorksOn = (from Employee emp in db
                                  select emp).ToList();

            if (listWorksOn.Count != 0)
            {
                //DataGridViewComboBoxColumn locationsList = new DataGridViewComboBoxColumn();
                int count = 0;
                foreach (DataGridViewColumn column in dataGridView_Employee.Columns)
                {
                    if (column.Name == "WorksOn")
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    DataGridViewTextBoxColumn worksOnList = new DataGridViewTextBoxColumn();
                    worksOnList.HeaderText = "WorksOn";
                    worksOnList.Name = "WorksOn";
                    dataGridView_Employee.Columns.Insert(dataGridView_Employee.Columns["Manages"].DisplayIndex + 1, worksOnList);
                }
                foreach (DataGridViewRow row in dataGridView_Employee.Rows)
                {
                    //Reference the ComboBoxCell.
                    //DataGridViewComboBoxCell location = (row.Cells[2] as DataGridViewComboBoxCell);
                    DataGridViewTextBoxCell worksOn = (row.Cells["WorksOn"] as DataGridViewTextBoxCell);

                    IList<WorksOn> wors = db.Query(delegate (WorksOn wor)
                    {
                        return (wor.Employee.Ssn == int.Parse(row.Cells["Ssn"].Value.ToString()));
                    });

                    IList<Employee> emps = db.Query(delegate (Employee emp)
                    {
                        return (emp.Ssn == int.Parse(row.Cells["Ssn"].Value.ToString()) && emp.WorksOn != wors);
                    });

                    Employee e = null;
                    {
                        e = emps[0];
                        e.WorksOn = new List<WorksOn>();
                        foreach (WorksOn wor in wors)
                        {
                            e.WorksOn.Add(wor);
                        }
                        db.Store(e);
                    }

                    string defaultText = null;
                    defaultText = string.Join(", ", e.WorksOn);
                    worksOn.Value = defaultText;
                    //location.DataSource = d.Locations.ToList();
                }
            }
        }

        public static void SetProjectWorksOn(IObjectContainer db, DataGridView dataGridView_Project)
        {
            var listWorksOn = (from Project prj in db
                               select prj).ToList();

            if (listWorksOn.Count != 0)
            {
                //DataGridViewComboBoxColumn locationsList = new DataGridViewComboBoxColumn();
                int count = 0;
                foreach (DataGridViewColumn column in dataGridView_Project.Columns)
                {
                    if (column.Name == "WorksOn")
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    DataGridViewTextBoxColumn worksOnList = new DataGridViewTextBoxColumn();
                    worksOnList.HeaderText = "WorksOn";
                    worksOnList.Name = "WorksOn";
                    dataGridView_Project.Columns.Insert(dataGridView_Project.Columns["ControlledBy"].DisplayIndex + 1, worksOnList);
                }
                foreach (DataGridViewRow row in dataGridView_Project.Rows)
                {
                    //Reference the ComboBoxCell.
                    //DataGridViewComboBoxCell location = (row.Cells[2] as DataGridViewComboBoxCell);
                    DataGridViewTextBoxCell worksOn = (row.Cells["WorksOn"] as DataGridViewTextBoxCell);

                    IList<WorksOn> wors = db.Query(delegate (WorksOn wor)
                    {
                        return (wor.Project.PNumber == int.Parse(row.Cells["PNumber"].Value.ToString()));
                    });

                    IList<Project> prjs = db.Query(delegate (Project prj)
                    {
                        return (prj.PNumber == int.Parse(row.Cells["PNumber"].Value.ToString()) && prj.WorksOn != wors);
                    });

                    Project p = null;
                    {
                        p = prjs[0];
                        p.WorksOn = new List<WorksOn>();
                        foreach (WorksOn wor in wors)
                        {
                            p.WorksOn.Add(wor);
                        }
                        db.Store(p);
                    }

                    string defaultText = null;
                    defaultText = string.Join(", ", p.WorksOn);
                    worksOn.Value = defaultText;
                    //location.DataSource = d.Locations.ToList();
                }
            }
        }

        public static void SetSupervisees(IObjectContainer db, DataGridView dataGridView_Employee)
        {
            var listEmployee = (from Employee emp in db
                                  select emp).ToList();

            if (listEmployee.Count != 0)
            {
                //DataGridViewComboBoxColumn locationsList = new DataGridViewComboBoxColumn();
                int count = 0;
                foreach (DataGridViewColumn column in dataGridView_Employee.Columns)
                {
                    if (column.Name == "Supervisees")
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    DataGridViewTextBoxColumn superviseesList = new DataGridViewTextBoxColumn();
                    superviseesList.HeaderText = "Supervisees";
                    superviseesList.Name = "Supervisees";
                    dataGridView_Employee.Columns.Insert(11, superviseesList);
                }
                foreach (DataGridViewRow row in dataGridView_Employee.Rows)
                {
                    //Reference the ComboBoxCell.
                    //DataGridViewComboBoxCell location = (row.Cells[2] as DataGridViewComboBoxCell);
                    DataGridViewTextBoxCell supervisor = (row.Cells["Supervisees"] as DataGridViewTextBoxCell);

                    IList<Employee> emps = db.Query(delegate (Employee emp)
                    {
                        return (emp.Ssn == int.Parse(row.Cells["Ssn"].Value.ToString()) && emp.Supervisees != null);
                    });
                    Employee e = null;
                    if (emps != null && emps.Count != 0)
                    {
                        e = emps[0];
                        string defaultText = string.Join(", ", e.Supervisees);
                        supervisor.Value = defaultText;
                    }
                    //location.DataSource = d.Locations.ToList();
                }
            }
        }
        //Insert
        public static void SetManagers(IObjectContainer db, string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nMgrs = int.Parse(fin.ReadLine());
                for (int i = 0; i < nMgrs; i++)
                {
                    string line = fin.ReadLine();
                    string[] fields = line.Split(',');
                    int dno = int.Parse(fields[0]);
                    int essn = int.Parse(fields[1]);
                    string startDate = fields[2];

                    IList<Department> depts = db.Query(delegate (Department dept)
                    {
                        return (dept.DNumber == dno);
                    });

                    IList<Employee> emps = db.Query(delegate (Employee emp)
                    {
                        return (emp.Ssn == essn);
                    });

                    Department d = null;
                    if (depts != null && depts.Count != 0)
                        d = depts[0];

                    Employee e = null;
                    if (emps != null && emps.Count != 0)
                        e = emps[0];

                    if (e != null && d != null)
                    {
                        d.MgrStartDate = startDate;
                        e.Manages = d;
                        d.Manager = e;
                        db.Store(d);
                        db.Store(e);
                    }
                    else
                    {
                        MessageBox.Show("Employee or Department is not available");
                    }
                }
            }
        }

        public static void SetControls(IObjectContainer db, string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nCtrs = int.Parse(fin.ReadLine());
                for (int i = 0; i < nCtrs; i++)
                {
                    string line = fin.ReadLine();
                    string[] fields = line.Split(':');
                    int dno = int.Parse(fields[0]);
                    List<string> pnoLS = fields[1].Split(',').ToList();
                    List<int> pnoLI = pnoLS.Select(s => int.Parse(s)).ToList();

                    IList<Department> depts = db.Query(delegate (Department dept)
                    {
                        return (dept.DNumber == dno);
                    });

                    List<Project> prjL = new List<Project>();
                    foreach (int pno in pnoLI)
                    {
                        var prj = (from Project prj1 in db
                                    where prj1.PNumber == pno
                                    select prj1).Single();
                        prjL.Add(prj);
                    }

                    Department d = null;
                    if (depts != null && depts.Count != 0 && prjL != null && prjL.Count != 0)
                    {
                        d = depts[0];
                        foreach (Project p in prjL)
                        {
                            if(d.Projects == null)
                            {
                                d.Projects = new List<Project>();
                            }
                            if (!d.Projects.Contains(p))
                            {
                                d.Projects.Add(p);
                            }
                            else
                            {
                                MessageBox.Show($"Project {p} exists.");
                            }
                        }
                    }
                    if(d != null)
                    {
                        db.Store(d);
                        foreach (Project p in prjL)
                        {
                            p.ControlledBy = d;
                            db.Store(p);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Department or Projects are not available");
                    }
                }
            }
        }

        public static void SetWorksFor(IObjectContainer db, string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nWrFs = int.Parse(fin.ReadLine());
                for (int i = 0; i < nWrFs; i++)
                {
                    string line = fin.ReadLine();
                    string[] fields = line.Split(':');
                    int dno = int.Parse(fields[0]);
                    List<string> empLS = fields[1].Split(',').ToList();
                    List<int> empLI = empLS.Select(s => int.Parse(s)).ToList();

                    IList<Department> depts = db.Query(delegate (Department dept)
                    {
                        return (dept.DNumber == dno);
                    });

                    List<Employee> empL = new List<Employee>();
                    foreach (int ssn in empLI)
                    {
                        var emp = (from Employee emp1 in db
                                     where emp1.Ssn == ssn
                                     select emp1).ToList();
                        if (emp != null && emp.Count != 0)
                        {
                            empL.Add(emp[0]);
                        }
                    }

                    Department d = null;
                    if (depts != null && depts.Count != 0 && empL != null && empL.Count != 0)
                    {
                        d = depts[0];
                        if (d.Employees == null)
                        {
                            d.Employees = new List<Employee>();
                        }
                        foreach (Employee e in empL)
                        {
                            if (!d.Employees.Contains(e))
                            {
                                d.Employees.Add(e);
                            }
                            else
                            {
                                MessageBox.Show($"Employee {e} exists.");
                            }
                        }
                    }
                    if (d != null)
                    {
                        db.Store(d);
                        foreach (Employee p in empL)
                        {
                            p.WorksFor = d;
                            db.Store(p);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Department or Employees are not available");
                    }
                }
            }
        }

        public static void SetSupervisors(IObjectContainer db, string fileName)
        {
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader fin = new StreamReader(fs);
                int nWrFs = int.Parse(fin.ReadLine());
                for (int i = 0; i < nWrFs; i++)
                {
                    string line = fin.ReadLine();
                    string[] fields = line.Split(':');
                    int ssn = int.Parse(fields[0]);
                    List<string> ssnLS = fields[1].Split(',').ToList();
                    List<int> ssnLI = ssnLS.Select(s => int.Parse(s)).ToList();

                    IList<Employee> emps = db.Query(delegate (Employee emp)
                    {
                        return (emp.Ssn == ssn);
                    });

                    List<Employee> empL = new List<Employee>();
                    foreach (int ssnI in ssnLI)
                    {
                        var emp = (from Employee emp1 in db
                                   where emp1.Ssn == ssnI
                                   select emp1).ToList();
                        if (emp != null && emp.Count != 0)
                        {
                            empL.Add(emp[0]);
                        }
                    }

                    Employee e = null;
                    if (emps != null && emps.Count != 0 && empL != null && empL.Count != 0)
                    {
                        e = emps[0];
                        foreach (Employee emp in empL)
                        {
                            if (e.Supervisees == null)
                            {
                                e.Supervisees = new List<Employee>();
                            }
                            if (!e.Supervisees.Contains(emp))
                            {
                                e.Supervisees.Add(emp);
                            }
                            else
                            {
                                MessageBox.Show($"Supervise {emp} exists.");
                            }
                        }
                    }
                    if (e != null)
                    {
                        db.Store(e);
                        foreach (Employee p in empL)
                        {
                            p.Supervisor = e;
                            db.Store(p);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Supervior or Supervisees are not available");
                    }
                }
            }
        }

    }
}
