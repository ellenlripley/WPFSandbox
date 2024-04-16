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

namespace WpfSandbox
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

           List<TestVM> testVms = new List<TestVM>();

           TestVM item = new TestVM("Thomas", "RED");
           testVms.Add(item);

           item = new TestVM("Tim", "RED");
           testVms.Add(item);

           item = new TestVM("Dirk", "GRÜN");
           testVms.Add(item);

           //Pivot Object

           List<Pivot> PivotList = new List<Pivot>();

           foreach (var seam in testVms)
           {
                   foreach (var noti in item.Notifications)
                   {
                       Pivot piv = new Pivot();
                       {
                          // piv.Color = seam.Color;
                          if (PivotList.Any(t => t.DemandCategory == seam.DemandCategory)== false)
                          {
                      
                            piv.DemandCategory = seam.DemandCategory;
                        }
                          
                          

                          piv.LeadId = noti.LeadId;
                           piv.ReceiptDate = noti.ReceiptDate;
                           piv.Status = noti.Status;
                       }
                       PivotList.Add(piv);
               }

           }




           this.MyDatagrid.ItemsSource = PivotList;

        }
    }
}
