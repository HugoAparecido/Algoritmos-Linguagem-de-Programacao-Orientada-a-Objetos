using System.Runtime.InteropServices;
namespace BarrraDePesquisa
{
    public static class ModificarCorProgressBar
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.SetState(2);//Muda a cor da progressbar
                progressBar1.Value = i;//incrementando o valor na progressBar
                Thread.Sleep(100);//causa atraso no tempo de execução
            }
        }
    }
}