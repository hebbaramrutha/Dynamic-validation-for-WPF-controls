using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicValidations
{
    public class CustomerVM
    {
        public List<FieldValidationVM> ValidationList { get; set; }

        public string FirstName { get; set; }

        public string SelectedComboBoxItem { get; set; }

        public bool Gender { get; set; }

        public string CustomerPhone { get; set; }

        public DateTime? CustomerDateOfBirth { get; set; }

        public ObservableCollection<string> CityList { get; set; } = new ObservableCollection<string>();

        /// <summary>
        /// Contructor.
        /// </summary>
        public CustomerVM()
        {
            ConstructValidationTable();
            SetCountryCode();
            SetCityList();
        }

        /// <summary>
        /// Method to construct temporary table for all controls.
        /// </summary>
        private void ConstructValidationTable()
        {
            var row1 = new FieldValidationVM
            {
                XamlPropertyName = "CustomerFirstName",
                FieldType = "TextBox",//Indicates the control type
                ValueOfEnum = 2,//Bit value associated to each control
                IsMandatory = true,//set to true to validate by default and not based on any condition.
                ErrorMessage = "First name is required."
            };

            var row2 = new FieldValidationVM
            {
                XamlPropertyName = "City",
                FieldType = "ComboBox",
                ValueOfEnum = 4,
                IsMandatory = true,
                ErrorMessage = "Combox item is required."
            };

            var row3 = new FieldValidationVM
            {
                XamlPropertyName = "Gender",
                FieldType = "CheckBox",
                ValueOfEnum = 8,
                IsMandatory = true,
                ErrorMessage = "Check Box should be checked."
            };

            var row4 = new FieldValidationVM
            {
                XamlPropertyName = "CustomerPhone",
                FieldType = "Phone",
                ValueOfEnum = 16,
                IsMandatory = true,
                ErrorMessage = "Enter valid phone number"
            };

            var row5 = new FieldValidationVM
            {
                XamlPropertyName = "CustomerDateOfBirth",
                FieldType = "DatePicker",
                ValueOfEnum = 64,
                IsMandatory = true,
                ErrorMessage = "Select valid date."
            };

            ValidationList = new List<FieldValidationVM> { row1, row2, row3, row4,row5};
        }

        /// <summary>
        /// Method to set default country code for phone.
        /// </summary>
        private void SetCountryCode()
        {
            CustomerPhone = "+91-";
        }

        /// <summary>
        /// Method to add items to list.
        /// </summary>
        private void SetCityList()
        {
            CityList.Add("Bangalore");
            CityList.Add("Delhi");
            CityList.Add("Goa");
        }
    }
}
