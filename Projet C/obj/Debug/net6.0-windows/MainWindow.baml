   M S B A M L   `   `   `  ����C  ?Projet C, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Projet_CProjet_C  5   	       Projet_C.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Projet_C     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��3* �6   .+�5   
   �� -   5         ��Name$ menu_selection��5   0   $��0��6   $��0��6    .@�5      �� .��5      �� .��6   User6   5      �� 5      .��5      �� .��6   
video game6$   5      �� 5      .��5      �� .��6   loan6   5      5      � 5   
   -   5         �Name$ 	grid_user��5   ,   $��0��6   $��1��6   $y�	Collapsed=�6?   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dg_user��5         AutoGenerateColumns$
 True��6(   6F   5      � 5    
   -   5        $ grid_video_game��5    ,   $��0��6   $��1��6   $y�	Collapsed=�6E   .+�5!      �� .��6   video game management6+   5"      � 5%   
   -   5        $ grid_user_loan��5%   ,   $��0��6   $��1��6   $y�	Collapsed=�6D   .+�5&      �� .��6   loan management6%   5'      � 5)   
   -   5        $ Login_ui��5)   �   $��0��6   $��2��6   $��0��63   $��Stretch=�6@   $��Stretch=�6^   
�������.+�5*      �� $��Center=�6   $��Center=�66   $	��100��6Q   .+�5+      �� $
��Bold"�6   $
��Left=�6*   .��6L   
UserName6V   �� 5,      -   5         ��Name$ 
login_user��5,      60   �� 5-      $
��Bold"�6   .��6*   
Password64   G� 5.      -   5         G�Name$ 	login_pwd��5.      $��0,0,0,10q�61   6F   �� 5/      -	   5         ��Name$ login_error_text��5/   g   $
��Bold"�6   
���  ��$y�	Collapsed=�6?   $��0,0,0,5q�6V   .��6�   Wrong user/password6�   �� 50      -
   5        $��
Connection��50      6K   51      52      53      54      