using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MedicalCenter.Models;

namespace MedicalCenter.ViewModels
{
    public class HomeMenuViewModel
    {
        public IList<HomeMenu> lstHomeMenu { get; set; }

        public HomeMenuViewModel()
        {
            lstHomeMenu = new List<HomeMenu>();
            GenerateCardModel();
        }

        private void GenerateCardModel()
        {
            lstHomeMenu.Add(new HomeMenu()
            {
                Title = "Request Appointment",
                Icon = "icon_appointment.png",
                BackgroundColor = "#479589"
            });
            lstHomeMenu.Add(new HomeMenu()
            {
                Title = "Order Prescription",
                Icon = "icon_prescription.png",
                BackgroundColor = "#4383D9"
            });
        }
    }
}
