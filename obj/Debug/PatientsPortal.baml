   M S B A M L   `   `   `  ����K  GSemester_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SemesterProjectSemesterProject  5   	   $    SemesterProject.PatientsPortal   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SemesterProject     5   	     � WindowStartupLocation$  CenterScreen=�5   2    � Title$ PatientsPortal��5   	   $	��700��6    $
��1200��6-   .��5	      � ���	#FF6B60CD.+�5   
   �� -   5         ��Name$ labelheading��5      $��Patient's Portal��6'   $��Center=�6B   $��48(�6f   $
��Bold"�6t   
�������$��Times New Roman)�6�   ���	#FF05003A$	��102��6�   $	��Top=�6�   �� 5   
   -   5        
�������$
��Left=�5   Q   $��68��6l    �� Left$	 361��6w   
 �� Top$ 63��6�   $��30,18,0,604q�6�   ��6$   Z� ��6;   Z� .��5      �� $��left-arrow.png��6   $��53��6,   $��37��67   5      �� 5   
   $��346,156,336,41q�6    J� OpacityMask
 �   ����	#FF4A3FAE.+�5      �� -   5        $
��Left=�5   X   $��96��6s   $	��100��6~   $ 69��6�   $	 242��6�   ��6   Z� ��6+   Z� ��6B   Z� .��5      �� $��appointments.png��6   $��80��62   $��72��6=   5      �� 5      $��See doctors��6   $
��Left=�6*   $	��Top=�6E   $��14(�6]   $��34��6k   $��94��6w   $
��Bold"�6�   
�������$	 329��6�   $	 177��6�    J� RenderTransformOrigin$ 0.596,1.021&�6�   ��6�   Z� 6�   �� 5      -   5        $
��Left=�5   X   $��96��6s   $	��100��6~   $	 329��6�   $ 72��6�   ��6   Z� ��6+   Z� ��6B   Z� .��5      �� $��doctors.png��6   $��74��6-   $	��101��68   5      �� 5      $��Manage Appointments��6   $
��Left=�62   $	��Top=�6M   $��14(�6e   $��34��6s   $	��167��6   $
��Bold"�6�   
�������$ 33��6�   $	 347��6�   ��6�   Z� 6�   �� 5      -   5        $
��Left=�5   X   $��96��6s   $	��100��6~   $ 63��6�   $ 72��6�   ��6   Z� ��6+   Z� ��6B   Z� .��5      �� $��
update.png��6   $��72��6,   $��99��67   5      �� 5      $��Update details��6   $
��Left=�6-   $	��Top=�6H   $��14(�6`   $��34��6n   $	��104��6z   $
��Bold"�6�   
�������$ 55��6�   $	 177��6�   ��6�   Z� 6�   �� 5      $��Select Options:��6   $	��Top=�6.   $��59��6F   $��24(�6R   
�������$
��Left=�6s   $	��206��6�   $
��Bold"�6�   $ 2��6�   �� 5      -   5        $
��Left=�5   X   $��96��6s   $	��100��6~   $	 329��6�   $	 246��6�   ��6   Z� ��6+   Z� ��6B   Z� .��5      �� $��lab.png��6   $��80��6)   $��72��64   5       �� 5!      $��Lab Appointments��6   $
��Left=�6/   $	��Top=�6J   $��14(�6b   $��34��6p   $	��144��6|   $
��Bold"�6�   
�������$	 309��6�   $	 346��6�   ��6�   Z� 6�   5#      9� 5$   
   $��Profile��6   $	��327��6$   $��22(�60   
�������$
 -134��6Q   ���	#FF6B60CD 9� 
IsExpanded . $
 -160��6�   $��0,103,865,-3q�6�   ��6c   Z� .��5%      �� -   5         ��Name$ listboxprofile��5%         profiletemplate#���   6.   ���	#FF6B60CD$��0,0,-2,0q�6v   ���	#FF6B60CD$
��Left=�6�   $	��327��6�   	 � 	Resources	 5&      
 �� ImageSource��%�  &	        �� 5'      .R�5(      � $	��594��6   $	��293��6,   ���	#FF6B60CD.+�5)      A� $
��Auto��6&   $��80��63   $��27,19,174,495q�6?   ��5*   "   �� 5+   &   $
 patients.png��61   5-      �� 5.      $��Profile Information:��6$   $��center=�6C   $
��Left=�6g   $��2,99,0,0q�6�   $	��Top=�6�   $��61��6�   $��20(�6�   $	��288��6�   
�������6�   �� 5/      $��center=�6D   $
��Left=�6g   $��	2,160,0,0q�6�   $	��Top=�6�   $��61��6�   $��16(�6�   $	��288��6�   
���������6$   �� *ProfileName+6�   �� 50      $��center=�6C   $
��Left=�6f   $��	2,224,0,0q�6�   $	��Top=�6�   $��61��6�   $��16(�6�   $	��288��6�   
���������6$   �� *
ProfileAge+6�   �� 51      $��center=�6C   $
��Left=�6f   $��	2,285,0,0q�6�   $	��Top=�6�   $��60��6�   $��16(�6�   $	��288��6�   
���������6$   �� *
ProfileDOB+6�   �� 52      $��center=�6E   $
��Left=�6h   $��	2,345,0,0q�6�   $	��Top=�6�   $��61��6�   $��16(�6�   $	��288��6�   
���������6$   �� *ProfileEmail+6�   �� 53      $��center=�6B   $
��Left=�6e   $��	2,406,0,0q�6�   $	��Top=�6�   $��60��6�   $��16(�6�   $	��288��6�   
���������6$   �� *	ProfileBg+6�   �� 54      $��center=�6G   $
��Left=�6j   $��	2,466,0,0q�6�   $	��Top=�6�   $��61��6�   $��16(�6�   $	��288��6�   $ 5.487,1.115&�6�   
���������6$   �� *ProfileAddress+6�   55      56      57      58      59      5:      5;      