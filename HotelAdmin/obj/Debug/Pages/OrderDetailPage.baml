   M S B A M L   `   `   `  ����E  AHotelAdmin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:HotelAdmin.PagesHotelAdmin.Pages  5      &     HotelAdmin.Pages.OrderDetailPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:HotelAdmin.Pages     5        N� Title$  OrderDetailPage��5	      .��5      � -   5         � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      �� 5      $��30 �6   .+�5   
   �� $��2��6   $��18(�6(   $
��Bold"�66   $��Center=�6H   $��Center=�6e   Бронирование6�   �� 5   
   $��1��6   $��2��6!   $��Center=�65   $��Center=�6R   $
��Bold"�6m   Детали заказа6�   �� 5   
   $��2��6   $��Center=�6!   $��Center=�6>   Номер:6a   �� 5   
   $��3��6   $��Center=�6!   $��Center=�6>   Бронь с:6c   �� 5   
   $��4��6   $��Center=�6!   $��Center=�6>   Бронь по:6d   �� 5    
   $��5��6   $��Center=�6!   $��Center=�6>   " Количество ночей:6l   �� 5!   
   $��6��6   $��Center=�6!   $��Center=�6>   Сумма к оплате:6j   �� 5"   
   -   5        $��8��5"      $��5q�6   .��6>   
Назад6E   �� 5#   
   -   5        $��8��5#      $��5q�6   $��1��6)   .��6N   Оплатить6X   �� 5%   
   -   5        $��textBlockRoom��5%   <   $��5q�6   $��2��6   $��1��6,   6<   (  "System.Windows.Controls.DatePicker  5&   
   -   5        $��datePickerStart��5&   =   $��5q�6   $��3��6    $��1��6-   6=     5'   
   -   5        $��datePickerEnd��5'   =   $��5q�6   $��4��6    $��1��6-   6R   �� 5(   
   -   5        $��textBlockNoches��5(   <   $��5q�6   $��5��6   $��1��6,   6<   �� 5)   
   -   5        $��textBlockPrice��5)   <   $��5q�6   $��6��6   $��1��6,   6<   5*      5+      