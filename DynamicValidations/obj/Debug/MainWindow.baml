   M S B A M L   `   `   `  ����M  IDynamicValidations, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DynamicValidationsDynamicValidations  5   	   #    DynamicValidations.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DynamicValidations     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ ControlStyles.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��
First Name��6   $��Center=�6%   �� 5   
   -   5        $��CustomerFirstNameTextBox��5   )   $��25��6   $��70��6      BaseTextBoxStyle#��[  6d   ��6I   �� *	FirstName+6d   �� 5!   
   $��Gender��6   $��Center=�6!   $��1��6<   �� 5"   
   -   5        $��GenderCheckBox��5"   >   $��1��6   $��Center=�6#   $��Center=�6T     BaseCheckBoxStyle#��[ 6q    d� 	IsChecked 6�   �� *Gender+�� 5$   
   $��ComboBox��6   $��Center=�6#   $��1��6>   �� 5%   
   -   5        $��CityComboBox��5&      $��1��5%      $��25��6    $��70��6,     BaseComboBoxStyle#��[ 5&   '    �� SelectedItem 5%   7   �� *SelectedComboBoxItem+��5&   R   �� *
CityList+�� 5(   
   $��
DatePicker��6   $��Center=�6%   $��1��6@   $��1��6M   (  "System.Windows.Controls.DatePicker  5)   
   -   5        $#��CustomerDateOfBirthDatePicker��5)   I   $��1��6   $��1��6%   $��25��62   $��70��6>     BaseDatePickerStyle#��[ 5*   B      SelectedDate 6   �� *CustomerDateOfBirth+6B   �� 5,   
   $��Phone TextBox��6   $��Center=�6(   $��2��6C   �� 5-   
   -   5        $��CustomerPhoneTextBox��5-   6   $��2��6   $��25��6   $��70��6+   #��[  6r   ��6R   �� *CustomerPhone+6r   �� 5/   
   -   5        $��2��5/      $��3��6%   $��25��62   $��70��6>   $��Submit��6I   6Z   51      52      