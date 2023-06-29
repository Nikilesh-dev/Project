using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using List_binding.Create_class;

namespace List_binding
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Employee>   employees1 = new List<Employee>();

        public Window1()
        {
            InitializeComponent();

        }
       
        public  Window1(List<Employee>employees )
        {
            InitializeComponent();
         
            employees1 = employees;
           
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {


            txtname.Text = employees1[0].Ename;
        }
    }
}
