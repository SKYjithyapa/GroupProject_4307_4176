   M S B A M L   `   `   `  ����G  CGroupProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:GroupProjectGroupProject  5   	       GroupProject.AdminLogin   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:GroupProject     5   	     � Title$  
AdminLogin��5   	   $	��450��6   $	��380��6)    � WindowStyle$
 None=�5	   	    � AllowsTransparency$
 True��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5         GroupProject.AdminLoginVM  5   
   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5   
   ��  �� CornerRadius$ 0��6   $��2��6"   ��5      �� 5      .��5      �  � Color$ 	#FF010414��6#    � Offset$	 0.1Q�65   � 5      $ 	#FF020226��6#   $	 0.7Q�65   5      5       �� 5"   
   $��Center=�6   .+�5#      �� $��Images/Admin.png��6   $��80��6.   �� 5$      $��Admin Login��6   $��Light"�6+   $��	helvetica)�5%      $��22(�63   ���#f5ba1d$��Center=�5'      5(      �� 5+      $��1��6   .+�5,      �� 	 �� Orientation$	 
Horizontal=�6   .+�5-      �� -   5        $��Admin_Username��5-      $��	Helvetica)�61   $��20(�5.      $��Light"�51      $��Center=�53      
�������
������ $��0q�56      $	��235��57      $
��Left=�58      
 J� Opacity$	
 0.5Q�59      $��25��6,   $��63,0,0,0q�5:      ��52      �� *
UserName+5:      �� 5;      $��Images/Username_Light.png��6   $��25��6;   5=      �� 5>      $	��250��6   $��2��6!   
�������$	
 0.5Q�5?      �� 5@      $	 
Horizontal=�6   $��0,20,0,0q�62   .+�5A      �� -   5        $��Admin_Password��5A      $��	Helvetica)�60   $��Light"�5B   "   $��20(�5D   "   $��Center=�5E   "   
�������
������ $��0q�5I   "   $	��235��5J   "   $
��Left=�5K   "   $	
 0.5Q�5L   "   $��25��60   $��63,0,0,0q�5M   "   ��5C   "   �� *
Password+5M   "   �� 5N      $��Images/Password_Light.png��6   $��20��6;   5Q      �� 5R      $	��250��6   $��2��6!   
�������$	
 0.5Q�5S      �� 5T      $	 
Horizontal=�6   $��0,50,0,0q�62   $��Center=�5U      .+�5V      �� $	��100��6   $��40��6%   $��LOGIN��61   $��	60,0,60,0q�5W      $��Center=�60   ��5X      �� *LoginClickedCommand+5Z      5\      �� 5^   
   -   5         ��Name$ CloseBtnStyle��5^         CloseBtnStyle#��[  5_      ��5`      ��  �� Path$ CloseAction�5c      �� 5d      $��STUDENT MANAGEMENT SYSTEM��6   
�������$��Bottom=�6C   $��Right=�5e      $��	0,0,35,10q�60   �� 5f      $��Images/Logo.png��6   $��30��6%   $��Bottom=�61   $��Right=�5g      $��0,0,5,5q�6,   5h      5i      