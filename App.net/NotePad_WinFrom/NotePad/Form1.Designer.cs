namespace NotePad
{
    partial class NoteTaker
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
            NoteBox = new TextBox();
            TitleBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LoadButton = new Button();
            DeleteButton = new Button();
            SaveButton = new Button();
            NewButton = new Button();
            previousNote = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)previousNote).BeginInit();
            SuspendLayout();
            // 
            // NoteBox
            // 
            NoteBox.Location = new Point(475, 88);
            NoteBox.Margin = new Padding(4, 3, 4, 3);
            NoteBox.Multiline = true;
            NoteBox.Name = "NoteBox";
            NoteBox.Size = new Size(512, 428);
            NoteBox.TabIndex = 0;
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(475, 28);
            TitleBox.Margin = new Padding(4, 3, 4, 3);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(512, 30);
            TitleBox.TabIndex = 1;
            TitleBox.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(475, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(506, 20);
            label1.TabIndex = 2;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.Location = new Point(475, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(506, 23);
            label2.TabIndex = 3;
            label2.Text = "Note:";
            label2.Click += label2_Click;
            // 
            // LoadButton
            // 
            LoadButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LoadButton.Location = new Point(12, 418);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(221, 48);
            LoadButton.TabIndex = 5;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += Loadbutton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.Location = new Point(247, 418);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(221, 48);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.Location = new Point(247, 468);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(221, 48);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += button1_Click;
            // 
            // NewButton
            // 
            NewButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            NewButton.Location = new Point(12, 468);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(221, 48);
            NewButton.TabIndex = 8;
            NewButton.Text = "New Note";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // previousNote
            // 
            previousNote.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNote.BackgroundColor = Color.White;
            previousNote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNote.Location = new Point(12, 12);
            previousNote.Name = "previousNote";
            previousNote.RowHeadersWidth = 51;
            previousNote.RowTemplate.Height = 29;
            previousNote.Size = new Size(456, 400);
            previousNote.TabIndex = 9;
            previousNote.CellDoubleClick += previousNote_CellDoubleClick;
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1000, 518);
            Controls.Add(previousNote);
            Controls.Add(NewButton);
            Controls.Add(SaveButton);
            Controls.Add(DeleteButton);
            Controls.Add(LoadButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TitleBox);
            Controls.Add(NoteBox);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "NoteTaker";
            Text = "NoteTaker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)previousNote).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NoteBox;
        private TextBox TitleBox;
        private Label label1;
        private Label label2;
        private Button LoadButton;
        private Button DeleteButton;
        private Button SaveButton;
        private Button NewButton;
        private DataGridView previousNote;
    }
}