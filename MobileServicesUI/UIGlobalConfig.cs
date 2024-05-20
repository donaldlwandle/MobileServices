using MobileServices.Utils;
using MobileServicesUI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileServicesUI
{
    public static class UIGlobalConfig
    {
        public static List<IUserUpdated> userUpdateListeningForms { get; private set; } = new List<IUserUpdated>();

        

        public static void AddHomeForm(HomeForm form)
        {

            userUpdateListeningForms.Add(form);
        }

        public static void AddMainForm(View.MainForm form)
        {

            userUpdateListeningForms.Add(form);
        }


    }
}
