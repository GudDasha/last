   M S B A M L   `   `   `  ����R  NМероприятия1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Мероприятия1Мероприятия1  5      +    %Мероприятия1.Authorization   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Мероприятия1     5        N� Title$  Authorization��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   6*   �� 5      6   �� 5      $��70 �6   6*    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��Center=�6   $��2��6.   $��30(�6B   .��6Q   Авторизация6^   �� 5   
   $��Right=�6   $��0 0 20 0q�61   $��Center=�6C   $��1��6^    �� Orientation$ Vertical=�6k   .+�5      �� $��15(�6   .��6#   
Логин6*   �� 5      $��15(�6   .��6#   Пароль6+   5      �� 5   
   $ Vertical=�6   $
��Left=�6,   $��Center=�6G   $��1��6b   $��1��6o   $��20 0 0 0q�6   .+�5      �� -   5         ��Name$ txtLogin��5      $	��150��6(   $��15(�64   $��0 0 0 10q�6B   6V   G� 5      -   5         G�Name$ 
pbPassword��5      $��15(�6.   6>   5      �� 5   
   $ 
Horizontal=�6   $��2��6.   $��2��6;   $��Center=�6O   .+�5      �� -   5         ��Name$ btnLogIn��5      $	��100��6'   $��30��63   $��0 0 10 0q�6?   .��6i   
Войти6p   �� 5       -   5        $ 	btnLogOut��5       $	��100��6(   $��30��64   .��6X   
Выйти6_   5!      5"      5#      