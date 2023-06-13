
namespace Task_Manager
{
    partial class Task_Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tasks_label = new System.Windows.Forms.Label();
            this.Add_task_label = new System.Windows.Forms.Label();
            this.Add_task_box = new System.Windows.Forms.TextBox();
            this.Add_task_button = new System.Windows.Forms.Button();
            this.Delete_task_button = new System.Windows.Forms.Button();
            this.Description_texbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit_task_button = new System.Windows.Forms.Button();
            this.Tasks_gridview = new System.Windows.Forms.DataGridView();
            this.Time_textbox = new System.Windows.Forms.TextBox();
            this.Time_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tasks_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Tasks_label
            // 
            this.Tasks_label.AutoSize = true;
            this.Tasks_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tasks_label.Location = new System.Drawing.Point(691, 30);
            this.Tasks_label.Name = "Tasks_label";
            this.Tasks_label.Size = new System.Drawing.Size(88, 31);
            this.Tasks_label.TabIndex = 0;
            this.Tasks_label.Text = "Tasks";
            // 
            // Add_task_label
            // 
            this.Add_task_label.AutoSize = true;
            this.Add_task_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_task_label.Location = new System.Drawing.Point(12, 92);
            this.Add_task_label.Name = "Add_task_label";
            this.Add_task_label.Size = new System.Drawing.Size(103, 24);
            this.Add_task_label.TabIndex = 1;
            this.Add_task_label.Text = "Task name";
            // 
            // Add_task_box
            // 
            this.Add_task_box.Location = new System.Drawing.Point(12, 119);
            this.Add_task_box.Name = "Add_task_box";
            this.Add_task_box.Size = new System.Drawing.Size(239, 22);
            this.Add_task_box.TabIndex = 2;
            // 
            // Add_task_button
            // 
            this.Add_task_button.Location = new System.Drawing.Point(12, 347);
            this.Add_task_button.Name = "Add_task_button";
            this.Add_task_button.Size = new System.Drawing.Size(75, 23);
            this.Add_task_button.TabIndex = 3;
            this.Add_task_button.Text = "Add";
            this.Add_task_button.UseVisualStyleBackColor = true;
            this.Add_task_button.Click += new System.EventHandler(this.Add_task_button_Click);
            // 
            // Delete_task_button
            // 
            this.Delete_task_button.Location = new System.Drawing.Point(93, 395);
            this.Delete_task_button.Name = "Delete_task_button";
            this.Delete_task_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_task_button.TabIndex = 4;
            this.Delete_task_button.Text = "Delete";
            this.Delete_task_button.UseVisualStyleBackColor = true;
            this.Delete_task_button.Click += new System.EventHandler(this.Delete_task_button_Click);
            // 
            // Description_texbox
            // 
            this.Description_texbox.Location = new System.Drawing.Point(12, 217);
            this.Description_texbox.Name = "Description_texbox";
            this.Description_texbox.Size = new System.Drawing.Size(239, 22);
            this.Description_texbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description";
            // 
            // Edit_task_button
            // 
            this.Edit_task_button.Location = new System.Drawing.Point(176, 347);
            this.Edit_task_button.Name = "Edit_task_button";
            this.Edit_task_button.Size = new System.Drawing.Size(75, 23);
            this.Edit_task_button.TabIndex = 9;
            this.Edit_task_button.Text = "Edit";
            this.Edit_task_button.UseVisualStyleBackColor = true;
            this.Edit_task_button.Click += new System.EventHandler(this.Edit_task_button_Click);
            // 
            // Tasks_gridview
            // 
            this.Tasks_gridview.BackgroundColor = System.Drawing.Color.White;
            this.Tasks_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tasks_gridview.GridColor = System.Drawing.Color.Turquoise;
            this.Tasks_gridview.Location = new System.Drawing.Point(286, 92);
            this.Tasks_gridview.Name = "Tasks_gridview";
            this.Tasks_gridview.RowHeadersWidth = 51;
            this.Tasks_gridview.RowTemplate.Height = 24;
            this.Tasks_gridview.Size = new System.Drawing.Size(846, 396);
            this.Tasks_gridview.TabIndex = 10;
            this.Tasks_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tasks_gridview_CellContentClick);
            this.Tasks_gridview.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Tasks_gridview_RowHeaderMouseDoubleClick);
            // 
            // Time_textbox
            // 
            this.Time_textbox.Location = new System.Drawing.Point(12, 299);
            this.Time_textbox.Name = "Time_textbox";
            this.Time_textbox.Size = new System.Drawing.Size(239, 22);
            this.Time_textbox.TabIndex = 11;
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time_label.Location = new System.Drawing.Point(12, 272);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(53, 24);
            this.Time_label.TabIndex = 12;
            this.Time_label.Text = "Time";
            // 
            // Task_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 550);
            this.Controls.Add(this.Time_label);
            this.Controls.Add(this.Time_textbox);
            this.Controls.Add(this.Tasks_gridview);
            this.Controls.Add(this.Edit_task_button);
            this.Controls.Add(this.Description_texbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_task_button);
            this.Controls.Add(this.Add_task_button);
            this.Controls.Add(this.Add_task_box);
            this.Controls.Add(this.Add_task_label);
            this.Controls.Add(this.Tasks_label);
            this.Name = "Task_Manager";
            this.Text = "Task_Manager";
            ((System.ComponentModel.ISupportInitialize)(this.Tasks_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tasks_label;
        private System.Windows.Forms.Label Add_task_label;
        private System.Windows.Forms.TextBox Add_task_box;
        private System.Windows.Forms.Button Add_task_button;
        private System.Windows.Forms.Button Delete_task_button;
        private System.Windows.Forms.TextBox Description_texbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Edit_task_button;
        private System.Windows.Forms.DataGridView Tasks_gridview;
        private System.Windows.Forms.TextBox Time_textbox;
        private System.Windows.Forms.Label Time_label;
    }
}