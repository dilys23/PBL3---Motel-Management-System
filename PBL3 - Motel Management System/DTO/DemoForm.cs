using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.DTO
{
    public class DemoForm
    {
        private static DemoForm instance;
        private Form activeForm;
        public static DemoForm Instance
        {
            get
            {
                if (instance == null) instance = new DemoForm();
                return instance;
            }
        }
        private DemoForm()
        {
            activeForm = null;
        }
        public void SetActiveForm(Form childForm)
        {
            activeForm = childForm;
        }
        public Form GetActiveForm()
        {
            return activeForm;
        }
        public void CloseForm()
        {
            activeForm.Close();
        }
    }
}
