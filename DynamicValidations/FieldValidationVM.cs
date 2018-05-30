using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicValidations
{
    public class FieldValidationVM
    {
        //To identify data validation source table
        public string TableName { get; set; }

        //To identify which column the field refers to from table
        public string ColumnName { get; set; }

        //To identify which UI section the field belongs to. This could be used to dynamically open sections when validation fails.
        public string UiSection { get; set; }

        //To identify which DTO property it is mapped to
        public string DtoPropertyName { get; set; }

        //To identify which viewmodel property the field is mapped to
        public string ViewModelProperty { get; set; }

        //To identify what enum the field refers to
        public string EnumName { get; set; }

        //To identify the value of the enum
        public long ValueOfEnum { get; set; }

        //To identify the view model class name
        public string ClassName { get; set; }

        //to identify the type e.g textbox, checkbox
        public string FieldType { get; set; }

        //To mark if the field needs to be validated
        public bool IsMandatory { get; set; }

        //To set the error message which would be displayed on hover of the control
        public string ErrorMessage { get; set; }

        //The xaml property name is set based on this field
        public string XamlPropertyName { get; set; }
    }
}
