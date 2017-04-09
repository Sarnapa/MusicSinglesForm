namespace MusicSingles
{
    partial class AddEditForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.trackDateLabel = new System.Windows.Forms.Label();
            this.styleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.authorErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.myMusicStyleControler = new MusicSingles.MusicStyleControler();
            ((System.ComponentModel.ISupportInitialize)(this.titleErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(34, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(36, 18);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.authorLabel.Location = new System.Drawing.Point(34, 50);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(53, 18);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author";
            // 
            // trackDateLabel
            // 
            this.trackDateLabel.AutoSize = true;
            this.trackDateLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trackDateLabel.Location = new System.Drawing.Point(34, 81);
            this.trackDateLabel.Name = "trackDateLabel";
            this.trackDateLabel.Size = new System.Drawing.Size(84, 18);
            this.trackDateLabel.TabIndex = 2;
            this.trackDateLabel.Text = "Track Date";
            // 
            // styleLabel
            // 
            this.styleLabel.AutoSize = true;
            this.styleLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.styleLabel.Location = new System.Drawing.Point(34, 114);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(42, 18);
            this.styleLabel.TabIndex = 3;
            this.styleLabel.Text = "Style";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(174, 17);
            this.titleTextBox.MaxLength = 50;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(151, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(174, 51);
            this.authorTextBox.MaxLength = 50;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(151, 20);
            this.authorTextBox.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(174, 79);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.Value = new System.DateTime(2017, 4, 6, 0, 0, 0, 0);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(69, 164);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(219, 164);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleErrorProvider
            // 
            this.titleErrorProvider.ContainerControl = this;
            // 
            // authorErrorProvider
            // 
            this.authorErrorProvider.ContainerControl = this;
            // 
            // myMusicStyleControler
            // 
            this.myMusicStyleControler.Location = new System.Drawing.Point(174, 105);
            this.myMusicStyleControler.Name = "myMusicStyleControler";
            this.myMusicStyleControler.Size = new System.Drawing.Size(150, 50);
            this.myMusicStyleControler.Style = MusicStyle.Pop;
            this.myMusicStyleControler.TabIndex = 10;
            // 
            // AddEditForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.myMusicStyleControler);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.styleLabel);
            this.Controls.Add(this.trackDateLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddEditForm";
            this.Text = "Single";
            this.Load += new System.EventHandler(this.addEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titleErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label trackDateLabel;
        private System.Windows.Forms.Label styleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider titleErrorProvider;
        private System.Windows.Forms.ErrorProvider authorErrorProvider;
        private MusicStyleControler myMusicStyleControler;
    }
}