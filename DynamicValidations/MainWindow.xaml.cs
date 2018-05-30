using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DynamicValidations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CustomerVM customerVM;

        public MainWindow()
        {
            InitializeComponent();

            customerVM = new CustomerVM();
            DataContext = customerVM;
        }

        /// <summary>
        /// Method to validate if all native DB mandatory fields have been entered.
        /// </summary>
        private bool GetMandatoryFields()
        {
            bool isValid = true;

            try
            {
                BindingExpression bindingExpression = null;
                BindingExpressionBase bindingExpressionBase = null;
                ValidationError validationError = null;

                foreach (var item in customerVM.ValidationList)
                {
                    if (item.IsMandatory)
                    {
                        switch (item.FieldType)
                        {
                            case "TextBox":
                                TextBox txtBox = (TextBox)this.FindName(item.XamlPropertyName + item.FieldType);
                                bindingExpression = BindingOperations.GetBindingExpression(txtBox, TextBox.TextProperty);

                                if (string.IsNullOrEmpty(txtBox.Text))
                                {
                                    bindingExpressionBase = BindingOperations.GetBindingExpressionBase(txtBox, TextBox.TextProperty);
                                    validationError = new ValidationError(new ExceptionValidationRule(), bindingExpression);
                                    validationError.ErrorContent = item.ErrorMessage;
                                    Validation.MarkInvalid(bindingExpressionBase, validationError);
                                    isValid = false;
                                }
                                break;

                            case "ComboBox":
                                ComboBox comboBox = (ComboBox)this.FindName(item.XamlPropertyName + item.FieldType);
                                bindingExpression = BindingOperations.GetBindingExpression(comboBox, ComboBox.SelectedItemProperty);

                                if (comboBox.SelectedItem == null)
                                {
                                    bindingExpressionBase = BindingOperations.GetBindingExpressionBase(comboBox, ComboBox.SelectedItemProperty);
                                    validationError = new ValidationError(new ExceptionValidationRule(), bindingExpression);
                                    validationError.ErrorContent = item.ErrorMessage;
                                    Validation.MarkInvalid(bindingExpressionBase, validationError);
                                    isValid = false;
                                }
                                break;

                            case "Phone":
                                TextBox phoneBox = (TextBox)this.FindName(item.XamlPropertyName + "TextBox");

                                bindingExpression = BindingOperations.GetBindingExpression(phoneBox, TextBox.TextProperty);
                                Regex regex = new Regex(@"^(\+|00)([0-9]{1,3})(-)$");

                                if (!string.IsNullOrWhiteSpace(phoneBox.Text) && (regex.IsMatch(phoneBox.Text)))
                                {
                                    bindingExpressionBase = BindingOperations.GetBindingExpressionBase(phoneBox, TextBox.TextProperty);

                                    validationError = new ValidationError(new ExceptionValidationRule(), bindingExpression);
                                    validationError.ErrorContent = item.ErrorMessage;
                                    Validation.MarkInvalid(bindingExpressionBase, validationError);
                                    isValid = false;
                                }

                                if (string.IsNullOrWhiteSpace(phoneBox.Text))
                                {
                                    bindingExpressionBase = BindingOperations.GetBindingExpressionBase(phoneBox, TextBox.TextProperty);

                                    validationError = new ValidationError(new ExceptionValidationRule(), bindingExpression);
                                    validationError.ErrorContent = item.ErrorMessage;
                                    Validation.MarkInvalid(bindingExpressionBase, validationError);
                                    isValid = false;
                                }
                                break;

                            case "DatePicker":

                                if (!CustomerDateOfBirthDatePicker.SelectedDate.HasValue)
                                {
                                    bindingExpressionBase = BindingOperations.GetBindingExpressionBase(CustomerDateOfBirthDatePicker, DatePicker.SelectedDateProperty);
                                    validationError = new ValidationError(new ExceptionValidationRule(), bindingExpression);
                                    validationError.ErrorContent = item.ErrorMessage;
                                    Validation.MarkInvalid(bindingExpressionBase, validationError);
                                    isValid = false;
                                }
                                break;

                            case "CheckBox":
                                if (GenderCheckBox.IsChecked.HasValue && !GenderCheckBox.IsChecked.Value)
                                {
                                    bindingExpression = BindingOperations.GetBindingExpression(GenderCheckBox, CheckBox.IsCheckedProperty);
                                    bindingExpressionBase = BindingOperations.GetBindingExpressionBase(GenderCheckBox, CheckBox.IsCheckedProperty);
                                    validationError = new ValidationError(new ExceptionValidationRule(), bindingExpression);
                                    validationError.ErrorContent = item.ErrorMessage;
                                    Validation.MarkInvalid(bindingExpressionBase, validationError);
                                }
                                break;

                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return isValid;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetMandatoryFields();
        }
    }
}
