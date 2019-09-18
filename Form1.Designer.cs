namespace LotteryLoopRandom___dylan_hughes
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
            this.resultlistbox = new System.Windows.Forms.ListBox();
            this.numberslabel = new System.Windows.Forms.Label();
            this.firstnumbertextbox = new System.Windows.Forms.TextBox();
            this.secondnumbertextbox = new System.Windows.Forms.TextBox();
            this.thirdnumbertextbox = new System.Windows.Forms.TextBox();
            this.generatebutton = new System.Windows.Forms.Button();
            this.randomnumberlabel = new System.Windows.Forms.Label();
            this.numberonelabel = new System.Windows.Forms.Label();
            this.numbertwolabel = new System.Windows.Forms.Label();
            this.numberthreelabel = new System.Windows.Forms.Label();
            this.clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultlistbox
            // 
            this.resultlistbox.FormattingEnabled = true;
            this.resultlistbox.ItemHeight = 20;
            this.resultlistbox.Location = new System.Drawing.Point(190, 184);
            this.resultlistbox.Name = "resultlistbox";
            this.resultlistbox.Size = new System.Drawing.Size(340, 164);
            this.resultlistbox.TabIndex = 0;
            // 
            // numberslabel
            // 
            this.numberslabel.AutoSize = true;
            this.numberslabel.Location = new System.Drawing.Point(186, 47);
            this.numberslabel.Name = "numberslabel";
            this.numberslabel.Size = new System.Drawing.Size(208, 20);
            this.numberslabel.TabIndex = 1;
            this.numberslabel.Text = "Enter the Winning Numbers:";
            // 
            // firstnumbertextbox
            // 
            this.firstnumbertextbox.Location = new System.Drawing.Point(400, 47);
            this.firstnumbertextbox.Name = "firstnumbertextbox";
            this.firstnumbertextbox.Size = new System.Drawing.Size(29, 26);
            this.firstnumbertextbox.TabIndex = 2;
            // 
            // secondnumbertextbox
            // 
            this.secondnumbertextbox.Location = new System.Drawing.Point(435, 47);
            this.secondnumbertextbox.Name = "secondnumbertextbox";
            this.secondnumbertextbox.Size = new System.Drawing.Size(29, 26);
            this.secondnumbertextbox.TabIndex = 3;
            // 
            // thirdnumbertextbox
            // 
            this.thirdnumbertextbox.Location = new System.Drawing.Point(470, 47);
            this.thirdnumbertextbox.Name = "thirdnumbertextbox";
            this.thirdnumbertextbox.Size = new System.Drawing.Size(29, 26);
            this.thirdnumbertextbox.TabIndex = 4;
            // 
            // generatebutton
            // 
            this.generatebutton.Location = new System.Drawing.Point(137, 97);
            this.generatebutton.Name = "generatebutton";
            this.generatebutton.Size = new System.Drawing.Size(448, 31);
            this.generatebutton.TabIndex = 5;
            this.generatebutton.Text = "Generate Random Number / Try to Match Winning Number";
            this.generatebutton.UseVisualStyleBackColor = true;
            this.generatebutton.Click += new System.EventHandler(this.generatebutton_Click);
            // 
            // randomnumberlabel
            // 
            this.randomnumberlabel.AutoSize = true;
            this.randomnumberlabel.Location = new System.Drawing.Point(186, 148);
            this.randomnumberlabel.Name = "randomnumberlabel";
            this.randomnumberlabel.Size = new System.Drawing.Size(134, 20);
            this.randomnumberlabel.TabIndex = 6;
            this.randomnumberlabel.Text = "Random Number:";
            // 
            // numberonelabel
            // 
            this.numberonelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberonelabel.Location = new System.Drawing.Point(400, 139);
            this.numberonelabel.Name = "numberonelabel";
            this.numberonelabel.Size = new System.Drawing.Size(29, 29);
            this.numberonelabel.TabIndex = 7;
            // 
            // numbertwolabel
            // 
            this.numbertwolabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numbertwolabel.Location = new System.Drawing.Point(435, 139);
            this.numbertwolabel.Name = "numbertwolabel";
            this.numbertwolabel.Size = new System.Drawing.Size(29, 29);
            this.numbertwolabel.TabIndex = 8;
            // 
            // numberthreelabel
            // 
            this.numberthreelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberthreelabel.Location = new System.Drawing.Point(470, 139);
            this.numberthreelabel.Name = "numberthreelabel";
            this.numberthreelabel.Size = new System.Drawing.Size(29, 29);
            this.numberthreelabel.TabIndex = 9;
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(190, 354);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(117, 32);
            this.clearbutton.TabIndex = 10;
            this.clearbutton.Text = "Clear All";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.numberthreelabel);
            this.Controls.Add(this.numbertwolabel);
            this.Controls.Add(this.numberonelabel);
            this.Controls.Add(this.randomnumberlabel);
            this.Controls.Add(this.generatebutton);
            this.Controls.Add(this.thirdnumbertextbox);
            this.Controls.Add(this.secondnumbertextbox);
            this.Controls.Add(this.firstnumbertextbox);
            this.Controls.Add(this.numberslabel);
            this.Controls.Add(this.resultlistbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox resultlistbox;
        private System.Windows.Forms.Label numberslabel;
        private System.Windows.Forms.TextBox firstnumbertextbox;
        private System.Windows.Forms.TextBox secondnumbertextbox;
        private System.Windows.Forms.TextBox thirdnumbertextbox;
        private System.Windows.Forms.Button generatebutton;
        private System.Windows.Forms.Label randomnumberlabel;
        private System.Windows.Forms.Label numberonelabel;
        private System.Windows.Forms.Label numbertwolabel;
        private System.Windows.Forms.Label numberthreelabel;
        private System.Windows.Forms.Button clearbutton;
    }
}

