namespace lab6_1_Bonnie
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
            this.validation = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.checkEmail = new System.Windows.Forms.Button();
            this.deleteExtraSpaces = new System.Windows.Forms.Button();
            this.validatePostalCode = new System.Windows.Forms.Button();
            this.deleteLetter = new System.Windows.Forms.Button();
            this.createArray = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // validation
            // 
            this.validation.AutoSize = true;
            this.validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validation.Location = new System.Drawing.Point(12, 23);
            this.validation.Name = "validation";
            this.validation.Size = new System.Drawing.Size(225, 25);
            this.validation.TabIndex = 0;
            this.validation.Text = "Enter the text to validate:";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(256, 23);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(521, 26);
            this.textBox.TabIndex = 1;
            // 
            // checkEmail
            // 
            this.checkEmail.Location = new System.Drawing.Point(35, 80);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(130, 71);
            this.checkEmail.TabIndex = 2;
            this.checkEmail.Text = "&Check E-mail";
            this.checkEmail.UseVisualStyleBackColor = true;
            this.checkEmail.Click += new System.EventHandler(this.checkEmail_Click);
            this.checkEmail.Validating += new System.ComponentModel.CancelEventHandler(this.checkEmail_Validating);
            // 
            // deleteExtraSpaces
            // 
            this.deleteExtraSpaces.Location = new System.Drawing.Point(188, 80);
            this.deleteExtraSpaces.Name = "deleteExtraSpaces";
            this.deleteExtraSpaces.Size = new System.Drawing.Size(130, 71);
            this.deleteExtraSpaces.TabIndex = 3;
            this.deleteExtraSpaces.Text = "&Delete extra spaces";
            this.deleteExtraSpaces.UseVisualStyleBackColor = true;
            this.deleteExtraSpaces.Click += new System.EventHandler(this.deleteExtraSpaces_Click);
            // 
            // validatePostalCode
            // 
            this.validatePostalCode.Location = new System.Drawing.Point(341, 80);
            this.validatePostalCode.Name = "validatePostalCode";
            this.validatePostalCode.Size = new System.Drawing.Size(130, 71);
            this.validatePostalCode.TabIndex = 4;
            this.validatePostalCode.Text = "&Validate Postal Code";
            this.validatePostalCode.UseVisualStyleBackColor = true;
            this.validatePostalCode.Click += new System.EventHandler(this.validatePostalCode_Click);
            // 
            // deleteLetter
            // 
            this.deleteLetter.Location = new System.Drawing.Point(494, 80);
            this.deleteLetter.Name = "deleteLetter";
            this.deleteLetter.Size = new System.Drawing.Size(130, 71);
            this.deleteLetter.TabIndex = 5;
            this.deleteLetter.Text = "D&elete letter a, b, c, and d";
            this.deleteLetter.UseVisualStyleBackColor = true;
            this.deleteLetter.Click += new System.EventHandler(this.deleteLetter_Click);
            // 
            // createArray
            // 
            this.createArray.Location = new System.Drawing.Point(647, 80);
            this.createArray.Name = "createArray";
            this.createArray.Size = new System.Drawing.Size(130, 71);
            this.createArray.TabIndex = 6;
            this.createArray.Text = "C&reate an array of words";
            this.createArray.UseVisualStyleBackColor = true;
            this.createArray.Click += new System.EventHandler(this.createArray_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(647, 184);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(130, 35);
            this.exit.TabIndex = 7;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 254);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.createArray);
            this.Controls.Add(this.deleteLetter);
            this.Controls.Add(this.validatePostalCode);
            this.Controls.Add(this.deleteExtraSpaces);
            this.Controls.Add(this.checkEmail);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.validation);
            this.Name = "Form1";
            this.Text = "Form Regex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label validation;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button checkEmail;
        private System.Windows.Forms.Button deleteExtraSpaces;
        private System.Windows.Forms.Button validatePostalCode;
        private System.Windows.Forms.Button deleteLetter;
        private System.Windows.Forms.Button createArray;
        private System.Windows.Forms.Button exit;
    }
}

