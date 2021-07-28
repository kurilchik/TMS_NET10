
namespace EventWindowsForms
{
    partial class EventForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._buttonClick = new System.Windows.Forms.Button();
            this._buttonEnter = new System.Windows.Forms.Button();
            this._buttonLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonClick
            // 
            this._buttonClick.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._buttonClick.Location = new System.Drawing.Point(13, 13);
            this._buttonClick.Name = "_buttonClick";
            this._buttonClick.Size = new System.Drawing.Size(311, 95);
            this._buttonClick.TabIndex = 0;
            this._buttonClick.Text = "Click";
            this._buttonClick.UseVisualStyleBackColor = true;
            // 
            // _buttonEnter
            // 
            this._buttonEnter.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._buttonEnter.Location = new System.Drawing.Point(13, 178);
            this._buttonEnter.Name = "_buttonEnter";
            this._buttonEnter.Size = new System.Drawing.Size(311, 95);
            this._buttonEnter.TabIndex = 1;
            this._buttonEnter.Text = "Enter";
            this._buttonEnter.UseVisualStyleBackColor = true;
            // 
            // _buttonLeave
            // 
            this._buttonLeave.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._buttonLeave.Location = new System.Drawing.Point(12, 343);
            this._buttonLeave.Name = "_buttonLeave";
            this._buttonLeave.Size = new System.Drawing.Size(311, 95);
            this._buttonLeave.TabIndex = 2;
            this._buttonLeave.Text = "Leave";
            this._buttonLeave.UseVisualStyleBackColor = true;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this._buttonLeave);
            this.Controls.Add(this._buttonEnter);
            this.Controls.Add(this._buttonClick);
            this.Name = "EventForm";
            this.Text = "Event";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonClick;
        private System.Windows.Forms.Button _buttonEnter;
        private System.Windows.Forms.Button _buttonLeave;
    }
}

