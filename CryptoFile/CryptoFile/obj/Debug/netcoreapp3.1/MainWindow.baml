   M S B A M L   `   `   `  ����E  ACryptoFile, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CryptoFile
CryptoFile  5   	       CryptoFile.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:CryptoFile     5   	   -   5          �Name$  StartWindow��5   	    � Title$ AppCryptoFile_PiN Corp��5   	   $	��150��6(   $	��500��65    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	   .��5      �� .+�5      � $
��0 10q�6    � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Password��6   $��0��6#   $��0��63   $��Center=�6@   �� 5   
   $$��Security word (more 8 simbols)��6   $��1��69   $��0��6I   $��Center=�6V   �� 5       -   5         ��Name$ textBox_password��5       $��0��60   $��1��6@   $��Center=�6M   $	��200��6q   �� 5!      -   5        $ textBox_securityWord��5!      $��1��65   $��1��6E   $��Center=�6R   $	��200��6v   5#      � 5%   
    5&      �� 5'      �� 5(      .+�5+      �� -   5         ��Name$ button_encryptToFile��5+      $��Encrypt��63   $��Center=�6E   $	��100��6b   $
��0 20q�6n   
���  ��$
��Bold"�6�   $��0��6�   6�   �� 5,      -   5        $ button_decryptToFile��5,      $��Decrypt��63   $��Center=�6E   $	��100��6b   $
��0 20q�6n   
���  ��$
��Bold"�6�   $��1��6�   6�   5.      50      52      