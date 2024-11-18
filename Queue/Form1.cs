namespace Queue
{
    public partial class Form1 : Form
    {
        private int[] queue = new int[10];
        private int front = -1;
        private int rear = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (rear == queue.Length - 1)
            {
                MessageBox.Show("The queue is full.");
                return;
            }

            if (int.TryParse(txtElement.Text, out int value))
            {
                if (front == -1) front = 0;
                queue[++rear] = value;
                txtElement.Clear();
                DisplayQueue();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (front == -1 || front > rear)
            {
                MessageBox.Show("The queue is empty.");
                return;
            }

            front++;
            DisplayQueue();
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (front == -1 || front > rear)
            {
                MessageBox.Show("The queue is empty.");
            }
            else
            {
                MessageBox.Show($"Front element: {queue[front]}");
            }
        }

        private void btnRear_Click(object sender, EventArgs e)
        {
            if (rear == -1 || front > rear)
            {
                MessageBox.Show("The queue is empty.");
            }
            else
            {
                MessageBox.Show($"Rear element: {queue[rear]}");
            }
        }

        private void btnIsEmpty_Click(object sender, EventArgs e)
        {
            MessageBox.Show((front == -1 || front > rear) ? "The queue is empty." : "The queue is not empty.");
        }

        private void btnIsFull_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rear == queue.Length - 1 ? "The queue is full." : "The queue is not full.");
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            int size = (front == -1 || front > rear) ? 0 : (rear - front + 1);
            MessageBox.Show($"Queue size: {size}");
        }

        private void DisplayQueue()
        {
            lstQueue.Items.Clear(); 
            if (front == -1 || front > rear) return; 

            for (int i = front; i <= rear; i++)
            {
                lstQueue.Items.Add(queue[i]); 
            }
        }
    }
}
