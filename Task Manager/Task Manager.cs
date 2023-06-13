using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class Task_Manager : Form
    {
        TaskManaging con;
        TaskManaging dt;
        public Task_Manager()
        {
            InitializeComponent();
            con = new TaskManaging();
            dt = new TaskManaging();
            ShowTasks();
            //removing the unnecessary row
            Tasks_gridview.AllowUserToAddRows = false;
            //Hide the id column
            Tasks_gridview.Columns[0].Visible = false;
            Tasks_gridview.CellContentClick += Tasks_gridview_CellContentClick;

            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Chk";
            dgvCmb.HeaderText = "CheckBox";
            Tasks_gridview.Columns.Add(dgvCmb);
        }
        private void ShowTasks()
        {
            string query = "Select * from TasksTbl";
            //Tasks_listBox.DataSource = con.GetData(query);
            Tasks_gridview.DataSource = dt.GetData(query);
        }
        private void Add_task_button_Click(object sender, EventArgs e)//Adding the task
        {
            try
            {
                if (Add_task_box.Text == "")
                {
                    MessageBox.Show("Enter a data!");
                }
                else
                {
                    string taskBox = Add_task_box.Text;
                    string taskDescripBox = Description_texbox.Text;
                    DateTime taskTime = DateTime.Parse(Time_textbox.Text);
                    //Adding the task to the database
                    string query = $"insert into TasksTbl (Task_name, Description, Task_Time) values('{taskBox}', '{taskDescripBox}', '{taskTime:yyyy-MM-dd}')";
                    //checks for tasks with the same name
                    if (con.GetTaskCount(taskBox) > 0)
                    {
                        MessageBox.Show("There is a task with the same name.");
                        return;
                    }

                    query = string.Format(query, taskBox, taskDescripBox, taskTime);
                    con.SetData(query);
                    ShowTasks();
                    MessageBox.Show("New task is added");
                    Add_task_box.Text = "";
                    Description_texbox.Text = "";
                    Time_textbox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Edit_task_button_Click(object sender, EventArgs e)//Editing the tasks
        {
            try
            {
                if (Add_task_box.Text == "")
                {
                    MessageBox.Show("Enter a data!");
                }
                else
                {
                    var row = Tasks_gridview.CurrentRow;
                    string task = Add_task_box.Text;
                    string taskDescription = Description_texbox.Text;
                    string taskTime = Time_textbox.Text;
                    //View which task to edit
                    int taskId = Convert.ToInt32(row.Cells["id"].Value);
                    string query = $"Update TasksTbl set Task_name = '{task}' where id = '{taskId}'";
                    query = string.Format(query, Add_task_box.Text);
                    con.SetData(query);

                    string queryDescription = $"Update TasksTbl set Description = '{taskDescription}' where id = '{taskId}'";
                    con.SetData(queryDescription);

                    string queryTime = $"Update TasksTbl set Task_Time = '{taskTime}' where id = '{taskId}'";
                    con.SetData(queryTime);

                    ShowTasks();
                    MessageBox.Show("The task is updated.");
                    Add_task_box.Text = "";
                    Description_texbox.Text = "";
                    Time_textbox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_task_button_Click(object sender, EventArgs e)//Deleting the task
        {
            try
            {
                if (Add_task_box.Text == "")
                {
                    MessageBox.Show("Enter a data!");
                }
                else
                {
                    var row = Tasks_gridview.CurrentRow;
                    //View which task to be deleted
                    int taskId = Convert.ToInt32(row.Cells["id"].Value);
                    string query = $"Delete from TasksTbl where id = {taskId}";
                    query = string.Format(query, Add_task_box.Text);
                    con.SetData(query);
                    ShowTasks();
                    MessageBox.Show("The task is deleted.");
                    Add_task_box.Text = "";
                    Description_texbox.Text = "";
                    Time_textbox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Tasks_gridview_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            Add_task_box.Text = Convert.ToString(Tasks_gridview[2, row].Value);
            Description_texbox.Text = Convert.ToString(Tasks_gridview[3, row].Value);
            if (Tasks_gridview[4, row].Value is DateTime timeValue)
            {
                Time_textbox.Text = timeValue.ToString("yyyy-MM-dd");
            }
        }
        private bool isEventHandled = false;
        private void Tasks_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)//Check if a checkbox is selected
        {
            //Method for returning from the event
            if (isEventHandled == true)
            {
                isEventHandled = false;
                return;
            }
            if (e.ColumnIndex == Tasks_gridview.Columns["Chk"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkboxCell = (DataGridViewCheckBoxCell)Tasks_gridview.Rows[e.RowIndex].Cells["Chk"];
                bool isChecked = false;

                if (checkboxCell.Value != null && (bool)checkboxCell.Value)
                {
                    isChecked = false;
                }
                else
                {
                    isChecked = true;
                }

                checkboxCell.Value = isChecked;

                if (isChecked)
                {
                    int taskId = Convert.ToInt32(Tasks_gridview.Rows[e.RowIndex].Cells["id"].Value);
                    string query = $"DELETE FROM TasksTbl WHERE id = {taskId}";
                    con.SetData(query);

                    MessageBox.Show("The task is completed.");

                    // Removing the row from the Tasks_gridview
                    Tasks_gridview.Rows.RemoveAt(e.RowIndex);
                    // Set the flag to true to indicate event handling
                    isEventHandled = true;
                }
            }
        }
    }
}
