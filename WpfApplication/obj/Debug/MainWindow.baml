   M S B A M L   `   `   `  ����I  EWpfApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApplicationWpfApplication  5   	       WpfApplication.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfApplication     5   	   -   5          �Name$  Database��5   	    � Title$ 
MainWindow��5   	   
 � Top$	 200��6    � Left$	 600��6&   $	��350��61   $	��530��6>   .��5	      � .+�5
   
   �� -   5         ��Name$ listBox��5
      $��Right=�6$   $	��274��6@   $��0,27,0,0q�6M   $	��Top=�6_   $	��522��6w    �� View 5      �� 5      .P�5      �� $��Id��6%    �� Width$ 25��61    �� DisplayMemberBinding 6<   �� *Id+6b   �� 5      $��FirsName��6%   $	 120��67    6C   �� *	FirstName+6p   �� 5      $��LastName��6%   $	 120��67    6C   �� *
LastName+6o   �� 5      $��Email��6%   $	 120��64    6@   �� *Email+6i   �� 5      $	��Age��6%   $ 40��62    6=   �� *Age+6d   5      5      �� 5   
   -   5         ��Name$ 
Add_Column��5      $#��Добавить строку��6%   $
��Left=�6?   $	��Top=�6Z   $	��101��6r   6~   �� 5   
   -   5        $ Deleted_Column��5      $!��Удалить строку��6)   $
��Left=�6B   $��	106,0,0,0q�6]   $	��Top=�6p   $��95��6�   6�   �� 5   
   -   5        $ Сhanged_Column��5      $��Изменить��6)   $
��Left=�6<   $��	206,0,0,0q�6W   $	��Top=�6j   $��75��6�   6�   5      5      