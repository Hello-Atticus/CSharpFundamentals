using System.Windows.Forms;
namespace EventExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //事件的拥有者和事件的响应者是一个，即form
            MyForm form = new MyForm();
            form.Click += form.Clicked;
            form.ShowDialog();
            
        }
    }

    class MyForm : Form
    {
        internal void Clicked(object? sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
