   M S B A M L   `   `   `  ����K  GSemester_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SemesterProjectSemesterProject  5   	   $    SemesterProject.AppointmentLab   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SemesterProject     5   	     � WindowStartupLocation$  CenterScreen=�5   2    � Title$ AppointmentLab��5   	   $	��700��6!   $
��1200��6.   .��5	      � ��5
   
   �� 5       �� ImageSource$ hospitalimg.jpeg��6   .+�5   
   �� -   5         ��Name$ labelheading��5      $��Patient's Portal��6'   $��Center=�6B   $��48(�6f   $
��Bold"�6t   
�������$��Times New Roman)�6�   ���	#FF05003A$	��102��6�   $	��Top=�6�   �� 5   
   -   5        
�������$
��Left=�5   Q   $��68��6l   $��30,18,0,604q�6�   ��6$   Z� ��6;   Z� .��5      �� $��left-arrow.png��6   $��53��6,   $��37��67   5      �� 5   
   $��Appointments��6   $��Center=�6'   $��
47,157,0,0q�6K   $	��Top=�6_   $��99��6w   ���	#FF01032B$��Times New Roman)�6�   $��48(�6�   
�������$
��Left=�6�   $	��452��6�   �� 5   
   $��
47,256,0,0q�6   ���	#FF05003A$
��Left=�6<   $	��452��6W   $	��346��6c   $	��Top=�6p   .+�5      �� -   5        $ lbldate��5      $��Date:��6%    �� Left$ 28��65   
 �� Top$ 36��6F   $��16(�6V   $��74��6d   $��40��6o   
�������6{   �� 5      -   5        $ 	lbldoctor��5      $��Available doctor:��6'   $	 101��6C   $��16(�6T   $	��130��6b   $��40��6n   
�������$ 28��6�   �� 5      -   5         ��Name$ 	txtdoctor��5      $	 161��6,   $	 101��6>   $	��234��6O   $��40��6[   �� 5      -   5         ��Name$ btnapt��5      $��Book Appointment��6%   $	 161��6@   $	 237��6R   $	��213��6c   $��52��6o   $��22(�6|   
����������	#FF07780C6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ txtdate��5      $	 161��6*   $ 41��6<   $	��234��6L   $��24��6X   	 J� RenderTransformOrigin$	 0.474,0.835&�6d   �� 5      -   5        $ lbltype��5      $��	Test Type��6%   $	 165��69   $��16(�6J   $	��130��6X   $��40��6d   
�������$ 28��6�   �� 5      -	   5        
 ��Name$
 txttype��5      $��40��6'   $	 161��63    �� TextWrapping$
 Wrap=�6E   $	 165��6Y   $	��236��6j   $��14(�6v   5      &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ labdata��5      $
��Left=�6$   $	��186��6?   $��552,284,0,0q�6L   $	��Top=�6a   $	��451��6y   5      5      