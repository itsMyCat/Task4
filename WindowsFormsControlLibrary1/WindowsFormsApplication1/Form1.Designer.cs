namespace WindowsFormsApplication1
{
    partial class Form1
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
            this._pictureBoxFrame = new System.Windows.Forms.PictureBox();
            this._radioButtonCurve = new System.Windows.Forms.RadioButton();
            this._radioButtonBezierCurve = new System.Windows.Forms.RadioButton();
            this._radioButtonPolygone = new System.Windows.Forms.RadioButton();
            this._buttonCreate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // _pictureBoxFrame
            // 
            this._pictureBoxFrame.BackColor = System.Drawing.Color.White;
            this._pictureBoxFrame.Location = new System.Drawing.Point(12, 12);
            this._pictureBoxFrame.Name = "_pictureBoxFrame";
            this._pictureBoxFrame.Size = new System.Drawing.Size(546, 403);
            this._pictureBoxFrame.TabIndex = 0;
            this._pictureBoxFrame.TabStop = false;
            this._pictureBoxFrame.MouseClick += new System.Windows.Forms.MouseEventHandler(this._pictureBoxFrame_MouseClick);
            // 
            // _radioButtonCurve
            // 
            this._radioButtonCurve.AutoSize = true;
            this._radioButtonCurve.Location = new System.Drawing.Point(581, 12);
            this._radioButtonCurve.Name = "_radioButtonCurve";
            this._radioButtonCurve.Size = new System.Drawing.Size(71, 17);
            this._radioButtonCurve.TabIndex = 2;
            this._radioButtonCurve.TabStop = true;
            this._radioButtonCurve.Text = "Ломаная";
            this._radioButtonCurve.UseVisualStyleBackColor = true;
            this._radioButtonCurve.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // _radioButtonBezierCurve
            // 
            this._radioButtonBezierCurve.AutoSize = true;
            this._radioButtonBezierCurve.Location = new System.Drawing.Point(581, 35);
            this._radioButtonBezierCurve.Name = "_radioButtonBezierCurve";
            this._radioButtonBezierCurve.Size = new System.Drawing.Size(96, 17);
            this._radioButtonBezierCurve.TabIndex = 3;
            this._radioButtonBezierCurve.TabStop = true;
            this._radioButtonBezierCurve.Text = "Кривая Безье";
            this._radioButtonBezierCurve.UseVisualStyleBackColor = true;
            this._radioButtonBezierCurve.CheckedChanged += new System.EventHandler(this._radioButtonBezierCurve_CheckedChanged);
            // 
            // _radioButtonPolygone
            // 
            this._radioButtonPolygone.AutoSize = true;
            this._radioButtonPolygone.Location = new System.Drawing.Point(581, 58);
            this._radioButtonPolygone.Name = "_radioButtonPolygone";
            this._radioButtonPolygone.Size = new System.Drawing.Size(68, 17);
            this._radioButtonPolygone.TabIndex = 4;
            this._radioButtonPolygone.TabStop = true;
            this._radioButtonPolygone.Text = "Полигон";
            this._radioButtonPolygone.UseVisualStyleBackColor = true;
            this._radioButtonPolygone.CheckedChanged += new System.EventHandler(this._radioButtonPolygone_CheckedChanged);
            // 
            // _buttonCreate
            // 
            this._buttonCreate.Location = new System.Drawing.Point(581, 82);
            this._buttonCreate.Name = "_buttonCreate";
            this._buttonCreate.Size = new System.Drawing.Size(96, 23);
            this._buttonCreate.TabIndex = 5;
            this._buttonCreate.Text = "Построить";
            this._buttonCreate.UseVisualStyleBackColor = true;
            this._buttonCreate.Click += new System.EventHandler(this._buttonCreate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._buttonCreate);
            this.Controls.Add(this._radioButtonPolygone);
            this.Controls.Add(this._radioButtonBezierCurve);
            this.Controls.Add(this._radioButtonCurve);
            this.Controls.Add(this._pictureBoxFrame);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _pictureBoxFrame;
        private System.Windows.Forms.RadioButton _radioButtonCurve;
        private System.Windows.Forms.RadioButton _radioButtonBezierCurve;
        private System.Windows.Forms.RadioButton _radioButtonPolygone;
        private System.Windows.Forms.Button _buttonCreate;
        private System.Windows.Forms.Button button1;
    }
}

