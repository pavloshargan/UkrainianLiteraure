   M S B A M L   `   `   `  ����M  IUkrainianLiteraure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:UkrainianLiteraureUkrainianLiteraure  5   	   #    UkrainianLiteraure.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:UkrainianLiteraure     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5
      � -   5        $��MyGrid��5
      ���#0b4154.+�5   
   �� -   5        $��MyList��5   '   $��50,0,0,0q�6   $��Disabled=�66   ��5      �� 5       �� ImageSource$0 *bin/Debug/images/icons/PaperBackground.jpg��6   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$	 150��6.   �� 5       � ��$	 200��6/   �� 5       � �� 5      u� 5       u� Left$ 15Q�6(   
 u� Top$ 15Q�62    u� Right$ 15Q�6;    u� Bottom$ 15Q�6F   5      -   5        �� 5       � �� 5      �� 5      	 �� 
TargetType"	 ��6.   .R�5   "   �� 
 ��Name$
 Bd��6)   #��z��65   #��z��6a   #��z��6�    �� Padding# z��6�    J� SnapsToDevicePixels . ._�5   &   �� #��z��67   # z 6z   #��z��6�   5    #    �� Triggers 5!   "   P� 5"   &    P� Property � {� P� Value .  . �5#   *   �� # � ��6G    � ��5$   '   P� 5%   &    �@J�IsMouseOver . . �5&   *   ��  � z� 5'   .   �� 5(   2    �� ScaleX$
 1.15Q�6A    �� ScaleY$
 1.15Q�6O    �� CenterX$ 50Q�6]    �� CenterY$ 50Q�6j   5*   +   5+   '   5-      5/      50      ��52      �� 53      .R�54      � 55      58      �� 59   
   -   5        $��AuthorPanel��59   )   $��50,0,0,0q�6   $y�Hidden=�6=   
�������.��5:      �� -   5        $��AuthorsStack��5:   +   $��0,0,50,0q�6   .+�5>      �� -   5        $��AuthosPortrait��5>   M   $
��Left=�6   $	��250��64   $	��200��6A   6M   �� 5?      $��200,-250,0,0q�6   .+�5@      �� -   5        $��AuthorsName��5@   `   
����� �$
��Wrap=�66   $��15(�6J   $�� ��6X   6`   �� 5A      
����� �$��Роки життя:��6.   �� 5B      -   5        $��AuthorsYears��5B   8   $
��Wrap=�6   $�� ��60   68   �� 5C      
����� �$��Твори:��6/   �� 5D      -	   5        $��
AuthorsBks��5D      �� 5F      -
   5        $��AuthorsPeriphrases��5F   8   $
��Wrap=�6   $�� ��60   68   5G      �� 5H      -   5        $��AuthorsDescription��5H   4   $
��Wrap=�6   $�� ��6,   64   5I      5J      �� 5K   
   -   5        $��	BookPanel��5K   )   $��50,0,0,0q�6   $y�Hidden=�6;   
�������.��5L   
   �� $��0,0,50,0q�6   .+�5P      �� -   5        $��	BooksName��5P   y   $
��Wrap=�6   $��Center=�60   $��30(�6M   
����� �$�� ��6q   6y   �� 5Q      -   5        $
��Read��5Q      $��Читати��6%   $��50��66   $��30��6A   
������ $��0q�6f   
����� �6�   �� 5R      -   5        $��BooksAuthor��5R   Y   $
��Wrap=�6   $�� ��60   $��15(�68   $��Italic$�6F   5S      �� 5T      -   5        $��
BooksGenre��5T   8   $
��Wrap=�6   $�� ��60   68   �� 5U      -   5        $��
BooksStyle��5U   8   $
��Wrap=�6   $�� ��60   68   �� 5V      -   5        $��
BooksTheme��5V   8   $
��Wrap=�6   $�� ��60   68   �� 5W      -   5        $��	BooksIdea��5W   8   $
��Wrap=�6   $�� ��60   68   �� 5Y      -   5        $��BooksHeroes��5Y   8   $
��Wrap=�6   $�� ��60   68   �� 5Z      -   5        $��BooksPlaces��5Z   8   $
��Wrap=�6   $�� ��60   68   �� 5[      -   5        $��BooksDescription��5[   8   $
��Wrap=�6   $�� ��60   68   5]      5_      �� 5a   
   -   5        $��ReaderPanel��5a   <   $��50,0,0,0q�6   
�������$y�Hidden=�6O   .��5b   
   �� .+�5d      �� -   5        $��BookContent��5d   X   $
��Wrap=�6   $��Center=�6,   $��14(�6J   $��50,50,50,50q�6k   5e      5f      �� 5h   
   -   5        $��	TestPanel��5h      $y�Hidden=�6(   $��50,0,0,0q�6<   .��5i      �� -   5        $��TestSp��5i      5k      5l      �� 5o   
   -   5        $��	SearchBox��5o   >   $y�Hidden=�6   $	��Top=�6&   $��50,0,0,0q�6O   $��25��6v   �� 5q   
   .+�5u      �� -   5        $��spLeft��5u   P    K� ZIndex$ 15��6      spSlideLeft#��[  6+   ���#0a3747$	��200��6s   $��-150,30,0,0q�6   .+�5x      ]� $��Center=�6   $��Right=�67   $	��200��6S   $��50��6_   .+�5y      �� -   5          	MenuLabel#���  5y      $	��140��6@   $��
Твори��6L   $��Center=�6\   $��Segoe UI Semibold)�6�   �� 5z      $&�� bin/debug/images/icons/books.png��6   $��25��6F   $��25��6Q   $��Center=�6]   $��Center=�6x   $��14,10,10,10q�6�   5|      ]� 5~      $��Center=�6   $��Right=�67   $	��200��6S   .+�5      �� -   5        #���  5      $��Автори��6@   $	��140��6Q   $��Center=�6]   $��Source Sans Pro)�6�   �� 5�      $(��"bin/debug/images/icons/feather.gif��6   $��25��6H   $��25��6S   $��Center=�6_   $��Center=�6z   $��14,10,10,10q�6�   5�      ]� 5�      $��Center=�6   $��Right=�67   $	��200��6S   .+�5�      �� -   5        #���  5�      $'��!Теорія літератури��6@   $	��140��6\   $��Center=�6h   $��Source Sans Pro)�6�   �� 5�      $'��!bin/debug/images/icons/theory.png��6   $��25��6G   $��25��6R   $��Center=�6^   $��Center=�6y   $��14,10,10,10q�6�   5�      ]� 5�      $��Center=�6   $��Right=�67   $	��200��6S   .+�5�      �� .+�5�      �� -    5        #���  5�       $��
Тести��6D   $	��140��6T   $��Center=�6`   $��0,15,0,0q�6�   $��Source Sans Pro)�6�   5�      �� 5�      $)��#bin/debug/images/icons/document.png��6   $��25��6I   $��25��6T   $��Center=�6`   $��Center=�6{   $��14,10,10,10q�6�   5�      ]� 5�      $��Center=�6   $��Right=�67   $	��200��6S   .+�5�      �� -!   5        #���  5�      $��
Пошук��6j   $	��140��6z   $��Center=�6�   $��Source Sans Pro)�6�   �� 5�      $'��!bin/debug/images/icons/search.png��6   $��25��6G   $��25��6R   $��Center=�6^   $��Center=�6y   $��14,10,10,10q�6�   5�      5�      5�      �� 5�   
   -"   5        $��BackIcon��5�   z   
 � Tag$
 list��6(   $
��Left=�63   $	��Top=�6N   $y�Hidden=�6f   $��30��6�   $��25��6�   $��13,5,0,0q�6�   ��5�      �� 5�      " ��6   .�5�      ��  � ��$ 0q�68   �� 5�       � �� 5�      �� 5�      "	 ��6.   .R�5�   "   �� $
 Bd��6)   #��z��65   #��z��6a   #��z��6�   # z��6�    . ._�5�   &   �� #��z��67   # z 6z   #��z��6�   5�   #    5�   "   P� 5�   &    � {� .  . �5�   *   �� # � ��6G    � ��5�   '   P� 5�   &    �@J�IsMouseOver . . �5�   *   ��  � z� 5�   .   �� 5�   2   $
 1.15Q�6A   $
 1.15Q�6O   $ 50Q�6]   $ 50Q�6j   5�   +   5�   '   5�      5�      5�      ��5�      �� 5�      $% bin/Debug/images/icons/back.png��6   5�      5�      5�      