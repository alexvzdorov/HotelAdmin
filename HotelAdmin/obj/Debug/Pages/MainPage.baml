   M S B A M L   `   `   `  ����E  AHotelAdmin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:HotelAdmin.PagesHotelAdmin.Pages  5          HotelAdmin.Pages.MainPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:HotelAdmin.Pages     5        N� Title$  MainPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��42 �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      �� 5      $��20 �6   .+�5   
   �� $!��Выберите номер��6   $��Center=�6*   $��Center=�6G   $��18(�6b   �� 5   
   -   5        $��1��5      $��2q�66   .��6A   Login6H   �� 5   
   -   5        $��listView��5      $��1��6#   $��2��60   $��Stretch=�6D   ��5      �� 5      .R�5      �  5      �� 5      $	��100 �6/   �� 5      �� 5      $	��100 �6/   .+�5       �� $��5q�6>   $
��Fill=�6I   ��6    �� *
PreviewPic+6I   � 5!      $��1��6    5"      �� 5#   "   �� 5$   "   �� 5%   "    5'      �� 5(   "   $	��150 �63   �� 5)   "   .+�5+      �� $��5q�6(   $
��Left=�64   $��Center=�6O   Номер:6r   �� 5,      $��1��6(   $
��Bold"�68   $
��Left=�6b   $��Center=�6}   ��6J   �� *Number+6}   �� 5-      $��5q�6(   $��1��63   $
��Left=�6A   $��Center=�6\   Класс:6   �� 5.      $��1��6(   $
��Bold"�65   $��1��6G   $
��Left=�6n   $��Center=�6�   ��6W   �� *Class+6�   �� 5/      $��5q�6(   $��2��63   $
��Left=�6@   $��Center=�6[    Количество мест:6�   �� 50      $��2��6(   $
��Bold"�65   $��1��6G   $
��Left=�6q   $��Center=�6�   ��6W   �� *
PlaceQty+6�   51      �� 52      $��2��6$   $��Center=�6K   $��Center=�6h   $
��Bold"�6�   ��64   �� *Price+6�   53      54      56      �� 58   
   -   5        $��textBoxPrice��58   7   $��2��6   $#��Поиск по цене до��6   67   �� 59   
   -   5        $��buttonSearch��59   .   $��2��6   $��1��6   $
��Left=�6B   $��42��6]   .��5:      �� -   5        $��
searchIcon��5:      $H��Bhttp://s1.iconbird.com/ico/2013/9/452/w512h5121380477032search.png��6&   5;      5<      5=      