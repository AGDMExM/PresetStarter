
namespace Preset_Starter
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listTotalPath = new System.Windows.Forms.ListBox();
            this.button_AddPath = new System.Windows.Forms.Button();
            this.button_DeletePath = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.openFileDialog_Path = new System.Windows.Forms.OpenFileDialog();
            this.button_Accept = new System.Windows.Forms.Button();
            this.button_Run = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listTotalPath
            // 
            this.listTotalPath.FormattingEnabled = true;
            this.listTotalPath.Location = new System.Drawing.Point(12, 12);
            this.listTotalPath.Name = "listTotalPath";
            this.listTotalPath.Size = new System.Drawing.Size(237, 95);
            this.listTotalPath.TabIndex = 0;
            // 
            // button_AddPath
            // 
            this.button_AddPath.Location = new System.Drawing.Point(12, 113);
            this.button_AddPath.Name = "button_AddPath";
            this.button_AddPath.Size = new System.Drawing.Size(118, 23);
            this.button_AddPath.TabIndex = 1;
            this.button_AddPath.Text = "Add";
            this.button_AddPath.UseVisualStyleBackColor = true;
            this.button_AddPath.Click += new System.EventHandler(this.button_AddPath_Click);
            // 
            // button_DeletePath
            // 
            this.button_DeletePath.Location = new System.Drawing.Point(131, 113);
            this.button_DeletePath.Name = "button_DeletePath";
            this.button_DeletePath.Size = new System.Drawing.Size(118, 23);
            this.button_DeletePath.TabIndex = 2;
            this.button_DeletePath.Text = "Delete";
            this.button_DeletePath.UseVisualStyleBackColor = true;
            this.button_DeletePath.Click += new System.EventHandler(this.button_DeletePath_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(131, 142);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(118, 23);
            this.button_Clear.TabIndex = 3;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // openFileDialog_Path
            // 
            this.openFileDialog_Path.FileName = "openFileDialog1";
            // 
            // button_Accept
            // 
            this.button_Accept.Enabled = false;
            this.button_Accept.Location = new System.Drawing.Point(12, 142);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(118, 23);
            this.button_Accept.TabIndex = 4;
            this.button_Accept.Text = "Accept";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(12, 171);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(118, 23);
            this.button_Run.TabIndex = 5;
            this.button_Run.Text = "Run";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(136, 171);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(113, 23);
            this.button_Close.TabIndex = 6;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 199);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.button_Accept);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_DeletePath);
            this.Controls.Add(this.button_AddPath);
            this.Controls.Add(this.listTotalPath);
            this.Name = "MainForm";
            this.Text = "Preset Starter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listTotalPath;
        private System.Windows.Forms.Button button_AddPath;
        private System.Windows.Forms.Button button_DeletePath;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Path;
        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.Button button_Close;
    }
}

