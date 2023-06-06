namespace AppWeather
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.weatherIconBox = new System.Windows.Forms.PictureBox();
            this.temperatureL = new System.Windows.Forms.Label();
            this.pressureL = new System.Windows.Forms.Label();
            this.WindSpeedL = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.getFiveDay = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.dateLabel.Location = new System.Drawing.Point(75, 113);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(136, 38);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "tanggal";
            this.dateLabel.Visible = false;
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // weatherIconBox
            // 
            this.weatherIconBox.Location = new System.Drawing.Point(178, 162);
            this.weatherIconBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.weatherIconBox.Name = "weatherIconBox";
            this.weatherIconBox.Size = new System.Drawing.Size(150, 143);
            this.weatherIconBox.TabIndex = 1;
            this.weatherIconBox.TabStop = false;
            this.weatherIconBox.Visible = false;
            // 
            // temperatureL
            // 
            this.temperatureL.AutoSize = true;
            this.temperatureL.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureL.ForeColor = System.Drawing.Color.Black;
            this.temperatureL.Location = new System.Drawing.Point(24, 385);
            this.temperatureL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureL.Name = "temperatureL";
            this.temperatureL.Size = new System.Drawing.Size(67, 28);
            this.temperatureL.TabIndex = 2;
            this.temperatureL.Text = "Suhu";
            this.temperatureL.Visible = false;
            // 
            // pressureL
            // 
            this.pressureL.AutoSize = true;
            this.pressureL.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureL.ForeColor = System.Drawing.Color.Black;
            this.pressureL.Location = new System.Drawing.Point(24, 456);
            this.pressureL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pressureL.Name = "pressureL";
            this.pressureL.Size = new System.Drawing.Size(104, 28);
            this.pressureL.TabIndex = 3;
            this.pressureL.Text = "Tekanan";
            this.pressureL.Visible = false;
            this.pressureL.Click += new System.EventHandler(this.pressureL_Click);
            // 
            // WindSpeedL
            // 
            this.WindSpeedL.AutoSize = true;
            this.WindSpeedL.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedL.ForeColor = System.Drawing.Color.Black;
            this.WindSpeedL.Location = new System.Drawing.Point(24, 531);
            this.WindSpeedL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindSpeedL.Name = "WindSpeedL";
            this.WindSpeedL.Size = new System.Drawing.Size(197, 28);
            this.WindSpeedL.TabIndex = 4;
            this.WindSpeedL.Text = "Kecepatan Angin";
            this.WindSpeedL.Visible = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.descriptionLabel.Location = new System.Drawing.Point(95, 316);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(148, 38);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "deskripsi";
            this.descriptionLabel.Visible = false;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.BackColor = System.Drawing.Color.PaleVioletRed;
            this.temperatureLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.temperatureLabel.Location = new System.Drawing.Point(328, 387);
            this.temperatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(0, 38);
            this.temperatureLabel.TabIndex = 6;
            this.temperatureLabel.Visible = false;
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pressureLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pressureLabel.Location = new System.Drawing.Point(328, 462);
            this.pressureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(0, 38);
            this.pressureLabel.TabIndex = 7;
            this.pressureLabel.Visible = false;
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.AutoSize = true;
            this.WindSpeedLabel.BackColor = System.Drawing.Color.PaleVioletRed;
            this.WindSpeedLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.WindSpeedLabel.Location = new System.Drawing.Point(328, 533);
            this.WindSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(0, 38);
            this.WindSpeedLabel.TabIndex = 8;
            this.WindSpeedLabel.Visible = false;
            // 
            // getFiveDay
            // 
            this.getFiveDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getFiveDay.Location = new System.Drawing.Point(335, 612);
            this.getFiveDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getFiveDay.Name = "getFiveDay";
            this.getFiveDay.Size = new System.Drawing.Size(148, 35);
            this.getFiveDay.TabIndex = 9;
            this.getFiveDay.Text = "DETAIL";
            this.getFiveDay.UseVisualStyleBackColor = true;
            this.getFiveDay.Visible = false;
            this.getFiveDay.Click += new System.EventHandler(this.getFiveDay_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(23, 62);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(262, 27);
            this.searchTextBox.TabIndex = 10;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nama Kota Yang Dicari";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(334, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "CARI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(515, 685);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.getFiveDay);
            this.Controls.Add(this.WindSpeedLabel);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.WindSpeedL);
            this.Controls.Add(this.pressureL);
            this.Controls.Add(this.temperatureL);
            this.Controls.Add(this.weatherIconBox);
            this.Controls.Add(this.dateLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cuaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox weatherIconBox;
        private System.Windows.Forms.Label temperatureL;
        private System.Windows.Forms.Label pressureL;
        private System.Windows.Forms.Label WindSpeedL;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label WindSpeedLabel;
        private System.Windows.Forms.Button getFiveDay;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

