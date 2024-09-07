namespace GuessingGame
{
    partial class Form1
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
            tb_guess = new Button();
            lb_mask_word = new Label();
            tb_answer = new TextBox();
            label2 = new Label();
            wrong_guessed_list = new ListBox();
            SuspendLayout();
            // 
            // tb_guess
            // 
            tb_guess.Location = new Point(144, 226);
            tb_guess.Name = "tb_guess";
            tb_guess.Size = new Size(150, 46);
            tb_guess.TabIndex = 0;
            tb_guess.Text = "Guess";
            tb_guess.UseVisualStyleBackColor = true;
            tb_guess.Click += tb_guess_Click;
            // 
            // lb_mask_word
            // 
            lb_mask_word.AutoSize = true;
            lb_mask_word.Font = new Font("Segoe UI", 14F);
            lb_mask_word.Location = new Point(107, 92);
            lb_mask_word.Name = "lb_mask_word";
            lb_mask_word.Size = new Size(212, 51);
            lb_mask_word.TabIndex = 1;
            lb_mask_word.Text = "Mask Word";
            // 
            // tb_answer
            // 
            tb_answer.Location = new Point(69, 159);
            tb_answer.Name = "tb_answer";
            tb_answer.Size = new Size(288, 39);
            tb_answer.TabIndex = 2;
            tb_answer.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(475, 84);
            label2.Name = "label2";
            label2.Size = new Size(313, 59);
            label2.TabIndex = 3;
            label2.Text = "WrongGuessed";
            label2.Click += label2_Click;
            // 
            // wrong_guessed_list
            // 
            wrong_guessed_list.FormattingEnabled = true;
            wrong_guessed_list.Location = new Point(548, 190);
            wrong_guessed_list.Name = "wrong_guessed_list";
            wrong_guessed_list.Size = new Size(240, 164);
            wrong_guessed_list.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 477);
            Controls.Add(wrong_guessed_list);
            Controls.Add(label2);
            Controls.Add(tb_answer);
            Controls.Add(lb_mask_word);
            Controls.Add(tb_guess);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tb_guess;
        private Label lb_mask_word;
        private TextBox tb_answer;
        private Label label2;
        private ListBox wrong_guessed_list;
    }
}
