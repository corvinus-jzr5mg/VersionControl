
namespace mikulas
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.btnSelectBall = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnSelectPresent = new System.Windows.Forms.Button();
            this.btnRibbon_Color = new System.Windows.Forms.Button();
            this.btnBox_Color = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(-1, 232);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1076, 100);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Location = new System.Drawing.Point(13, 13);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(181, 31);
            this.btnSelectCar.TabIndex = 1;
            this.btnSelectCar.Text = "Car";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            this.btnSelectCar.Click += new System.EventHandler(this.btnSelectCar_Click);
            // 
            // btnSelectBall
            // 
            this.btnSelectBall.Location = new System.Drawing.Point(200, 13);
            this.btnSelectBall.Name = "btnSelectBall";
            this.btnSelectBall.Size = new System.Drawing.Size(181, 31);
            this.btnSelectBall.TabIndex = 1;
            this.btnSelectBall.Text = "Ball";
            this.btnSelectBall.UseVisualStyleBackColor = true;
            this.btnSelectBall.Click += new System.EventHandler(this.btnSelectBall_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(623, 22);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(68, 13);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "Coming next:";
            this.lblNext.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.OrangeRed;
            this.btnColor.Location = new System.Drawing.Point(242, 50);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(91, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSelectPresent
            // 
            this.btnSelectPresent.Location = new System.Drawing.Point(387, 13);
            this.btnSelectPresent.Name = "btnSelectPresent";
            this.btnSelectPresent.Size = new System.Drawing.Size(181, 31);
            this.btnSelectPresent.TabIndex = 1;
            this.btnSelectPresent.Text = "Present";
            this.btnSelectPresent.UseVisualStyleBackColor = true;
            this.btnSelectPresent.Click += new System.EventHandler(this.btnSelectPresent_Click);
            // 
            // btnRibbon_Color
            // 
            this.btnRibbon_Color.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRibbon_Color.Location = new System.Drawing.Point(426, 50);
            this.btnRibbon_Color.Name = "btnRibbon_Color";
            this.btnRibbon_Color.Size = new System.Drawing.Size(91, 23);
            this.btnRibbon_Color.TabIndex = 3;
            this.btnRibbon_Color.UseVisualStyleBackColor = false;
            this.btnRibbon_Color.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnBox_Color
            // 
            this.btnBox_Color.BackColor = System.Drawing.Color.Chocolate;
            this.btnBox_Color.Location = new System.Drawing.Point(426, 79);
            this.btnBox_Color.Name = "btnBox_Color";
            this.btnBox_Color.Size = new System.Drawing.Size(91, 23);
            this.btnBox_Color.TabIndex = 3;
            this.btnBox_Color.UseVisualStyleBackColor = false;
            this.btnBox_Color.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 482);
            this.Controls.Add(this.btnBox_Color);
            this.Controls.Add(this.btnRibbon_Color);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.btnSelectPresent);
            this.Controls.Add(this.btnSelectBall);
            this.Controls.Add(this.btnSelectCar);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btnSelectCar;
        private System.Windows.Forms.Button btnSelectBall;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnSelectPresent;
        private System.Windows.Forms.Button btnRibbon_Color;
        private System.Windows.Forms.Button btnBox_Color;
    }
}

