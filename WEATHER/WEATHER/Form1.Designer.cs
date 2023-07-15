namespace WEATHER
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TbCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_windspeed = new System.Windows.Forms.Label();
            this.lab_pressure = new System.Windows.Forms.Label();
            this.lab_sunset = new System.Windows.Forms.Label();
            this.lab_sunrise = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lab_details = new System.Windows.Forms.Label();
            this.lab_condition = new System.Windows.Forms.Label();
            this.pic_icon = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_temp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_humidity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_lat = new System.Windows.Forms.Label();
            this.lab_lon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // TbCity
            // 
            this.TbCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbCity.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TbCity.Location = new System.Drawing.Point(296, 65);
            this.TbCity.MaximumSize = new System.Drawing.Size(100, 40);
            this.TbCity.MinimumSize = new System.Drawing.Size(400, 30);
            this.TbCity.Name = "TbCity";
            this.TbCity.Size = new System.Drawing.Size(400, 30);
            this.TbCity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(190, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "CITY:";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(702, 58);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(138, 45);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(439, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wind speed:";
            // 
            // lab_windspeed
            // 
            this.lab_windspeed.AutoSize = true;
            this.lab_windspeed.BackColor = System.Drawing.Color.Transparent;
            this.lab_windspeed.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_windspeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_windspeed.Location = new System.Drawing.Point(593, 271);
            this.lab_windspeed.Name = "lab_windspeed";
            this.lab_windspeed.Size = new System.Drawing.Size(53, 29);
            this.lab_windspeed.TabIndex = 5;
            this.lab_windspeed.Text = "N/A";
            // 
            // lab_pressure
            // 
            this.lab_pressure.AutoSize = true;
            this.lab_pressure.BackColor = System.Drawing.Color.Transparent;
            this.lab_pressure.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pressure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_pressure.Location = new System.Drawing.Point(550, 351);
            this.lab_pressure.Name = "lab_pressure";
            this.lab_pressure.Size = new System.Drawing.Size(53, 29);
            this.lab_pressure.TabIndex = 6;
            this.lab_pressure.Text = "N/A";
            // 
            // lab_sunset
            // 
            this.lab_sunset.AutoSize = true;
            this.lab_sunset.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunset.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_sunset.Location = new System.Drawing.Point(152, 500);
            this.lab_sunset.Name = "lab_sunset";
            this.lab_sunset.Size = new System.Drawing.Size(53, 29);
            this.lab_sunset.TabIndex = 13;
            this.lab_sunset.Text = "N/A";
            // 
            // lab_sunrise
            // 
            this.lab_sunrise.AutoSize = true;
            this.lab_sunrise.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunrise.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunrise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_sunrise.Location = new System.Drawing.Point(152, 427);
            this.lab_sunrise.Name = "lab_sunrise";
            this.lab_sunrise.Size = new System.Drawing.Size(53, 29);
            this.lab_sunrise.TabIndex = 14;
            this.lab_sunrise.Text = "N/A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(45, 500);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 29);
            this.label13.TabIndex = 15;
            this.label13.Text = "Sunset:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(45, 427);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 29);
            this.label14.TabIndex = 16;
            this.label14.Text = "Sunrise:";
            // 
            // lab_details
            // 
            this.lab_details.AutoSize = true;
            this.lab_details.BackColor = System.Drawing.Color.Transparent;
            this.lab_details.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_details.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_details.Location = new System.Drawing.Point(45, 351);
            this.lab_details.Name = "lab_details";
            this.lab_details.Size = new System.Drawing.Size(90, 29);
            this.lab_details.TabIndex = 17;
            this.lab_details.Text = "Details:";
            // 
            // lab_condition
            // 
            this.lab_condition.AutoSize = true;
            this.lab_condition.BackColor = System.Drawing.Color.Transparent;
            this.lab_condition.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_condition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_condition.Location = new System.Drawing.Point(45, 271);
            this.lab_condition.Name = "lab_condition";
            this.lab_condition.Size = new System.Drawing.Size(128, 29);
            this.lab_condition.TabIndex = 18;
            this.lab_condition.Text = "Conditions:";
            // 
            // pic_icon
            // 
            this.pic_icon.BackColor = System.Drawing.Color.Transparent;
            this.pic_icon.Location = new System.Drawing.Point(50, 135);
            this.pic_icon.Name = "pic_icon";
            this.pic_icon.Size = new System.Drawing.Size(103, 97);
            this.pic_icon.TabIndex = 19;
            this.pic_icon.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(439, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Pressurs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(439, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Temperature:";
            // 
            // lab_temp
            // 
            this.lab_temp.AutoSize = true;
            this.lab_temp.BackColor = System.Drawing.Color.Transparent;
            this.lab_temp.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_temp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_temp.Location = new System.Drawing.Point(600, 427);
            this.lab_temp.Name = "lab_temp";
            this.lab_temp.Size = new System.Drawing.Size(53, 29);
            this.lab_temp.TabIndex = 22;
            this.lab_temp.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(439, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Humidity:";
            // 
            // lab_humidity
            // 
            this.lab_humidity.AutoSize = true;
            this.lab_humidity.BackColor = System.Drawing.Color.Transparent;
            this.lab_humidity.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_humidity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_humidity.Location = new System.Drawing.Point(565, 500);
            this.lab_humidity.Name = "lab_humidity";
            this.lab_humidity.Size = new System.Drawing.Size(53, 29);
            this.lab_humidity.TabIndex = 24;
            this.lab_humidity.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(838, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Latitude:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(835, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Longitude:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(777, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 29);
            this.label8.TabIndex = 27;
            this.label8.Text = "Co-ordinates:";
            // 
            // lab_lat
            // 
            this.lab_lat.AutoSize = true;
            this.lab_lat.BackColor = System.Drawing.Color.Transparent;
            this.lab_lat.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_lat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_lat.Location = new System.Drawing.Point(951, 427);
            this.lab_lat.Name = "lab_lat";
            this.lab_lat.Size = new System.Drawing.Size(53, 29);
            this.lab_lat.TabIndex = 28;
            this.lab_lat.Text = "N/A";
            // 
            // lab_lon
            // 
            this.lab_lon.AutoSize = true;
            this.lab_lon.BackColor = System.Drawing.Color.Transparent;
            this.lab_lon.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_lon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_lon.Location = new System.Drawing.Point(969, 351);
            this.lab_lon.Name = "lab_lon";
            this.lab_lon.Size = new System.Drawing.Size(53, 29);
            this.lab_lon.TabIndex = 29;
            this.lab_lon.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1075, 538);
            this.Controls.Add(this.lab_lon);
            this.Controls.Add(this.lab_lat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lab_humidity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_temp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pic_icon);
            this.Controls.Add(this.lab_condition);
            this.Controls.Add(this.lab_details);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lab_sunrise);
            this.Controls.Add(this.lab_sunset);
            this.Controls.Add(this.lab_pressure);
            this.Controls.Add(this.lab_windspeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbCity);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_windspeed;
        private System.Windows.Forms.Label lab_pressure;
        private System.Windows.Forms.Label lab_sunset;
        private System.Windows.Forms.Label lab_sunrise;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lab_details;
        private System.Windows.Forms.Label lab_condition;
        private System.Windows.Forms.PictureBox pic_icon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_temp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_humidity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_lat;
        private System.Windows.Forms.Label lab_lon;
    }
}

