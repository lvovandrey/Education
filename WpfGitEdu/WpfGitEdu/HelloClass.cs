using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfGitEdu
{
    public class HelloClass
    {
        public void Hello(string s)
        {
            MessageBox.Show("Hello "+ s +"!!!!");
            MessageBox.Show("Hello 2" + s + "!!!!");
        }
    }
}
