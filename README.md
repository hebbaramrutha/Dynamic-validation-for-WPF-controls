# Dynamic-validation-for-WPF-controls
The WPF controls can be validated dynamically using bit logic.

The following implemention validates different controls dynamically based on validation values(could be fetched from database) passed. 

Each control is associated with a bit. When the validation number contains the bit, the control will be validated and it will show 
a red mark around the control with the error message on the top right of the control(visible on hover).

For eg: If the validation number is 4+2=6, First Name field and City combo box will be validated. This could be set by changing 
the IsMandatory field of the validation list in CustomerVM. Currently this value is set to "true" for all the controls on the window.

The logic for validating the control lies in the .xaml.cs file. Based on the type of control, the case is excecuted.

The user will not be able to submit the details until all the mandatory fields are entered.
