   M S B A M L   `   `   `  ����G  CGroupProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:GroupProject.ViewGroupProject.View  5   	   !    GroupProject.View.UserLogin   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:GroupProject.View     5   	     � Title$  	UserLogin��5   	   $	��450��6   $	��800��6(   .��5	      � .+�5
   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 0��6   $��2��6&   ��5      �� 5      .��5      �  � Color$ 	#FF010414��6'    � Offset$	 0.1Q�69   � 5      $ 	#FF020226��6'   $	 0.7Q�69   5      5      �� 5      $��Center=�6   .+�5      �� $��Images/User.png��6   $��80��61   �� 5      $��
User Login��6   $��Light"�6.   $��	helvetica)�5      $��22(�63   ���#f5ba1d$��Center=�5      5      �� 5!      $��1��6   .+�5"      ��  �� Orientation$ 
Horizontal=�6   .+�5#      �� -   5        $��User_Username��5#      $��	Helvetica)�64   $��20(�5$      $��Light"�5%      $��Username��5&      $��Center=�5'      
�������
������ $��0q�5*      $	��235��5+      $
��Left=�5,       J� Opacity$	 0.5Q�5-      $��25��6,   $��63,0,0,0q�5.      �� 5/      $��Images/Username_Light.png��6   $��25��6?   51      �� 52      $	��250��6   $��2��6%   
�������$	 0.5Q�53      �� 54      $ 
Horizontal=�6   $��0,20,0,0q�66   .+�55      G� -   5        $��User_Password��55   "   $��	Helvetica)�67   $��Light"�56   "    G� Password$ Password��57   "   $��20(�58   "   $��Center=�59   "   
�������
������ $��0q�5<   "   $	��235��5=   "   $
��Left=�5>   "   $	 0.5Q�5?   "   $��25��60   $��63,0,0,0q�5@   "   �� 5A      $��Images/Password_Light.png��6   $��20��6?   5D      �� 5E      $	��250��6   $��2��6%   
�������$	 0.5Q�5F      �� 5G      $ 
Horizontal=�6   $��0,50,0,0q�66   $��Center=�5H      .+�5I      �� $	��100��6   $��40��6)   $��LOGIN��65   $��	60,0,60,0q�5J      $��Center=�60   ��5K      ��  �� Path$ LoginCommand�5M      5O      �� 5R      -   5        	 ��Name$	 CloseBtnStyle��5R         CloseBtnStyle#��[  5S      5T      5V      �� 5W   
   $��STUDENT MANAGEMENT SYSTEM��6   
�������$��Bottom=�6G   $��Right=�5X      $��	0,0,35,10q�60   �� 5Y   
   $��Images/Logo.png��6   $��30��6)   $��Bottom=�65   $��Right=�5Z      $��0,0,5,5q�6,   5[      5\      