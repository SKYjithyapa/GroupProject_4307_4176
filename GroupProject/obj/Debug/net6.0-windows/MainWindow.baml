   M S B A M L   `   `   `  ����G  CGroupProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:GroupProjectGroupProject  5   	       GroupProject.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:GroupProject     5   	     � Title$  
MainWindow��5   	   $	��700��6   $
��1000��6)    � WindowStyle$
 None=�5	   	    � AllowsTransparency$
 True��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5         GroupProject.MainWindowVM  5   
   6    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ 
Theme.xaml?�6%   %    5      .��5      � .+�5   
   ��  �� CornerRadius$ 0��6   $��2��6"   ��5      �� 5      .��5      � 	 � Color$	 	#FF010414��6#   
 � Offset$	
 0.1Q�65   � 5      $	 	#FF020226��6#   $	
 0.7Q�65   5      5       �� 5!   
   $��1��6   $	��350��6   
�������$��
500,90,0,0q�6<    J� Opacity$	 0.5Q�5"      $
��Left=�6#   $	��Top=�6>   �� 5$   
   $	��550��6   $	��Top=�6"    �� Orientation$ 
Horizontal=�6:   .+�5&      �� $	��500��6   $
��Left=�6%   .+�5'      �� $ Vertical=�6   $	��Top=�64   $��	40,55,0,0q�6L   .+�5(      �� $��ABOUT��6    
�������$��40(�6@   $	 0.5Q�6N   �� 5)      $��10,0,0,0q�6    $��Developed by ��62   
�������$��20(�6Z   $	 0.5Q�6h   $
��Left=�6v   �� 5*      $��10,0,0,0q�6    $(��"- Samarakoon P. G. C. EG/2020/4176��62   
�������$��20(�6o   $	 0.5Q�6}   $
��Left=�6�   �� 5+      $��10,0,0,0q�6    $+��%- Yaparathna Y. M. S. K. EG/2020/4307��62   
�������$��20(�6r   $	 0.5Q�6�   $
��Left=�6�   5,      5-      �� 5.      $	��500��6   $��Right=�6%   .+�5/      �� $ Vertical=�6   $	��Top=�64   $��	40,55,0,0q�6L   .+�50      �� $��LOGIN��6    
�������$��40(�6@   $	 0.5Q�6N   52      �� 53      $ Vertical=�6   $��Bottom=�64   $��
0,70,10,20q�6O   .+�54      ��    AdminImageButtonStyle#��[  6   ��55      ��  �� Path$ openAdminLoginCommand��� 56        UserImageButtonStyle#��[ 6   ��57      �� $ openUserLoginCommand�58      5<      5=      �� 5@   
   $	��150��6   $��Bottom=�6"   ���#000033$ 
Horizontal=�5A      .+�5B      �� $ 
Horizontal=�6   .+�5C      �� $��Images/Logo.png��6   $	��110��61   $	��110��6=   $��
10,10,0,10q�6J   �� 5D      $��1��6   $ Vertical=�6-   .+�5E      �� $��STUDENT MANAGEMENT SYSTEM��6    $��	20,27,0,0q�6A   $��Center=�5F       $��25(�6;   ���#f5ba1d6I   �� 5G      $��FACULTY OF ENGINEERING��6    $��20,2,0,0q�6>   $��Center=�5H       $��15(�6;   ���#f5ba1d6I   �� 5I      $��UNIVERSITY OF RUHUNA��6    $��20,0,0,0q�6<   $��Center=�5J       $��15(�6;   ���#f5ba1d6I   �� 5K      $ ��HAPUGALA, GALLE, SRI LANKA��6    $��20,0,0,0q�6B   $��Center=�5L       $��15(�6;   ���#f5ba1d6I   5M      �� 5N      $��2��6   $ Vertical=�6-   $��60,0,0,0q�6D   .+�5O      �� $ 
Horizontal=�6!   .+�5P      �� $��Images/website.png��6    $��20��6<   $��0,39,0,0q�6H   �� 5Q      $��http://www.eng.ruh.ac.lk��6$   $��	20,35,0,0q�6D   $��Center=�5R       $��15(�6;   
�������6I   5S      �� 5T      $ 
Horizontal=�6!   .+�5U      �� $��Images/email.png��6    $��25��6:   $��0,10,0,0q�6F   �� 5V      $��webmaster@eng.ruh.ac.lk��6$   $��20,6,0,0q�6C   $��Center=�5W       $��15(�6;   
�������6I   5X      �� 5Y      $ 
Horizontal=�6!   .+�5Z      �� $��Images/phone.png��6    $��20��6:   $��0,10,0,0q�6F   �� 5[      $��+(94)0 91 2245765/6��6$   $��	20,10,0,0q�6?   $��Center=�5\       $��15(�6;   
�������6I   5]      5`      5b      5c      �� 5d   
   -   5         ��Name$ CloseBtn��5d        CloseBtnStyle#��[ 5e      5f      5h      5i      