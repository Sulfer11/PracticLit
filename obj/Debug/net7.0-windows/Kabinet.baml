   M S B A M L   `   `   `  ����A  =WPF_PR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPF_PRWPF_PR  5   	       WPF_PR.Kabinet   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WPF_PR     5   	   -   5          � Title$!  Личный кабинет��5   	   $	��550��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69   
���/kU�.��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5       � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5       6!   �� 5!      6!   .+�5#   
   �� -   5        $
��Imya��5#   1   $��0��6   $��0��6!   $y�	Collapsed=�6=   �� 5$   
   $��1��6   $��1��6   $��Image\1.png��6-   �� 5%   
   -   5        $��Login��5%   C   $��2��6   $��1��6"   $��7��6/   $��25(�6P   
 � Tag$ 
Логин��6^      placeHolder#��[  6j   �� 5&   
   -   5        $��LogRed��5&   Y   $��2��6   $��2��6!   $��7��61   $y�Hidden=�6E   $��5��6g   $	��Top=�6r   
���  ��6�   �� 5'   
   -   5        $��
Errorlogin��5'   E   $��2��6   $��2��6!   $��7��61    �� TextAlignment$ Center=�6W   �� 5(   
   $��3��6   $��1��6   $��Image\4.png��6-   �� 5)   
   -   5        $��Email��5)   Q   $��3��6   $��2��6   $��7��6/   $��25(�6C   $ 
Почта��6^   #��[  6j   �� 5*   
   -   5        $��EmailRed��5*   Y   $��4��6   $��2��6!   $��7��61   $y�Hidden=�6E   $��5��6i   $	��Top=�6t   
���  ��6�   �� 5+   
   -   5        $��
Erroremail��5+   E   $��4��6   $��2��6!   $��7��61   $ Center=�6W   �� 5,   
   $��5��6   $��1��6   $��Image\2.png��6-   �� 5-   
   -	   5        $��Password��5-   C   $��5��6   $��2��6   $��7��6/   $��25(�6S   $ Пароль��6a   #��[  6n   �� 5.   
   -
   5        $��PassRed��5.   Y   $��6��6   $��2��6!   $��7��61   $y�Hidden=�6E   $��5��6h   $	��Top=�6s   
���  ��6�   �� 5/   
   -   5        $��	Errorpass��5/   E   $��6��6   $��2��6!   $��7��61   $ Center=�6V   �� 50   
   -   5        $��Vivod��50   E   $��7��6   $��2��6!   $��7��61   $��25(�6R   $ Center=�6`   �� 51   
   -   5        $��8��51      $��6��6   $��3��6.   $��Вернуться��6B   $��25(�6V   
���/kU���6�   Z� 6�   �� 52   
   -   5        $��8��52      $��2��6   $��4��6.   $+��%Сохранить изменения��6B   $��25(�6`   6n   53      54      