using System;
using System.Drawing;
using System.Windows.Forms;
namespace ProjectTank
{
    partial class FormTank
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxSportCar;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonCheckBorders;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBoxSportCar = new PictureBox();
            buttonCreate = new Button();
            buttonUp = new Button();
            buttonDown = new Button();
            buttonLeft = new Button();
            buttonRight = new Button();
            buttonCheckBorders = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSportCar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxSportCar
            // 
            pictureBoxSportCar.Dock = DockStyle.Fill;
            pictureBoxSportCar.Location = new Point(0, 0);
            pictureBoxSportCar.Name = "pictureBoxSportCar";
            pictureBoxSportCar.Size = new Size(700, 422);
            pictureBoxSportCar.TabIndex = 0;
            pictureBoxSportCar.TabStop = false;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(12, 382);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(88, 28);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += ButtonCreate_Click;
            // 
            // buttonUp
            // 
            buttonUp.Location = new Point(615, 348);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(35, 28);
            buttonUp.TabIndex = 2;
            buttonUp.Text = "↑";
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += ButtonMove_Click;
            // 
            // buttonDown
            // 
            buttonDown.Location = new Point(615, 382);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(35, 28);
            buttonDown.TabIndex = 3;
            buttonDown.Text = "↓";
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += ButtonMove_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Location = new Point(574, 382);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(35, 28);
            buttonLeft.TabIndex = 4;
            buttonLeft.Text = "←";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += ButtonMove_Click;
            // 
            // buttonRight
            // 
            buttonRight.Location = new Point(653, 382);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(35, 28);
            buttonRight.TabIndex = 5;
            buttonRight.Text = "→";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += ButtonMove_Click;
            // 
            // buttonCheckBorders
            // 
            buttonCheckBorders.Location = new Point(12, 11);
            buttonCheckBorders.Name = "buttonCheckBorders";
            buttonCheckBorders.Size = new Size(105, 28);
            buttonCheckBorders.TabIndex = 6;
            buttonCheckBorders.Text = "Проверка границ";
            buttonCheckBorders.UseVisualStyleBackColor = true;
            buttonCheckBorders.Click += ButtonCheckBorders_Click;
            // 
            // FormSportCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(buttonCheckBorders);
            Controls.Add(buttonRight);
            Controls.Add(buttonLeft);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(buttonCreate);
            Controls.Add(pictureBoxSportCar);
            Name = "FormSportCar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Перемещение объекта";
            ((System.ComponentModel.ISupportInitialize)pictureBoxSportCar).EndInit();
            ResumeLayout(false);
        }
    }
}

