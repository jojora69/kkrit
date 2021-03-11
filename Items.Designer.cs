
namespace _41
{
    partial class Items
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
            this.list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.add_item = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.add_user = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(12, 51);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(477, 310);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID товара";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            this.columnHeader2.Width = 162;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Количество";
            this.columnHeader3.Width = 76;
            // 
            // add_item
            // 
            this.add_item.Location = new System.Drawing.Point(517, 125);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(261, 44);
            this.add_item.TabIndex = 1;
            this.add_item.Text = "Добавить товар";
            this.add_item.UseVisualStyleBackColor = true;
            this.add_item.Click += new System.EventHandler(this.add_item_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(395, 8);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(94, 37);
            this.Refresh.TabIndex = 5;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // add_user
            // 
            this.add_user.Location = new System.Drawing.Point(517, 51);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(261, 45);
            this.add_user.TabIndex = 6;
            this.add_user.Text = "Добавить пользователей";
            this.add_user.UseVisualStyleBackColor = true;
            this.add_user.Click += new System.EventHandler(this.add_user_Click);
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(713, 403);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(75, 35);
            this.closebutton.TabIndex = 7;
            this.closebutton.Text = "Выход";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Цена";
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.add_user);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.add_item);
            this.Controls.Add(this.list);
            this.Name = "Items";
            this.Text = "Items";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button add_user;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}