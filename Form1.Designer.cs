namespace HttpStressClient
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_request = new System.Windows.Forms.Timer(this.components);
            this.textBox_timer_msc = new System.Windows.Forms.TextBox();
            this.label_timer_msc = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.label_url = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer_request
            // 
            this.timer_request.Tick += new System.EventHandler(this.timer_request_Tick);
            // 
            // textBox_timer_msc
            // 
            this.textBox_timer_msc.Location = new System.Drawing.Point(12, 42);
            this.textBox_timer_msc.Name = "textBox_timer_msc";
            this.textBox_timer_msc.Size = new System.Drawing.Size(100, 20);
            this.textBox_timer_msc.TabIndex = 0;
            this.textBox_timer_msc.Text = "100";
            // 
            // label_timer_msc
            // 
            this.label_timer_msc.AutoSize = true;
            this.label_timer_msc.Location = new System.Drawing.Point(118, 45);
            this.label_timer_msc.Name = "label_timer_msc";
            this.label_timer_msc.Size = new System.Drawing.Size(108, 13);
            this.label_timer_msc.TabIndex = 1;
            this.label_timer_msc.Text = "Timer msc for request";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(236, 73);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(100, 23);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(342, 73);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(100, 23);
            this.button_stop.TabIndex = 2;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(12, 12);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(342, 20);
            this.textBox_url.TabIndex = 0;
            this.textBox_url.Text = "http://localhost";
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(360, 15);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(82, 13);
            this.label_url.TabIndex = 1;
            this.label_url.Text = "URL for request";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 110);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_url);
            this.Controls.Add(this.label_timer_msc);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.textBox_timer_msc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HttpStressClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_request;
        private System.Windows.Forms.TextBox textBox_timer_msc;
        private System.Windows.Forms.Label label_timer_msc;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.Label label_url;
    }
}

