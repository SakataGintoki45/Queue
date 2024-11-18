namespace Queue
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
            txtElement = new TextBox();
            label1 = new Label();
            btnEnqueue = new Button();
            btnDequeue = new Button();
            btnRear = new Button();
            btnPeek = new Button();
            btnIsFull = new Button();
            btnIsEmpty = new Button();
            btnSize = new Button();
            lstQueue = new ListBox();
            SuspendLayout();
            // 
            // txtElement
            // 
            txtElement.Font = new Font("Segoe UI", 15F);
            txtElement.Location = new Point(325, 72);
            txtElement.Name = "txtElement";
            txtElement.Size = new Size(110, 34);
            txtElement.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(244, 32);
            label1.Name = "label1";
            label1.Size = new Size(261, 28);
            label1.TabIndex = 1;
            label1.Text = "Enter a number to the queue";
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(18, 136);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(89, 37);
            btnEnqueue.TabIndex = 2;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(133, 136);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(89, 37);
            btnDequeue.TabIndex = 3;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // btnRear
            // 
            btnRear.Location = new Point(360, 136);
            btnRear.Name = "btnRear";
            btnRear.Size = new Size(89, 37);
            btnRear.TabIndex = 5;
            btnRear.Text = "Rear";
            btnRear.UseVisualStyleBackColor = true;
            btnRear.Click += btnRear_Click;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(245, 136);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(89, 37);
            btnPeek.TabIndex = 4;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnIsFull
            // 
            btnIsFull.Location = new Point(584, 136);
            btnIsFull.Name = "btnIsFull";
            btnIsFull.Size = new Size(89, 37);
            btnIsFull.TabIndex = 7;
            btnIsFull.Text = "IsFull";
            btnIsFull.UseVisualStyleBackColor = true;
            btnIsFull.Click += btnIsFull_Click;
            // 
            // btnIsEmpty
            // 
            btnIsEmpty.Location = new Point(469, 136);
            btnIsEmpty.Name = "btnIsEmpty";
            btnIsEmpty.Size = new Size(89, 37);
            btnIsEmpty.TabIndex = 6;
            btnIsEmpty.Text = "Is Empty";
            btnIsEmpty.UseVisualStyleBackColor = true;
            btnIsEmpty.Click += btnIsEmpty_Click;
            // 
            // btnSize
            // 
            btnSize.Location = new Point(699, 136);
            btnSize.Name = "btnSize";
            btnSize.Size = new Size(89, 37);
            btnSize.TabIndex = 8;
            btnSize.Text = "Size";
            btnSize.UseVisualStyleBackColor = true;
            btnSize.Click += btnSize_Click;
            // 
            // lstQueue
            // 
            lstQueue.FormattingEnabled = true;
            lstQueue.ItemHeight = 15;
            lstQueue.Location = new Point(306, 231);
            lstQueue.Name = "lstQueue";
            lstQueue.Size = new Size(129, 94);
            lstQueue.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstQueue);
            Controls.Add(btnSize);
            Controls.Add(btnIsFull);
            Controls.Add(btnIsEmpty);
            Controls.Add(btnRear);
            Controls.Add(btnPeek);
            Controls.Add(btnDequeue);
            Controls.Add(btnEnqueue);
            Controls.Add(label1);
            Controls.Add(txtElement);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtElement;
        private Label label1;
        private Button btnEnqueue;
        private Button btnDequeue;
        private Button btnRear;
        private Button btnPeek;
        private Button btnIsFull;
        private Button btnIsEmpty;
        private Button btnSize;
        private ListBox lstQueue;
    }
}
