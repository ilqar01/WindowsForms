namespace WinFormsApp01.formsui
{
    public partial class PendingToInprocess : Form
    {
        public PendingToInprocess()
        {
            InitializeComponent();

        }

        
        private void MoveA2B(ComboBox A, ComboBox B)
        {
            int index = A.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            var item = A.Items[index];

            B.Items.Add(item);
            A.Items.Remove(item);
            A.Text = string.Empty;
            B.Text = string.Empty;
        }


        private void BtnProcessToPending_Click(object sender, EventArgs e)
        {
            MoveA2B(cbxInProcess, cbxPending);
        }

      

        private void btnProcessToDone_Click(object sender, EventArgs e)
        {
            MoveA2B(cbxInProcess, cbxDone);
        }

        private void btnPendingToProcess_Click(object sender, EventArgs e)
        {

            MoveA2B(cbxPending, cbxInProcess);

        }

        private void btnDoneToProcess_Click(object sender, EventArgs e)
        {
            MoveA2B(cbxDone, cbxInProcess);
        }

        private void cbxDone_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            {
                MoveA2B(cbxDone, cbxInProcess);
            }
        }

        private void cbxInProcess_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode== Keys.Right)
            {
                MoveA2B(cbxInProcess, cbxDone);
            }
            else if(e.KeyCode == Keys.Left)
            {
                MoveA2B(cbxInProcess, cbxPending);
            }
        }

        private void cbxPending_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode==Keys.Right)
            {
                MoveA2B(cbxPending, cbxInProcess);
            }
        }
    }
}